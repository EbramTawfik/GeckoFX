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
			// TODO: make better way of finding libxul.so etc.
			Xpcom.Initialize("/usr/lib/xulrunner/");
			
			Application.Run(new MyForm());			
		}
	}
	
	class MyForm : Form
	{
		public MyForm()
		{
			var browser = new GeckoWebBrowser();			
			browser.Dock = DockStyle.Fill;
			this.Controls.Add(browser);
		}
	}
}

