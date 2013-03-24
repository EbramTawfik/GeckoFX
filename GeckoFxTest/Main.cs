using System;
using System.Windows.Forms;
using Gecko;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

// Tested with mono 2.6.3 and mono 2.8
// Run this with the following command:
// MONO_PATH=/usr/lib/cli/gdk-sharp-2.0/ LD_LIBRARY_PATH="/usr/lib/xulrunner-1.9.2.13/" mono --debug GeckoFxTest.exe
// requires gdk-sharp assembly in the gac (which is in package libgtk2.0-cil)
namespace GeckoFxTest
{
	class MainClass
	{			
		[STAThread]
		public static void Main(string[] args)
		{
			// Uncomment the follow line to enable CustomPrompt's
			GeckoWebBrowser.UseCustomPrompt();						
			
			// If you want to further customize the GeckoFx PromptService then 
			// you will need make a class that implements nsIPromptService2 and nsIPrompt interfaces and
			// set the PromptFactory.PromptServiceCreator delegate. for example:
			// PromptFactory.PromptServiceCreator = () => new MyPromptService();
			
#if GTK		
			if (!Environment.GetEnvironmentVariable("LD_LIBRARY_PATH").Contains("/usr/lib/firefox/"))
				throw new ApplicationException(String.Format("LD_LIBRARY_PATH must contain {0}", "/usr/lib/firefox/"));
			
			Xpcom.Initialize("/usr/lib/firefox/");
#else
			Xpcom.Initialize(XULRunnerLocator.GetXULRunnerLocation());
#endif
			// Uncomment the follow line to enable CustomPrompt's
			// GeckoPreferences.User["browser.xul.error_pages.enabled"] = false;
			
			GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;			
			
			Application.ApplicationExit += (sender, e) => 
			{
        		Xpcom.Shutdown();
			};
			
			//Application.Idle += (s, e) => Console.WriteLine(SynchronizationContext.Current);
			Application.Run(new MyForm());
		}
	}

	class MyForm : Form
	{
		private TabControl m_tabControl;

		public MyForm()
		{
			this.Width = 800;
			this.Height = 600;

			m_tabControl = new TabControl();
			m_tabControl.Dock = DockStyle.Fill;

			AddTab();

			Controls.Add(m_tabControl);

			m_tabControl.ControlRemoved += delegate {
				if (m_tabControl.TabCount == 1) {
					AddTab();
				}
			};

		}

		protected void ModifyElements(GeckoElement element, string tagName, Action<GeckoElement> mod)
		{
			while (element != null)
			{
				if (element.TagName == tagName)
				{
					mod(element);
				}
				ModifyElements(element.FirstChild as GeckoHtmlElement, tagName, mod);
				element = (element.NextSibling as GeckoHtmlElement);
			}
		}

		protected void TestModifyingDom(GeckoWebBrowser browser)
		{
			GeckoElement g = browser.Document.DocumentElement;
			ModifyElements(g, "BODY", e =>
			              	{
								for(int i = 1; i < 4; ++i)
								{
									var newElement = g.OwnerDocument.CreateElement(String.Format("h{0}", i));
									newElement.TextContent = "Geckofx added this text.";
									g.InsertBefore(newElement, e);
								}
							});
		}

		protected void DisplayElements(GeckoElement g)
		{
			while (g != null)
			{
				Console.WriteLine("tag = {0} value = {1}", g.TagName, g.TextContent);
				DisplayElements(g.FirstChild as GeckoHtmlElement);
				g = (g.NextSibling as GeckoHtmlElement);
			}

		}

		protected void TestQueryingOfDom(GeckoWebBrowser browser)
		{
			GeckoElement g = browser.Document.DocumentElement;
			DisplayElements(g);
		}

		protected void AddTab()
		{
			var tabPage = new TabPage();
			tabPage.Text = "blank";
			var browser = new GeckoWebBrowser();
			browser.Dock = DockStyle.Fill;
			browser.DisableWmImeSetContext = true;
			tabPage.DockPadding.Top = 25;
			tabPage.Dock = DockStyle.Fill;

			// add a handler showing how to view the DOM
//			browser.DocumentCompleted += (s, e) => 	TestQueryingOfDom(browser);

			// add a handler showing how to modify the DOM.
//			browser.DocumentCompleted += (s, e) => TestModifyingDom(browser);

			AddToolbarAndBrowserToTab(tabPage, browser);

			m_tabControl.TabPages.Add(tabPage);
			tabPage.Show();
			m_tabControl.SelectedTab = tabPage;

			// Uncomment this to stop links from navigating.
			// browser.DomClick += StopLinksNavigating;

			// Demo use of ReadyStateChange.
			browser.ReadyStateChange += (s, e) => this.Text = browser.Document.ReadyState;
		}

		/// <summary>
		/// An example event handler for the DomClick event.
		/// Prevents a link click from navigating.
		/// </summary>
		private void StopLinksNavigating( object sender, DomEventArgs e )
		{
			if ( sender == null ) return;
			if ( e == null ) return;
			if ( e.Target == null ) return;

			var element = e.Target.CastToGeckoElement();

			GeckoHtmlElement clicked = element as GeckoHtmlElement;
			if ( clicked == null ) return;

			// prevent clicking on Links from navigation to the
			if ( clicked.TagName == "A" )
			{
				e.Handled = true;
				MessageBox.Show( sender as IWin32Window, String.Format( "You clicked on Link {0}", clicked.GetAttribute( "href" ) ) );
			}


		}

		protected void AddToolbarAndBrowserToTab(TabPage tabPage, GeckoWebBrowser browser)
		{
			TextBox urlbox = new TextBox();
			urlbox.Top = 0;
			urlbox.Width = 200;

			Button nav = new Button();
			nav.Text = "Go";
			nav.Left = urlbox.Width;

			Button newTab = new Button();
			newTab.Text = "NewTab";
			newTab.Left = nav.Left + nav.Width;

			Button stop = new Button
			              {
			              	Text = "Stop",
			              	Left = newTab.Left + newTab.Width
			              };

			Button closeTab = new Button();
			closeTab.Text = "GC.Collect";
			closeTab.Left = stop.Left + stop.Width;

			Button closeWithDisposeTab = new Button();
			closeWithDisposeTab.Text = "Close";
			closeWithDisposeTab.Left = closeTab.Left + closeTab.Width;

			Button open = new Button();
			open.Text = "FileOpen";
			open.Left = closeWithDisposeTab.Left + closeWithDisposeTab.Width;

			Button scrollDown = new Button { Text = "Down", Left = closeWithDisposeTab.Left + 250 };
			Button scrollUp = new Button { Text = "Up", Left = closeWithDisposeTab.Left + 330 };

			scrollDown.Click += (s, e) => { browser.Window.ScrollByPages(1); };
			scrollUp.Click += (s, e) => { browser.Window.ScrollByPages(-1); };

			nav.Click += delegate {
				// use javascript to warn if url box is empty.
				if (string.IsNullOrEmpty(urlbox.Text.Trim()))
					browser.Navigate("javascript:alert('hey try typing a url!');");

				try{
				browser.Navigate(urlbox.Text);
				}catch { }
				tabPage.Text = urlbox.Text;
			};

			newTab.Click += delegate { AddTab(); };

			stop.Click += delegate { browser.Stop(); };

			closeTab.Click += delegate {
				GC.Collect();
				GC.WaitForPendingFinalizers();
			};

			closeWithDisposeTab.Click += delegate
			{
				m_tabControl.Controls.Remove(tabPage);
				tabPage.Dispose();
			};

			open.Click += (s, a) =>
			{
				nsIFilePicker filePicker = Xpcom.CreateInstance<nsIFilePicker>("@mozilla.org/filepicker;1");
				filePicker.Init(browser.Window.DomWindow, new nsAString("hello"), nsIFilePickerConsts.modeOpen);
				filePicker.AppendFilter(new nsAString("png"), new nsAString("*.png"));
				filePicker.AppendFilter(new nsAString("html"), new nsAString("*.html"));
				if (nsIFilePickerConsts.returnOK == filePicker.Show())
				{
					using(nsACString str = new nsACString())
					{
						filePicker.GetFileAttribute().GetNativePathAttribute(str);
						browser.Navigate(str.ToString());
					}					
				}

			};

			tabPage.Controls.Add(urlbox);
			tabPage.Controls.Add(nav);
			tabPage.Controls.Add(newTab);
			tabPage.Controls.Add(stop);
			tabPage.Controls.Add(closeTab);
			tabPage.Controls.Add(closeWithDisposeTab);
			tabPage.Controls.Add(open);
			tabPage.Controls.Add(browser);
			tabPage.Controls.Add(scrollDown);
			tabPage.Controls.Add(scrollUp);
		}
	}
}

