using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko;
using System.Windows.Forms;

namespace Gecko
{
	public static class GlobalJSContextHolderInitalizer
	{
		static GeckoWebBrowser _browser;
		static IntPtr _jsContext;

		public static void Initalize()
		{
			if (GlobalJSContextHolder.Initalize == null)
				GlobalJSContextHolder.Initalize = CreateJsContext;

			Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
		}

		static void Application_ApplicationExit(object sender, EventArgs e)
		{
			if (_browser != null)
			{
				_browser.Dispose();
				_browser = null;
			}
		}
		

		static IntPtr CreateJsContext()
		{
			if (_jsContext != IntPtr.Zero)
				return _jsContext;

			_browser = new GeckoWebBrowser();
			_browser.LoadHtml("<html><body></body></html>");

			_browser.NavigateFinishedNotifier.BlockUntilNavigationFinished();

			_jsContext = _browser.JSContext;
			return _jsContext;
		}
	}
}
