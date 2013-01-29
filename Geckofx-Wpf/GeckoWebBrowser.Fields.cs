using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Interop;

namespace Gecko
{
	partial class GeckoWebBrowser
	{
		#region nsIWebBrowser interface fields
		/// <summary>
		/// nsIWebBrowser instance
		/// </summary>
		private InstanceWrapper<nsIWebBrowser> _webBrowser;

		/// <summary>
		/// nsIWebBrowser casted to nsIBaseWindow
		/// </summary>
		private nsIBaseWindow _baseWindow;

		/// <summary>
		/// nsIWebBrowser casted no nsIWebNavigation
		/// </summary>
		private nsIWebNavigation _webNav;

		private nsIWebBrowserFocus _webBrowserFocus;
		#endregion

		#region JSContext
		private IntPtr _jsRuntime;
		private nsIJSRuntimeService _runtimeService;
		private SpiderMonkey.CallBack _managedCallback;
		private SpiderMonkey.CallBack _originalContextCallBack;
		#endregion

		#region WPF fields
		private HwndSource _source;
		#endregion

		private uint _chromeFlags;


		public IntPtr JSContext { get; protected set; }
	}
}
