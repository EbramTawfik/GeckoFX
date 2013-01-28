using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using Gecko.Interop;

namespace Gecko
{
	public partial class GeckoWebBrowser
		: HwndHost,
		IGeckoWebBrowser,
		// window chrome
		nsIWebBrowserChrome,
		nsIEmbeddingSiteWindow,
		nsIInterfaceRequestor,
		// web progress listener
		nsIWebProgressListener2,
		// weak reference creation
		nsISupportsWeakReference
	{

		protected override HandleRef BuildWindowCore( HandleRef hwndParent )
		{
			Loaded += new System.Windows.RoutedEventHandler(GeckoWebBrowser_Loaded);
			HwndSourceParameters param = new HwndSourceParameters( "web browser container" );
			param.Width = 100;
			param.Height = 100;
			param.ParentWindow = hwndParent.Handle;
			param.WindowStyle = 0x10000000 | 0x40000000;
			_source = new HwndSource( param );
			return new HandleRef( this, _source.Handle );
		}

		void GeckoWebBrowser_Loaded(object sender, System.Windows.RoutedEventArgs e)
		{
			Xpcom.Initialize();
			_webBrowser = new InstanceWrapper<nsIWebBrowser>(Contracts.WebBrowser);

			_webBrowserFocus = (nsIWebBrowserFocus)_webBrowser.Instance;
			_baseWindow = (nsIBaseWindow)_webBrowser.Instance;
			_webNav = (nsIWebNavigation)_webBrowser.Instance;
			_webBrowser.Instance.SetContainerWindowAttribute(this);
			_baseWindow.InitWindow(Handle, IntPtr.Zero, 0, 0, (int)ActualWidth, (int)ActualHeight);
			RecordNewJsContext();
			_baseWindow.Create();

			Guid nsIWebProgressListenerGUID = typeof(nsIWebProgressListener).GUID;
			Guid nsIWebProgressListener2GUID = typeof(nsIWebProgressListener2).GUID;
			//_webBrowser.Instance.AddWebBrowserListener(this.GetWeakReference(), ref nsIWebProgressListenerGUID);
			//_webBrowser.Instance.AddWebBrowserListener( this.GetWeakReference(), ref nsIWebProgressListener2GUID );
			_baseWindow.SetVisibilityAttribute(true);
		}

		protected override void DestroyWindowCore(HandleRef hwnd)
		{
			//_webNav.Stop(  );
			_webBrowser.FinalRelease();
			_webBrowser.Dispose();
			_webBrowser = null;
			_source.Dispose();
		}

		#region nsIWebBrowserChrome

		public void SetStatus( uint statusType, string status )
		{
			Status = status;
		}

		public nsIWebBrowser GetWebBrowserAttribute()
		{
			return _webBrowser.Instance;
		}

		public void SetWebBrowserAttribute( nsIWebBrowser aWebBrowser )
		{
			
		}

		private uint _chromeFlags;

		public uint GetChromeFlagsAttribute()
		{
			return _chromeFlags;
		}

		public void SetChromeFlagsAttribute( uint aChromeFlags )
		{
			_chromeFlags = aChromeFlags;
		}

		public void DestroyBrowserWindow()
		{
			
		}

		public void SizeBrowserTo( int aCX, int aCY )
		{
			
		}

		public void ShowAsModal()
		{
			
		}

		public bool IsWindowModal()
		{
			return false;
		}

		public void ExitModalEventLoop( int aStatus )
		{
			
		}
		#endregion


		protected void RecordNewJsContext()
		{
			Xpcom.AssertCorrectThread();

			// Add a hook to record when the a new Context is created.
			// If an existing hook exists, replace hook with one that
			// 1. call original hook
			// 2. reinstates original hook when done.

			_runtimeService = Xpcom.GetService<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1");
			_jsRuntime = _runtimeService.GetRuntimeAttribute();

			_managedCallback = (IntPtr cx, UInt32 unitN) => { JSContext = cx; SpiderMonkey.JS_SetContextCallback(_jsRuntime, null); return 1; };

			_originalContextCallBack = SpiderMonkey.JS_SetContextCallback(_jsRuntime, _managedCallback);
			if (_originalContextCallBack != null)
			{
				RemoveJsContextCallBack();
				_managedCallback = (IntPtr cx, UInt32 unitN) => { JSContext = cx; SpiderMonkey.JS_SetContextCallback(_jsRuntime, _originalContextCallBack); return _originalContextCallBack(cx, unitN); };
				SpiderMonkey.JS_SetContextCallback(_jsRuntime, _managedCallback);
			}
			
		}

		protected void RemoveJsContextCallBack()
		{
			if (_jsRuntime == IntPtr.Zero)
				return;

			Xpcom.AssertCorrectThread();
			SpiderMonkey.JS_SetContextCallback(_jsRuntime, _originalContextCallBack);
		}




		#region nsIWebProgressListener
		void nsIWebProgressListener.OnStateChange( nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener2.OnProgressChange(
			nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress,
			int aMaxTotalProgress )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener2.OnLocationChange( nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener2.OnStatusChange( nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener2.OnSecurityChange( nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState )
		{
			throw new NotImplementedException();
		}

		public void OnProgressChange64(
			nsIWebProgress aWebProgress, nsIRequest aRequest, long aCurSelfProgress, long aMaxSelfProgress, long aCurTotalProgress,
			long aMaxTotalProgress )
		{
			throw new NotImplementedException();
		}

		public bool OnRefreshAttempted( nsIWebProgress aWebProgress, nsIURI aRefreshURI, int aMillis, bool aSameURI )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener2.OnStateChange( nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener.OnProgressChange(
			nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress,
			int aMaxTotalProgress )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener.OnLocationChange( nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation, uint aFlags )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener.OnStatusChange( nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage )
		{
			throw new NotImplementedException();
		}

		void nsIWebProgressListener.OnSecurityChange( nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState )
		{
			throw new NotImplementedException();
		}
		#endregion

		#region nsISupportsWeakReference
		public nsIWeakReference GetWeakReference()
		{
			return new nsWeakReference(this);
		}
		#endregion

		#region IGeckoWebBrowser

		public GeckoDocument Document
		{
			get { throw new NotImplementedException(); }
		}

		public GeckoWindow Window
		{
			get { throw new NotImplementedException(); }
		}

		public bool IsDisposed
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Navigates to the specified URL.
		/// In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.</param>
		public void Navigate(string url)
		{
			Navigate(url, 0, null, null, null);
		}

		/// <summary>
		/// Navigates to the specified URL using the given load flags.
		/// In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.  If the url is empty or null, the browser does not navigate and the method returns false.</param>
		/// <param name="loadFlags">Flags which specify how the page is loaded.</param>
		public bool Navigate(string url, GeckoLoadFlags loadFlags)
		{
			return Navigate(url, loadFlags, null, null, null);
		}

		/// <summary>
		///  Navigates to the specified URL using the given load flags, referrer and post data
		///  In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.  If the url is empty or null, the browser does not navigate and the method returns false.</param>
		/// <param name="loadFlags">Flags which specify how the page is loaded.</param>
		/// <param name="referrer">The referring URL, or null.</param>
		/// <param name="postData">post data and headers, or null</param>
		/// <returns>true if Navigate started. false otherwise.</returns>
		public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, GeckoMIMEInputStream postData)
		{
			return Navigate(url, loadFlags, referrer, postData, null);
		}

		/// <summary>
		///  Navigates to the specified URL using the given load flags, referrer and post data
		///  In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.  If the url is empty or null, the browser does not navigate and the method returns false.</param>
		/// <param name="loadFlags">Flags which specify how the page is loaded.</param>
		/// <param name="referrer">The referring URL, or null.</param>
		/// <param name="postData">post data and headers, or null</param>
		/// <param name="headers">headers, or null</param>
		/// <returns>true if Navigate started. false otherwise.</returns>
		public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, GeckoMIMEInputStream postData, GeckoMIMEInputStream headers)
		{
			if (string.IsNullOrEmpty(url))
				return false;

			// added these from http://code.google.com/p/geckofx/issues/detail?id=5 so that it will work even if browser isn't currently shown
			//if (!IsHandleCreated) CreateHandle();
			//if (IsBusy) this.Stop();


		//	if (!IsHandleCreated)
		//		throw new InvalidOperationException("Cannot call Navigate() before the window handle is created.");

			// WebNav.LoadURI throws an exception if we try to open a file that doesn't exist...
			Uri created;
			if (Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out created) && created.IsAbsoluteUri && created.IsFile)
			{
				if (!File.Exists(created.LocalPath) && !Directory.Exists(created.LocalPath))
					return false;
			}

			nsIURI referrerUri = null;
			if (!string.IsNullOrEmpty(referrer))
			{
				//referrerUri = Xpcom.GetService<nsIIOService>("@mozilla.org/network/io-service;1").NewURI(new nsAUTF8String(referrer), null, null);
				referrerUri = IOService.CreateNsIUri(referrer);
			}


			_webNav.LoadURI(url, (uint)loadFlags, referrerUri, postData != null ? postData.InputStream : null, headers != null ? headers.InputStream : null);

			return true;
		}

		public bool GoBack()
		{
			throw new NotImplementedException();
		}

		public bool GoForward()
		{
			throw new NotImplementedException();
		}

		public bool Reload()
		{
			throw new NotImplementedException();
		}

		public event EventHandler DocumentCompleted;		

		/// <summary>
		/// UI platform independent call function from UI thread
		/// </summary>
		/// <param name="action"></param>
		public void UserInterfaceThreadInvoke(Action action)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// UI platform independent call function from UI thread
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="func"></param>
		/// <returns></returns>
		public T UserInterfaceThreadInvoke<T>(Func<T> func)
		{
			throw new NotImplementedException();
		}

		#endregion

		protected override void OnGotMouseCapture(System.Windows.Input.MouseEventArgs e)
		{
			base.OnGotMouseCapture(e);
		}


		protected override void OnRenderSizeChanged(System.Windows.SizeChangedInfo sizeInfo)
		{
			if ( _baseWindow != null )
			{
				_baseWindow.SetPositionAndSize(0, 0, (int)sizeInfo.NewSize.Width, (int)sizeInfo.NewSize.Height, true);
			}
			
			base.OnRenderSizeChanged(sizeInfo);
		}

		#region nsIEmbeddingSiteWindow Members

		void nsIEmbeddingSiteWindow.SetDimensions(uint flags, int x, int y, int cx, int cy)
		{
			//const int DIM_FLAGS_POSITION = 1;
			//const int DIM_FLAGS_SIZE_INNER = 2;
			//const int DIM_FLAGS_SIZE_OUTER = 4;

			//BoundsSpecified specified = 0;
			//if ((flags & DIM_FLAGS_POSITION) != 0)
			//{
			//    specified |= BoundsSpecified.Location;
			//}
			//if ((flags & DIM_FLAGS_SIZE_INNER) != 0 || (flags & DIM_FLAGS_SIZE_OUTER) != 0)
			//{
			//    specified |= BoundsSpecified.Size;
			//}

			//OnWindowSetBounds(new GeckoWindowSetBoundsEventArgs(new Rectangle(x, y, cx, cy), specified));
		}

		unsafe void nsIEmbeddingSiteWindow.GetDimensions( uint flags, int* x, int* y, int* cx, int* cy )
		{
			double localX = ( x != ( void* ) 0 ) ? *x : 0;
			double localY = ( y != ( void* ) 0 ) ? *y : 0;
			double localCX = 0;
			double localCY = 0;

			if ( ( flags & nsIEmbeddingSiteWindowConstants.DIM_FLAGS_POSITION ) != 0 )
			{
				Point pt = PointToScreen( new Point() );
				localX = pt.X;
				localY = pt.Y;
			}
			localCX = ActualWidth;
			localCY = ActualHeight;

			int iLocalCX = 0, iLocalCY = 0;
			_baseWindow.GetSize( ref iLocalCX, ref iLocalCY );
			localCX = iLocalCX;
			localCY = iLocalCY;

			if ( x != ( void* ) 0 ) *x = ( int ) localX;
			if ( y != ( void* ) 0 ) *y = ( int ) localY;
			if ( cx != ( void* ) 0 ) *cx = ( int ) localCX;
			if ( cy != ( void* ) 0 ) *cy = ( int ) localCY;
		}

		void nsIEmbeddingSiteWindow.SetFocus()
		{
			Focus();
			if (_baseWindow != null)
			{
				_baseWindow.SetFocus();
			}
		}

		bool nsIEmbeddingSiteWindow.GetVisibilityAttribute()
		{
			return Visibility==Visibility.Visible;
		}

		void nsIEmbeddingSiteWindow.SetVisibilityAttribute(bool aVisibility)
		{
			Visibility = aVisibility ? Visibility.Visible : Visibility.Hidden;
		}

		string nsIEmbeddingSiteWindow.GetTitleAttribute()
		{
			return DocumentTitle;
		}

		void nsIEmbeddingSiteWindow.SetTitleAttribute(string aTitle)
		{
			DocumentTitle = aTitle;
		}

		IntPtr nsIEmbeddingSiteWindow.GetSiteWindowAttribute()
		{
			return Handle;
		}

		void nsIEmbeddingSiteWindow.Blur()
		{
			// TODO: implement.
		}
		#endregion

		IntPtr nsIInterfaceRequestor.GetInterface(ref Guid uuid)
		{
			object obj = this;

			// note: when a new window is created, gecko calls GetInterface on the webbrowser to get a DOMWindow in order
			// to set the starting url
			if (_webBrowser != null)
			{
				if (uuid == typeof(nsIDOMWindow).GUID)
				{
					obj = _webBrowser.Instance.GetContentDOMWindowAttribute();
				}
				else if (uuid == typeof(nsIDOMDocument).GUID)
				{
					obj = _webBrowser.Instance.GetContentDOMWindowAttribute().GetDocumentAttribute();
				}
			}

			IntPtr ppv, pUnk = Marshal.GetIUnknownForObject(obj);

			Marshal.QueryInterface(pUnk, ref uuid, out ppv);

			Marshal.Release(pUnk);

			return ppv;
		}
	}
}
