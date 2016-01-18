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
		//Enable remote debugger, so that you can debug web pages in geckofx via firefox:
		//1. Set your firefox's pref 'devtools.debugger.remote-enabled' to true, via 'about:config' page.
		//2. In firefox, go to Tools > Web Developer > Connect..., keep localhost:6000, click connect, confirm the dialog from geckofx.
		static bool RemoteDebuggerEnabled = true;

		[STAThread]
		public static void Main(string[] args)
		{
			// If you want to customize the GeckoFx PromptService then 
			// you will need make a class that implements some or all of nsIPrompt, 
			// nsIAuthPrompt2, and nsIAuthPrompt interfaces and
			// set the PromptFactory.PromptServiceCreator delegate. for example:
			// PromptFactory.PromptServiceCreator = () => new MyPromptService();
			// Gecko.PromptService already implements those interfaces, and may be sub-classed.

			string xulrunnerPath = XULRunnerLocator.GetXULRunnerLocation();
		    //xulrunnerPath = @"C:\mozilla-central\obj-i686-pc-mingw32\dist\bin";
#if GTK		
			if (!Environment.GetEnvironmentVariable("LD_LIBRARY_PATH").Contains(xulrunnerPath))
				throw new ApplicationException(String.Format("LD_LIBRARY_PATH must contain {0}", xulrunnerPath));			
#endif
			Xpcom.Initialize(xulrunnerPath);
			// Uncomment the follow line to enable error page
			GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;

			GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;

			GeckoPreferences.User["full-screen-api.enabled"] = true;

#if PORT
			if (RemoteDebuggerEnabled)
				StartDebugServer();
#endif

			Application.ApplicationExit += (sender, e) =>
			{
				Xpcom.Shutdown();
			};

			var mainForm = new MyForm();

			Gecko.LauncherDialog.Download += (s, e) => LauncherDialog_Download(mainForm, s, e);

			//Application.Idle += (s, e) => Console.WriteLine(SynchronizationContext.Current);
			Application.Run(mainForm);
		}

		static void RegisterChromeDir(string dir)
		{
			var chromeDir = (nsIFile)Xpcom.NewNativeLocalFile(dir);
			var chromeFile = chromeDir.Clone();
			chromeFile.Append(new nsAString("chrome.manifest"));
			Xpcom.ComponentRegistrar.AutoRegister(chromeFile);
			Xpcom.ComponentManager.AddBootstrappedManifestLocation(chromeDir);
		}

		static void StartDebugServer()
		{
			GeckoPreferences.User["devtools.debugger.remote-enabled"] = true;

			//see <geckofx_src>/chrome dir
			RegisterChromeDir(Path.GetFullPath(Path.Combine(XULRunnerLocator.GetXULRunnerLocation(), "../../chrome")));

			var browser = new GeckoWebBrowser();
			browser.NavigationError += (s, e) =>
			{
				Console.Error.WriteLine("StartDebugServer error: 0x" + e.ErrorCode.ToString("X"));
				browser.Dispose();
			};
			browser.DocumentCompleted += (s, e) =>
			{
				Console.WriteLine("StartDebugServer completed");
				browser.Dispose();
			};
			//see <geckofx_src>/chrome/debugger-server.html
			browser.Navigate("chrome://geckofx/content/debugger-server.html");
		}

		// From Timothy N in https://bitbucket.org/geckofx/geckofx-29.0/issue/34/how-to-download-files-using-this-engine
		static void LauncherDialog_Download(IWin32Window owner, object sender, LauncherDialogEvent e)
		{
			uint flags = (uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_NO_CONVERSION |
				(uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_REPLACE_EXISTING_FILES |
				(uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_BYPASS_CACHE;
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.FileName = e.Filename;
			if (sfd.ShowDialog(owner) == DialogResult.OK)
			{
				// the part that do the download, may be used for automation, or when the source URI is known, or after a parse of the dom :
				string url = e.Url;  //url to download
				string fullpath = sfd.FileName; //destination file absolute path
				nsIWebBrowserPersist persist = Xpcom.GetService<nsIWebBrowserPersist>("@mozilla.org/embedding/browser/nsWebBrowserPersist;1");
				nsIURI source = IOService.CreateNsIUri(url);
				nsIURI dest = IOService.CreateNsIUri(new Uri(fullpath).AbsoluteUri);
				persist.SetPersistFlagsAttribute(flags);
#if PORT_GECKO45
				persist.SaveURI(source, null, null, null, null, (nsISupports)dest, null);
#endif
				// file is saved - asynchronous call
				// need to try to have a temp name while the file is downloaded eg filename.ext.geckodownload (one of the SaveURI option)
			}
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

		protected GeckoWebBrowser AddTab()
		{
			var tabPage = new TabPage();
			tabPage.Text = "blank";
			var browser = new GeckoWebBrowser();
			browser.Dock = DockStyle.Fill;			
			tabPage.DockPadding.Top = 25;
			tabPage.Dock = DockStyle.Fill;

			// add a handler showing how to view the DOM
//			browser.DocumentCompleted += (s, e) => 	TestQueryingOfDom(browser);

			// add a handler showing how to modify the DOM.
//			browser.DocumentCompleted += (s, e) => TestModifyingDom(browser);

            // add a handle to detect when user modifies a contentEditable part of the document.
		    browser.DomInput += (sender, args) => MessageBox.Show(String.Format("User modified element {0}", (args.Target.CastToGeckoElement() as GeckoHtmlElement).OuterHtml));		    

			AddToolbarAndBrowserToTab(tabPage, browser);

			m_tabControl.TabPages.Add(tabPage);
			tabPage.Show();
			m_tabControl.SelectedTab = tabPage;

			// Uncomment this to stop links from navigating.
			// browser.DomClick += StopLinksNavigating;

			// Demo use of ReadyStateChange.
			// For some special page, e.g. about:config browser.Document is null.
			browser.ReadyStateChange += (s, e) => this.Text = browser.Document != null ? browser.Document.ReadyState : "";

			browser.DocumentTitleChanged += (s, e) => tabPage.Text = browser.DocumentTitle;

			browser.EnableDefaultFullscreen();

			// Popup window management.
			browser.CreateWindow += (s, e) =>
			{
				// A naive popup blocker, demonstrating popup cancelling.
				Console.WriteLine("A popup is trying to show: " + e.Uri);
				if (e.Uri.StartsWith("http://annoying-site.com"))
				{
					e.Cancel = true;
					Console.WriteLine("A popup is blocked: " + e.Uri);
					return;
				}

				// For <a target="_blank"> and window.open() without specs(3rd param),
				// e.Flags == GeckoWindowFlags.All, and we load it in a new tab;
				// otherwise, load it in a popup window, which is maximized by default.
				// This simulates firefox's behavior.
				if (e.Flags == GeckoWindowFlags.All)
					e.WebBrowser = AddTab();
				else
				{
					var wa = System.Windows.Forms.Screen.GetWorkingArea(this);
					e.InitialWidth = wa.Width;
					e.InitialHeight = wa.Height;
				}
			};

			return browser;
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

			Button print = new Button();
			print.Text = "Print";
			print.Left = open.Left + open.Width;

			Button scrollDown = new Button { Text = "Down", Left = closeWithDisposeTab.Left + 250 };
			Button scrollUp = new Button { Text = "Up", Left = closeWithDisposeTab.Left + 330 };

			scrollDown.Click += (s, e) => { browser.Window.ScrollByPages(1); };
			scrollUp.Click += (s, e) => { browser.Window.ScrollByPages(-1); };

			nav.Click += delegate
			{
				// use javascript to warn if url box is empty.
				if (string.IsNullOrEmpty(urlbox.Text.Trim()))
					browser.Navigate("javascript:alert('hey try typing a url!');");
				browser.Navigate(urlbox.Text);
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
			//url in Navigating event may be the mapped version,
			//e.g. about:config in Navigating event is jar:file:///<xulrunner>/omni.ja!/chrome/toolkit/content/global/config.xul
			browser.Navigating += (s, e) =>
			{
				Console.WriteLine("Navigating: url: " + e.Uri + ", top: " + e.DomWindowTopLevel);
			};
			browser.Navigated += (s, e) =>
			{
				if (e.DomWindowTopLevel)
					urlbox.Text = e.Uri.ToString();
				Console.WriteLine("Navigated: url: " + e.Uri + ", top: " + e.DomWindowTopLevel, ", errorPage: " + e.IsErrorPage);
			};

			browser.Retargeted += (s, e) =>
			{
				var ch = e.Request as Gecko.Net.Channel;
				Console.WriteLine("Retargeted: url: " + e.Uri + ", contentType: " + ch.ContentType + ", top: " + e.DomWindowTopLevel);
			};
			browser.DocumentCompleted += (s, e) =>
			{
				Console.WriteLine("DocumentCompleted: url: " + e.Uri + ", top: " + e.IsTopLevel);
			};

			print.Click += delegate { browser.Window.Print(); };

			tabPage.Controls.Add(urlbox);
			tabPage.Controls.Add(nav);
			tabPage.Controls.Add(newTab);
			tabPage.Controls.Add(stop);
			tabPage.Controls.Add(closeTab);
			tabPage.Controls.Add(closeWithDisposeTab);
			tabPage.Controls.Add(open);
			tabPage.Controls.Add(print);
			tabPage.Controls.Add(browser);
			tabPage.Controls.Add(scrollDown);
			tabPage.Controls.Add(scrollUp);
		}
	}
}

