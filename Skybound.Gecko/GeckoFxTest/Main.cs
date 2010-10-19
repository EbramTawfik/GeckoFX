using System;
using System.Windows.Forms;
using Skybound.Gecko;

// You will need to run this with a new version of mono (2.8 or newer)
// mono 2.6.3 can not handle this.
namespace GeckoFxTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// TODO FIXME: make better way of finding libxul.so etc.
			Xpcom.Initialize("/usr/lib/xulrunner-1.9.2.10/");
			
			Application.Run(new MyForm());			
		}
	}
	
	class MyForm : Form
	{
		GeckoWebBrowser m_browser;
		
		public MyForm()
		{
			m_browser = new GeckoWebBrowser();			
			m_browser.Dock = DockStyle.Fill;
			m_browser.Width = 100;
			m_browser.Height = 100;
			this.Controls.Add(m_browser);
		}
		
		protected override void OnLoad(EventArgs e)
		{			
			m_browser.Show();
			
			m_browser.Navigate("about:cache");			
			m_browser.Visible = true;
			Console.WriteLine(m_browser.Window);
			base.OnLoad(e);
		}		
	}
}

