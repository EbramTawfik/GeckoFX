using System;
using System.Windows.Forms;
using Skybound.Gecko;

// Tested with mono 2.6.3 and mono 2.8
// Run this with the following command:
// LD_LIBRARY_PATH="/usr/lib/xulrunner-1.9.2.10/" mono GeckoFxTest.exe
// requires gdk-sharp assembly in the gac (which is in package libgtk2.0-cil)
namespace GeckoFxTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// TODO FIXME: make better way of finding libxul.so etc.
			Xpcom.Initialize("/usr/lib/xulrunner-1.9.2.10/");
			//Xpcom.ForceInitialize("/usr/lib/xulrunner-1.9.2.10/");
			
			Application.Run(new MyForm());			
		}
	}
	
	class MyForm : Form
	{
		GeckoWebBrowser m_browser;
		
		public MyForm()
		{
			m_browser = new GeckoWebBrowser();			
			//m_browser.Dock = DockStyle.Fill;
			TextBox b = new TextBox();
			b.Top = 0;
			b.Width = 190;
			Button nav = new Button();
			Button prop = new Button();
			prop.Text = "Props";
			prop.Left = 200 + nav.Width;
			nav.Text = "Go";
			nav.Left = 200;
			
			nav.Click += delegate {
				m_browser.Navigate(b.Text);				
			};
			
			prop.Click += delegate {
				m_browser.ShowPageProperties();
			};
			
			m_browser.Top = 50;
			m_browser.Width = 300;
			m_browser.Height = 300;
			this.Controls.Add(m_browser);
			this.Controls.Add(b);
			this.Controls.Add(nav);
			this.Controls.Add(prop);
			
			
		}
		
		protected override void OnLoad(EventArgs e)
		{		
#if false
			m_browser.Show();
			m_browser.Focus();			
			
			m_browser.Visible = true;
			//m_browser.Navigate("about:cache");
			Console.WriteLine(m_browser.DocumentTitle);			
			m_browser.Navigate("http://www.google.ca");			
			Console.WriteLine(m_browser.DocumentTitle);
			//Console.WriteLine("History[0] = {0}", m_browser.History[0]);
			
			///var child = m_browser.Document.CreateElement("hello");
			//m_browser.Document.InsertBefore(child, m_browser.Document.LastChild);
			
			Console.WriteLine(m_browser.Window);
#else			
#if false
			m_browser.Navigate("http://www.google.ca");
			Console.WriteLine("m_browser = {0}", m_browser);
			Console.WriteLine("m_browser.Document = {0}", m_browser.Document);
			Console.WriteLine(m_browser.Document.Url);
			Console.WriteLine("m_browser.Document.OwnerDocument = {0}", m_browser.Document.OwnerDocument);			
			
			var node = GeckoNode.Create((nsIDOMHTMLElement)m_browser.Document.OwnerDocument.CreateElement("test"));
			
			m_browser.Document.AppendChild(node);		
#endif
#endif
			base.OnLoad(e);			
		}		
	}
}

