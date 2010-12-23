using System;
using System.Windows.Forms;
using Skybound.Gecko;

// Tested with mono 2.6.3 and mono 2.8
// Run this with the following command:
// MONO_PATH=/usr/lib/cli/gdk-sharp-2.0/ LD_LIBRARY_PATH="/usr/lib/xulrunner-1.9.2.13/" mono --debug GeckoFxTest.exe
// requires gdk-sharp assembly in the gac (which is in package libgtk2.0-cil)
namespace GeckoFxTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// TODO FIXME: make better way of finding libxul.so etc.
			Xpcom.Initialize("/usr/lib/xulrunner-1.9.2.13/");
			
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
				if (m_tabControl.TabCount == 0) {
					AddTab();
				}
			};
			
		}

		protected void AddTab()
		{
			var tabPage = new TabPage();
			tabPage.Text = "blank";
			var browser = new GeckoWebBrowser();
			browser.Dock = DockStyle.Fill;
			
			tabPage.DockPadding.Top = 25;
			tabPage.Dock = DockStyle.Fill;
			
			AddToolbarAndBrowserToTab(tabPage, browser);
			
			m_tabControl.TabPages.Add(tabPage);
			tabPage.Show();
			m_tabControl.SelectedTab = tabPage;
		}

		protected void AddToolbarAndBrowserToTab(TabPage tabPage, GeckoWebBrowser browser)
		{
			TextBox urlbox = new TextBox();
			urlbox.Top = 0;
			urlbox.Width = 200;
			
			Button nav = new Button();
			nav.Text = "Go";
			nav.Left = 200;
			
			Button newTab = new Button();
			newTab.Text = "NewTab";
			newTab.Left = 200 + nav.Width;
			
			Button closeTab = new Button();
			closeTab.Text = "Close";
			closeTab.Left = 200 + nav.Width + newTab.Width;
			
			nav.Click += delegate {
				browser.Navigate(urlbox.Text);
				tabPage.Text = urlbox.Text;
			};
			
			newTab.Click += delegate { AddTab(); };
			
			closeTab.Click += delegate {
				m_tabControl.Controls.Remove(tabPage);
				browser.Dispose();
			};
			
			tabPage.Controls.Add(urlbox);
			tabPage.Controls.Add(nav);
			tabPage.Controls.Add(newTab);
			tabPage.Controls.Add(closeTab);
			tabPage.Controls.Add(browser);
		}
	}
}

