#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Text;
using Gecko.Net;

namespace Gecko
{
	/// <summary>
	/// A Gecko-based web browser.
	/// </summary>
	public partial class GeckoWebBrowser : 
		nsIWebBrowserChrome,
		nsIContextMenuListener2,
		nsIWebProgressListener,
		nsIInterfaceRequestor,
		nsIEmbeddingSiteWindow2,
		nsISupportsWeakReference,
		nsIWeakReference,
		nsIDOMEventListener,
		nsISHistoryListener,
		nsITooltipListener,
        nsIObserver,
         nsIHttpActivityObserver
		//nsIWindowProvider,
	{
		#region Fields
		/// <summary>
		/// Additional DOM message listeners
		/// </summary>
		Dictionary<string, Action<string>> _messageEventListeners = new Dictionary<string, Action<string>>();
		/// <summary>
		/// nsIWebBrowser instance
		/// </summary>
		nsIWebBrowser WebBrowser;
		/// <summary>
		/// nsIWebBrowser casted to nsIBaseWindow
		/// </summary>
		nsIBaseWindow BaseWindow;
		/// <summary>
		/// nsIWebBrowser casted no nsIWebNavigation
		/// </summary>
		nsIWebNavigation WebNav;

		uint ChromeFlags;
		bool m_javascriptDebuggingEnabled;
		#endregion
		/// <summary>
		/// Initializes a new instance of <see cref="GeckoWebBrowser"/>.
		/// </summary>
		public GeckoWebBrowser()
		{
#if GTK
			if (Xpcom.IsMono)
				m_wrapper = new GtkDotNet.GtkReparentingWrapperNoThread(new Gtk.Window(Gtk.WindowType.Popup), this);
#endif

#if true//false
			NavigateFinishedNotifier = new NavigateFinishedNotifier(this);
#endif
		}

		#region protected override void Dispose(bool disposing)
		protected override void Dispose(bool disposing)
		{
			RemoveJsContextCallBack();

			//var count = Gecko.Interop.ComDebug.GetRefCount(WebBrowser);
			if (NavigateFinishedNotifier != null)
				NavigateFinishedNotifier.Dispose();

			if (!Environment.HasShutdownStarted && !AppDomain.CurrentDomain.IsFinalizingForUnload())
			{
				// make sure the object is still alove before we call a method on it
				var webNav = Xpcom.QueryInterface<nsIWebNavigation>( WebNav );
				if (webNav != null)
				{
					webNav.Stop(nsIWebNavigationConstants.STOP_ALL);
					Marshal.ReleaseComObject( webNav );
				}
				WebNav = null;

				var baseWindow = Xpcom.QueryInterface<nsIBaseWindow>( BaseWindow );
				if (baseWindow != null)
				{
					baseWindow.Destroy();
					Marshal.ReleaseComObject(baseWindow);
				}
				BaseWindow = null;
			}

#if GTK			
			if (m_wrapper != null)
				m_wrapper.Dispose();
#endif
			//count = Gecko.Interop.ComDebug.GetRefCount(WebBrowser);
			base.Dispose(disposing);
		}
		#endregion

		#region JSContext
		/// <summary>
		/// Add hooks to listen for new JSContext creation and store the context for later use.
		/// This is the only way I have found of getting hold of the real JSContext
		/// </summary>
		protected void RecordNewJsContext()
		{
			// Add a hook to record when the a new Context is created.
			// If an existing hook exists, replace hook with one that
			// 1. call original hook
			// 2. reinstates original hook when done.

			_runtimeService = Xpcom.GetService<nsIJSRuntimeService>("@mozilla.org/js/xpc/RuntimeService;1");
			_jsRuntime = _runtimeService.GetRuntimeAttribute();

			_managedCallback = (IntPtr cx, UInt32 unitN) => { JSContext = cx; AutoJSContext.JS_SetContextCallback(_jsRuntime, null); return 1; };

			_originalContextCallBack = AutoJSContext.JS_SetContextCallback(_jsRuntime, _managedCallback);
			if (_originalContextCallBack != null)
			{
				RemoveJsContextCallBack();
				_managedCallback = (IntPtr cx, UInt32 unitN) => { JSContext = cx; AutoJSContext.JS_SetContextCallback(_jsRuntime, _originalContextCallBack); return _originalContextCallBack(cx, unitN); };
				AutoJSContext.JS_SetContextCallback(_jsRuntime, _managedCallback);
			}
		}

		protected void RemoveJsContextCallBack()
		{
			if (_jsRuntime == IntPtr.Zero)
				return;

			AutoJSContext.JS_SetContextCallback(_jsRuntime, _originalContextCallBack);
		}


		private IntPtr _jsRuntime;
		private nsIJSRuntimeService _runtimeService;
		private AutoJSContext.CallBack _managedCallback;
		private AutoJSContext.CallBack _originalContextCallBack;

		public IntPtr JSContext { get; protected set; }
		#endregion

		public nsIWebBrowserFocus WebBrowserFocus
		{
			get; protected set;
		}

		/// <summary>
		/// returns null if window is not editable.
		/// </summary>
		public nsIEditor Editor
		{
			get
			{
				var editingSession = Xpcom.CreateInstance<nsIEditingSession>("@mozilla.org/editor/editingsession;1");
				var returnValue = editingSession.GetEditorForWindow((nsIDOMWindow)Window.DomWindow);
				Marshal.ReleaseComObject(editingSession);
				return returnValue;
			}
		}
		
		// defaults to false
		public bool UseHttpActivityObserver
		{
			get;
			set;
		}
	
		
		class WindowCreator : nsIWindowCreator2
		{
			static WindowCreator()
			{
				// give an nsIWindowCreator to the WindowWatcher service
				nsIWindowWatcher watcher = Xpcom.GetService<nsIWindowWatcher>("@mozilla.org/embedcomp/window-watcher;1");
				if (watcher != null)
				{
					//disabled for now because it's not loading the proper URL automatically
					watcher.SetWindowCreator(new WindowCreator());
				}
			}
			
			public static void Register()
			{
				// calling this method simply invokes the static ctor
			}
			
			public nsIWebBrowserChrome CreateChromeWindow(nsIWebBrowserChrome parent, uint chromeFlags)
			{
				// for chrome windows, we can use the AppShellService to create the window using some built-in xulrunner code
				GeckoWindowFlags flags = (GeckoWindowFlags)chromeFlags;
				if ((flags & GeckoWindowFlags.OpenAsChrome) != 0)
				{
				      // obtain the services we need
				     // nsIAppShellService appShellService = Xpcom.GetService<nsIAppShellService>("@mozilla.org/appshell/appShellService;1");
				      
				      // create the child window
				      nsIXULWindow xulChild = AppShellService.CreateTopLevelWindow(null, null, chromeFlags, -1, -1);
				      
				      // this little gem allows the GeckoWebBrowser to be properly activated when it gains the focus again
				      if (parent is GeckoWebBrowser && (flags & GeckoWindowFlags.OpenAsDialog) != 0)
				      {
						EventHandler gotFocus = null;
						gotFocus = delegate (object sender, EventArgs e)
						{
							(sender as GeckoWebBrowser).GotFocus -= gotFocus;
							(sender as GeckoWebBrowser).WebBrowserFocus.Activate();
						};
						(parent as GeckoWebBrowser).GotFocus += gotFocus;
				      }
				      
				      // return the chrome
				      return Xpcom.QueryInterface<nsIWebBrowserChrome>(xulChild);
				}
				
				GeckoWebBrowser browser = parent as GeckoWebBrowser;
				if (browser != null)
				{
					GeckoCreateWindowEventArgs e = new GeckoCreateWindowEventArgs((GeckoWindowFlags)chromeFlags);
					browser.OnCreateWindow(e);
					
					if (e.WebBrowser != null)
					{
						// set flags
						((nsIWebBrowserChrome)e.WebBrowser).SetChromeFlagsAttribute(chromeFlags);
						return e.WebBrowser;
					}
									
					//nsIAppShellService appShellService = Xpcom.GetService<nsIAppShellService>(Contracts.AppShellService);
					nsIXULWindow xulChild = AppShellService.CreateTopLevelWindow(null, null, chromeFlags, -1, -1);
					return Xpcom.QueryInterface<nsIWebBrowserChrome>(xulChild);									
				}
				return null;
			}


            public nsIWebBrowserChrome CreateChromeWindow2(nsIWebBrowserChrome parent, uint chromeFlags, uint contextFlags, nsIURI uri, ref bool cancel)
            {
                GeckoWebBrowser browser = parent as GeckoWebBrowser;
                if (browser != null)
                {
                    var url = "";
                    if (uri != null)
                    {
                        url = (nsString.Get(uri.GetSpecAttribute)).ToString();
                    }
                    else
                    {
                        url = "about:blank";
                    }

                    GeckoCreateWindow2EventArgs e = new GeckoCreateWindow2EventArgs((GeckoWindowFlags)chromeFlags, url);
                    e.WebBrowser = browser;

                    browser.OnCreateWindow2(e);

                    if (e.Cancel)
                    {
                        cancel = true;
                        return null;
                    }
                }

                return CreateChromeWindow(parent, chromeFlags);
            }
		}

		#region Navigation
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
		
		[Obsolete]
		/// <summary>
		/// Navigates to the specified URL using the given load flags, referrer, post data and headers.
		/// In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.  If the url is empty or null, the browser does not navigate and the method returns false.</param>
		/// <param name="loadFlags">Flags which specify how the page is loaded.</param>
		/// <param name="referrer">The referring URL, or null.</param>
		/// <param name="postData">The post data to send, or null.  If you use post data, you must explicity specify a Content-Type and Content-Length
		/// header in <paramref name="additionalHeaders"/>.</param>
		/// <param name="additionalHeaders">Any additional HTTP headers to send, or null.  Separate multiple headers with CRLF.  For example,
		/// "Content-Type: application/x-www-form-urlencoded\r\nContent-Length: 50"</param>
		public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, byte [] postData, string additionalHeaders)
		{
			if (string.IsNullOrEmpty(url))
				return false;

			if (!IsHandleCreated)
				throw new InvalidOperationException("Cannot call Navigate() before the window handle is created.");
	
			if (IsBusy)
				this.Stop();
				
			// WebNav.LoadURI throws an exception if we try to open a file that doesn't exist...
			Uri created;
			if (Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out created) && created.IsAbsoluteUri && created.IsFile)
			{
				if (!File.Exists(created.LocalPath) && !Directory.Exists(created.LocalPath))
					return false;
			}
				
			nsIInputStream postDataStream = null, headersStream = null;
				
			if (postData != null)
			{
				// post data must start with CRLF.  actually, you can put additional headers before this, but there's no
				// point because this method has an "additionalHeaders" argument.  so we might as well insert it automatically
				Array.Resize(ref postData, postData.Length + 2);
				Array.Copy(postData, 0, postData, 2, postData.Length - 2);
				postData[0] = (byte)'\r';
				postData[1] = (byte)'\n';
				postDataStream = ByteArrayInputStream.Create(postData);
			}
				
			if (!string.IsNullOrEmpty(additionalHeaders))
			{
				// each header must end with a CRLF (including the last one)
				// here we simply ensure that the last header has a CRLF.  if the header has other syntax problems,
				// they're the caller's responsibility
				if (!additionalHeaders.EndsWith("\r\n"))
					additionalHeaders += "\r\n";
					
				headersStream = ByteArrayInputStream.Create(Encoding.UTF8.GetBytes(additionalHeaders));
			}
				
			nsIURI referrerUri = null;
			if (!string.IsNullOrEmpty(referrer))
			{
				//referrerUri = Xpcom.GetService<nsIIOService>("@mozilla.org/network/io-service;1").NewURI(new nsAUTF8String(referrer), null, null);
				referrerUri = IOService.CreateNsIUri(referrer);
			}

			WebNav.LoadURI(url, (uint)loadFlags, referrerUri, postDataStream, headersStream);
			return true;
		}
		
		/// <summary>
		///  Navigates to the specified URL using the given load flags, referrer and post data
		///  In order to find out when Navigate has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="url">The url to navigate to.  If the url is empty or null, the browser does not navigate and the method returns false.</param>
		/// <param name="loadFlags">Flags which specify how the page is loaded.</param>
		/// <param name="referrer">The referring URL, or null.</param>
		/// <param name="postData">post data and headers, or null</param>
		/// <returns></returns>
		public bool Navigate(string url, GeckoLoadFlags loadFlags, string referrer, GeckoMIMEInputStream postData)
		{
			if (string.IsNullOrEmpty(url))
				return false;

			if (!IsHandleCreated)
				throw new InvalidOperationException("Cannot call Navigate() before the window handle is created.");

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
				referrerUri = IOService.CreateNsIUri( referrer );
			}

            WebNav.LoadURI(url, (uint)loadFlags, referrerUri, postData!=null?postData.InputStream:null, null);

			return true;
		}
		#endregion

		/// <summary>
		/// Loads supplied html string.
		/// Note: LoadHtml isn't intended to load complex Html Documents.		
		/// In order to find out when LoadHtml has finished attach a handler to NavigateFinishedNotifier.NavigateFinished.
		/// </summary>
		/// <param name="htmlDocument"></param>
		public void LoadHtml(string htmlDocument)
		{
			var bytes = System.Text.Encoding.UTF8.GetBytes(htmlDocument);						
			Navigate(string.Format("data:text/html;base64,{0}", Convert.ToBase64String(bytes)));
		}

		/// <summary>
		/// Return a Bitmap Image of the current WebBrowsers Rendered page.
		/// Not supported on Linux - use OffScreenGeckoWebBrowser.
		/// </summary>
		/// <param name="width">Width of the bimap</param>
		/// <param name="height">Height of the bitmap</param>
		/// <returns></returns>
		public Bitmap GetBitmap(uint width, uint height)
		{
			return GetBitmap(0, 0, width, height);
		}

		/// <summary>
		/// Return a Bitmap Image of the current WebBrowsers Rendered page.
		/// </summary>
		/// <param name="xOffset"></param>
		/// <param name="yOffset"></param>
		/// <param name="width">Width of the bitmap</param>
		/// <param name="height">Height of the bitmap</param>
		/// <returns></returns>
		public Bitmap GetBitmap(uint xOffset, uint yOffset, uint width, uint height)
		{			
			return new ImageCreator(this).CanvasGetBitmap(xOffset, yOffset, width, height);
		}



		public NavigateFinishedNotifier NavigateFinishedNotifier;
		
		/// <summary>
		/// Gets or sets whether all default items are removed from the standard context menu.
		/// </summary>
		[DefaultValue(false),Description("Removes default items from the standard context menu.  The ShowContextMenu event is still raised to add custom items.")]
		public bool NoDefaultContextMenu
		{
			get { return _NoDefaultContextMenu; }
			set { _NoDefaultContextMenu = value; }
		}
		bool _NoDefaultContextMenu;
		
		/// <summary>
		/// Gets or sets the text displayed in the status bar.
		/// </summary>
		[Browsable(false), DefaultValue("")]
		public string StatusText
		{
			get { return _StatusText ?? ""; }
			set
			{
				if (StatusText != value)
				{
					_StatusText = value;
					OnStatusTextChanged(EventArgs.Empty);
				}
			}
		}
		string _StatusText;


		
		/// <summary>
		/// Gets the title of the document loaded into the web browser.
		/// </summary>
		[Browsable(false), DefaultValue("")]
		public string DocumentTitle
		{
			get { return _DocumentTitle ?? ""; }
			private set
			{
				if (DocumentTitle == value) return;
				_DocumentTitle = value;
				OnDocumentTitleChanged(EventArgs.Empty);
			}
		}
		string _DocumentTitle;
		

		
		/// <summary>
		/// Gets whether the browser may navigate back in the history.
		/// </summary>
		[BrowsableAttribute(false)]
		public bool CanGoBack
		{
			get { return _CanGoBack; }
		}
		bool _CanGoBack;
		
		/// <summary>
		/// Gets whether the browser may navigate forward in the history.
		/// </summary>
		[BrowsableAttribute(false)]
		public bool CanGoForward
		{
			get { return _CanGoForward; }
		}
		bool _CanGoForward;

		
		
		/// <summary>Raises the CanGoBackChanged or CanGoForwardChanged events when necessary.</summary>
		void UpdateCommandStatus()
		{
			bool canGoBack = false;
			bool canGoForward = false;
			if (WebNav != null)
			{
				canGoBack = WebNav.GetCanGoBackAttribute();
				canGoForward = WebNav.GetCanGoForwardAttribute();
			}
			
			if (_CanGoBack != canGoBack)
			{
				_CanGoBack = canGoBack;
				OnCanGoBackChanged(EventArgs.Empty);
			}
			
			if (_CanGoForward != canGoForward)
			{
				_CanGoForward = canGoForward;
				OnCanGoForwardChanged(EventArgs.Empty);
			}
		}
		
		/// <summary>
		/// Navigates to the previous page in the history, if one is available.
		/// </summary>
		/// <returns></returns>
		public bool GoBack()
		{
			if (CanGoBack)
			{
				WebNav.GoBack();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Navigates to the next page in the history, if one is available.
		/// </summary>
		/// <returns></returns>
		public bool GoForward()
		{
			if (CanGoForward)
			{
				WebNav.GoForward();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Cancels any pending navigation and also stops any sound or animation.
		/// </summary>
		public void Stop()
		{
			if (WebNav != null)
				WebNav.Stop(nsIWebNavigationConstants.STOP_ALL);
		}
		
		/// <summary>
		/// Reloads the current page.
		/// </summary>
		/// <returns></returns>
		public bool Reload()
		{
		    return Reload(GeckoLoadFlags.None);
		}
		
		/// <summary>
		/// Reloads the current page using the specified flags.
		/// </summary>
		/// <param name="flags"></param>
		/// <returns></returns>
		public bool Reload(GeckoLoadFlags flags)
		{
			Uri url = this.Url;
			if (url != null && url.IsFile && !File.Exists(url.LocalPath))
			{
				// can't reload a file which no longer exists--a COM exception will be thrown
				return false;
			}
			
			if (WebNav != null)
				WebNav.Reload((uint)flags); 
			
			return true;
		}
		
		nsIClipboardCommands ClipboardCommands
		{
			get { return _ClipboardCommands ?? ( _ClipboardCommands = Xpcom.QueryInterface<nsIClipboardCommands>( WebBrowser ) ); }
		}

		nsIClipboardCommands _ClipboardCommands;
		
		delegate bool CanPerformMethod();
		
		bool CanPerform(CanPerformMethod method)
		{
			// in xulrunner (tested on version 5.0)
			// nsIController.IsCommandEnabled("cmd_copyImageContents") can return E_FAIL when clicking on certain objects.
			// this seems to me like a xulrunner bug.
			try
			{
				return method();
			}
			catch (COMException e)
			{
				if ((e.ErrorCode & 0xFFFFFFFF) != 0x80004005)
					throw e;

				return false;
			}
		}
		
		/// <summary>
		/// Gets whether the image contents of the selection may be copied to the clipboard as an image.
		/// </summary>
		[Browsable(false)]
		public bool CanCopyImageContents
		{
			get { return CanPerform(ClipboardCommands.CanCopyImageContents); }
		}
		
		/// <summary>
		/// Copies the image contents of the selection to the clipboard as an image.
		/// </summary>
		/// <returns></returns>
		public bool CopyImageContents()
		{
			if (CanCopyImageContents)
			{
				ClipboardCommands.CopyImageContents();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the <see cref="CopyImageLocation"/> command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanCopyImageLocation
		{
			get { return CanPerform(ClipboardCommands.CanCopyImageLocation); }
		}
		
		/// <summary>
		/// Copies the location of the currently selected image to the clipboard.
		/// </summary>
		/// <returns></returns>
		public bool CopyImageLocation()
		{
			if (CanCopyImageLocation)
			{
				try
				{
					ClipboardCommands.CopyImageLocation();
				}
				catch (COMException comException)
				{
					if ((comException.ErrorCode & 0xFFFFFFFF) != 0x80004005)
						throw comException;
				}

				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the <see cref="CopyLinkLocation"/> command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanCopyLinkLocation
		{
			get { return CanPerform(ClipboardCommands.CanCopyLinkLocation); }
		}
		
		/// <summary>
		/// Copies the location of the currently selected link to the clipboard.
		/// </summary>
		/// <returns></returns>
		public bool CopyLinkLocation()
		{
			if (CanCopyLinkLocation)
			{
				ClipboardCommands.CopyLinkLocation();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the <see cref="CopySelection"/> command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanCopySelection
		{
			get { return CanPerform(ClipboardCommands.CanCopySelection); }
		}
		
		/// <summary>
		/// Copies the selection to the clipboard.
		/// </summary>
		/// <returns></returns>
		public bool CopySelection()
		{
			if (CanCopySelection)
			{
				ClipboardCommands.CopySelection();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the <see cref="CutSelection"/> command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanCutSelection
		{
			get { return CanPerform(ClipboardCommands.CanCutSelection); }
		}
		
		/// <summary>
		/// Cuts the selection to the clipboard.
		/// </summary>
		/// <returns></returns>
		public bool CutSelection()
		{
			if (CanCutSelection)
			{
				ClipboardCommands.CutSelection();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the <see cref="Paste"/> command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanPaste
		{
			get { return CanPerform(ClipboardCommands.CanPaste); }
		}
		
		/// <summary>
		/// Pastes the contents of the clipboard at the current selection.
		/// </summary>
		/// <returns></returns>
		public bool Paste()
		{
			if (CanPaste)
			{
				ClipboardCommands.Paste();
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Selects the entire document.
		/// </summary>
		/// <returns></returns>
		public void SelectAll()
		{
			ClipboardCommands.SelectAll();
		}
		
		/// <summary>
		/// Empties the current selection.
		/// </summary>
		/// <returns></returns>
		public void SelectNone()
		{
			ClipboardCommands.SelectNone();
		}
		
		nsICommandManager CommandManager
		{
			get { return _CommandManager ?? (_CommandManager = Xpcom.QueryInterface<nsICommandManager>(WebBrowser)); }
		}
		nsICommandManager _CommandManager;
		
		/// <summary>
		/// Returns true if the undo command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanUndo
		{
			get { return CommandManager.IsCommandEnabled("cmd_undo", null); }
		}
		
		/// <summary>
		/// Undoes last executed command.
		/// </summary>
		/// <returns></returns>
		public bool Undo()
		{
			if (CanUndo)
			{
				CommandManager.DoCommand("cmd_undo", null, null);
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Returns true if the redo command is enabled.
		/// </summary>
		[Browsable(false)]
		public bool CanRedo
		{
			get { return CommandManager.IsCommandEnabled("cmd_redo", null); }
		}
		
		/// <summary>
		/// Redoes last undone command.
		/// </summary>
		/// <returns></returns>
		public bool Redo()
		{
			if (CanRedo)
			{
				CommandManager.DoCommand("cmd_redo", null, null);
				return true;
			}
			return false;
		}
		
		/// <summary>
		/// Executes the command with the specified name.
		/// </summary>
		/// <param name="name">The name of the command to execute.  See http://developer.mozilla.org/en/docs/Editor_Embedding_Guide for a list of available commands.</param>
		public void ExecuteCommand(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException("name");
			
			CommandManager.DoCommand(name, null, null);
		}
		
		/// <summary>
		/// Gets the <see cref="Url"/> currently displayed in the web browser.
		/// Use the <see cref="Navigate(string)"/> method to change the URL.
		/// </summary>
		[BrowsableAttribute(false)]
		public Uri Url
		{
			get
			{
				if (WebNav == null)
					return null;

				nsIURI locationComObject = WebNav.GetCurrentURIAttribute();

				var uri=nsURI.ToUri( locationComObject );
				return uri ?? new Uri( "about:blank" );
			}
		}
		
		/// <summary>
		/// Gets the <see cref="Url"/> of the current page's referrer.
		/// </summary>
		[BrowsableAttribute(false)]
		public Uri ReferrerUrl
		{
			get
			{
				if (WebNav == null)
					return null;
			
				nsIURI location =  WebNav.GetReferringURIAttribute();
				var uri = nsURI.ToUri(location);
				return uri ?? new Uri("about:blank");				
			}
		}
		
		/// <summary>
		/// Gets the <see cref="GeckoWindow"/> object for this browser.
		/// </summary>
		[Browsable(false)]
		public GeckoWindow Window
		{
			get
			{
				if (WebBrowser == null)
					return null;

				return _Window ?? ( _Window = GeckoWindow.Create( WebBrowser.GetContentDOMWindowAttribute() ) );
			}
		}
		GeckoWindow _Window;
		
		/// <summary>
		/// Gets the <see cref="GeckoDocument"/> for the page currently loaded in the browser.
		/// </summary>
		[Browsable(false)]
		public GeckoDomDocument DomDocument
		{
			get
			{
				if (WebBrowser == null)
					return null;

				if (_Document == null || _Document.DomObject != WebBrowser.GetContentDOMWindowAttribute().GetDocumentAttribute())
				{
					_Document =
						GeckoDomDocument.CreateDomDocumentWraper( WebBrowser.GetContentDOMWindowAttribute().GetDocumentAttribute() );
					//FromDOMDocumentTable.Add((nsIDOMDocument)_Document.DomObject, this);
				}
				return _Document;
			}
		}
		GeckoDomDocument _Document;

		public GeckoDocument Document
		{
			get { return DomDocument as GeckoDocument; }
		}
		
		private void UnloadDocument()
		{
			_Document = null;
		}
		
		public void SetInputFocus()
		{
#if GTK
			m_wrapper.SetInputFocus();		
#endif
		}
		
		public void RemoveInputFocus()
		{
#if GTK
			m_wrapper.RemoveInputFocus();		
#endif
		}

		/// <summary>
		/// Gets whether the browser is busy loading a page.
		/// </summary>
		[Browsable(false)]
		public bool IsBusy
		{
			get { return _IsBusy; }
			private set { _IsBusy = value; }
		}
		bool _IsBusy;
		


		/// <summary>
		/// Saves the current document to the specified file name.
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public void SaveDocument(string path)
		{
			SaveDocument(path, null);
		}


		/// <summary>
		/// Saves the current document to the specified file name.
		/// </summary>
		/// <param name="path">Patht to the file you want to save</param>
		/// <param name="outputMimeType">the mimmtype of the save file, or null</param>
		/// <returns></returns>
		public void SaveDocument(string path, string outputMimeType)//hatton added mimeType param
		{
			if (!Directory.Exists(Path.GetDirectoryName(path)))
				throw new System.IO.DirectoryNotFoundException();
			else if (this.Document == null)
				throw new InvalidOperationException("No document has been loaded into the web browser.");
			
			//If the file is locked, we'd like to throw a nice .net error, not just the E_FAIL we get from COM
			//Also, this seems to get us through with no error, more often.
			if(File.Exists(path))
			{
				File.Delete(path);
			}


			nsIWebBrowserPersist persist = Xpcom.QueryInterface<nsIWebBrowserPersist>(WebBrowser);
			if (persist != null)
			{
				persist.SaveDocument((nsIDOMDocument)Document.DomObject, (nsISupports)Xpcom.NewNativeLocalFile(path), null,
					outputMimeType, 0, 0);
			}
			else
			{
				throw new InvalidOperationException();
			}
		}
		
		/// <summary>
		/// Gets the session history for the current browser.
		/// </summary>
		[Browsable(false)]
		public GeckoSessionHistory History
		{
			get
			{
				if (WebNav == null)
					return null;
				
				return (_History == null) ? (_History = new GeckoSessionHistory(WebNav)) : _History;
			}
		}
		GeckoSessionHistory _History;

		public GeckoMarkupDocumentViewer GetMarkupDocumentViewer()
		{
			if (_MarkupDocumentViewer != null)
				return _MarkupDocumentViewer;

			if (WebNav == null)
				return null;

			nsIDocShell shell = Xpcom.QueryInterface<nsIDocShell>(WebNav);
			nsIContentViewer contentViewer;
			IntPtr contentViewerPtr = shell.GetContentViewerAttribute();
			contentViewer = (nsIContentViewer)Marshal.GetObjectForIUnknown(contentViewerPtr);

			_MarkupDocumentViewer = new GeckoMarkupDocumentViewer((nsIMarkupDocumentViewer)contentViewer);

			return _MarkupDocumentViewer;
		}

		GeckoMarkupDocumentViewer _MarkupDocumentViewer;
		
		#region nsIWebBrowserChrome Members

		void nsIWebBrowserChrome.SetStatus(uint statusType, string status)
		{
			this.StatusText = status;			
		}

		nsIWebBrowser nsIWebBrowserChrome.GetWebBrowserAttribute()
		{
			return this.WebBrowser;
		}

		void nsIWebBrowserChrome.SetWebBrowserAttribute(nsIWebBrowser webBrowser)
		{
			this.WebBrowser = webBrowser;
		}

		System.UInt32 nsIWebBrowserChrome.GetChromeFlagsAttribute()
		{
			return this.ChromeFlags;
		}

		void nsIWebBrowserChrome.SetChromeFlagsAttribute(uint flags)
		{
			this.ChromeFlags = (uint)flags;
		}
		
		void nsIWebBrowserChrome.DestroyBrowserWindow()
		{
			//throw new NotImplementedException();
			OnWindowClosed(EventArgs.Empty);			
		}

		void nsIWebBrowserChrome.SizeBrowserTo(int cx, int cy)
		{
			OnWindowSetBounds(new GeckoWindowSetBoundsEventArgs(new Rectangle(0, 0, cx, cy), BoundsSpecified.Size));
		}

		void nsIWebBrowserChrome.ShowAsModal()
		{
			//throw new NotImplementedException();
			Debug.WriteLine("ShowAsModal");
			
			_IsWindowModal = true;
		}
		bool _IsWindowModal;
		
		bool nsIWebBrowserChrome.IsWindowModal()
		{
			//throw new NotImplementedException();
			Debug.WriteLine("IsWindowModal");
			
			return _IsWindowModal;
		}

		void nsIWebBrowserChrome.ExitModalEventLoop(int status)
		{
			//throw new NotImplementedException();
			Debug.WriteLine("ExitModalEventLoop");
			
			_IsWindowModal = false;
		}

		#endregion

		#region nsIContextMenuListener2 Members

		void nsIContextMenuListener2.OnShowContextMenu(uint aContextFlags, nsIContextMenuInfo info)
		{
			// if we don't have a target node, we can't do anything by default.  this happens in XUL forms (i.e. about:config)
			if (info.GetTargetNodeAttribute() == null)
				return;
			
			ContextMenu menu = new ContextMenu();
			
			// no default items are added when the context menu is disabled
			if (!this.NoDefaultContextMenu)
			{
				List<MenuItem> optionals = new List<MenuItem>();
				
				if (this.CanUndo || this.CanRedo)
				{
					optionals.Add(new MenuItem("Undo", delegate { Undo(); }));
					optionals.Add(new MenuItem("Redo", delegate { Redo(); }));
					
					optionals[0].Enabled = this.CanUndo;
					optionals[1].Enabled = this.CanRedo;
				}
				else
				{
					optionals.Add(new MenuItem("Back", delegate { GoBack(); }));
					optionals.Add(new MenuItem("Forward", delegate { GoForward(); }));
					
					optionals[0].Enabled = this.CanGoBack;
					optionals[1].Enabled = this.CanGoForward;
				}
				
				optionals.Add(new MenuItem("-"));
				
				if (this.CanCopyImageContents)
					optionals.Add(new MenuItem("Copy Image Contents", delegate { CopyImageContents(); }));
				
				if (this.CanCopyImageLocation)
					optionals.Add(new MenuItem("Copy Image Location", delegate { CopyImageLocation(); }));
				
				if (this.CanCopyLinkLocation)
					optionals.Add(new MenuItem("Copy Link Location", delegate { CopyLinkLocation(); }));
				
				if (this.CanCopySelection)
					optionals.Add(new MenuItem("Copy Selection", delegate { CopySelection(); }));
				
				MenuItem mnuSelectAll = new MenuItem("Select All");
				mnuSelectAll.Click += delegate { SelectAll(); };

				GeckoDomDocument doc = GeckoDomDocument.CreateDomDocumentWraper(info.GetTargetNodeAttribute().GetOwnerDocumentAttribute());

				string viewSourceUrl = (doc == null) ? null : Convert.ToString(doc.Uri);
				
				MenuItem mnuViewSource = new MenuItem("View Source");
				mnuViewSource.Enabled = !string.IsNullOrEmpty(viewSourceUrl);
				mnuViewSource.Click += delegate { ViewSource(viewSourceUrl); };

				MenuItem mnuOpenInSystemBrowser = new MenuItem("View In System Browser");//nice for debugging with firefox/firebug
				mnuOpenInSystemBrowser.Enabled = !string.IsNullOrEmpty(viewSourceUrl);
				mnuOpenInSystemBrowser.Click += delegate { ViewInSystemBrowser(viewSourceUrl); };


				string properties = (doc != null && doc.Uri == Document.Uri) ? "Page Properties" : "IFRAME Properties";
				
				MenuItem mnuProperties = new MenuItem(properties);
				mnuProperties.Enabled = doc != null;
				mnuProperties.Click += delegate { ShowPageProperties(doc); };
				
				menu.MenuItems.AddRange(optionals.ToArray());
				menu.MenuItems.Add(mnuSelectAll);
				menu.MenuItems.Add("-");
				menu.MenuItems.Add(mnuViewSource);
				menu.MenuItems.Add(mnuOpenInSystemBrowser);
				menu.MenuItems.Add(mnuProperties);
			}

			// get image urls
			Uri backgroundImageSrc = null, imageSrc = null;
			nsIURI src;
			try
			{
				src = info.GetBackgroundImageSrcAttribute();
				backgroundImageSrc = new Uri(new nsURI(src).Spec);
			}
			catch (COMException comException)
			{
				if ((comException.ErrorCode & 0xFFFFFFFF) != 0x80004005)
					throw comException;
			}

			try
			{
				src = info.GetImageSrcAttribute();
				if (src != null)
					imageSrc = new Uri(new nsURI(src).Spec);
			}
			catch (COMException comException)
			{
				if ((comException.ErrorCode & 0xFFFFFFFF) != 0x80004005)
					throw comException;
			}
			
			// get associated link.  note that this needs to be done manually because GetAssociatedLink returns a non-zero
			// result when no associated link is available, so an exception would be thrown by nsString.Get()
			string associatedLink = null;
			try
			{
				using (nsAString str = new nsAString())
				{
					info.GetAssociatedLinkAttribute(str);
					associatedLink = str.ToString();
				}
			}
			catch (COMException comException) { }			
			
			GeckoContextMenuEventArgs e = new GeckoContextMenuEventArgs(
				PointToClient(MousePosition), menu, associatedLink, backgroundImageSrc, imageSrc,
				GeckoNode.Create(Xpcom.QueryInterface<nsIDOMNode>(info.GetTargetNodeAttribute()))
				);
			
			OnShowContextMenu(e);
			
			if (e.ContextMenu != null && e.ContextMenu.MenuItems.Count > 0)
			{
				e.ContextMenu.Show(this, e.Location);
			}
		}

		private void ViewInSystemBrowser(string url)
		{
			Process.Start(url);
		}
		
		/// <summary>
		/// Opens a new window which contains the source code for the current page.
		/// </summary>
		public void ViewSource()
		{
			ViewSource(Url.ToString());
		}
		
		/// <summary>
		/// Opens a new window which contains the source code for the specified page.
		/// </summary>
		/// <param name="url"></param>
		public void ViewSource(string url)
		{
			Form form = new Form();
			form.Text = "View Source";
			GeckoWebBrowser browser = new GeckoWebBrowser();
			browser.Dock = DockStyle.Fill;
			form.Controls.Add(browser);
			form.Load += delegate { browser.Navigate("view-source:" + url); };
			try
			{
#warning when geckoFX is used in WPF application there are no forms. We should rewrite this code
				var outerForm = FindForm();
				if (outerForm != null)
				{
					form.Icon = outerForm.Icon;
				}
			}
			catch ( Exception )
			{

			}
			
			form.ClientSize = this.ClientSize;
			form.StartPosition = FormStartPosition.CenterParent;
			form.Show();			
		}
		
		/// <summary>
		/// Displays a properties dialog for the current page.
		/// </summary>
		public void ShowPageProperties()
		{
			ShowPageProperties(Document);
		}
		
		public void ShowPageProperties(GeckoDomDocument document)
		{
			if (document == null)
				throw new ArgumentNullException("document");
			
			new PropertiesDialog((nsIDOMDocument)document.DomObject).ShowDialog(this);
		}
		
		#endregion

		#region nsIInterfaceRequestor Members

		IntPtr nsIInterfaceRequestor.GetInterface(ref Guid uuid)
		{
			object obj = this;
			
			// note: when a new window is created, gecko calls GetInterface on the webbrowser to get a DOMWindow in order
			// to set the starting url
			if (this.WebBrowser != null)
			{
				if (uuid == typeof(nsIDOMWindow).GUID)
				{
					obj = this.WebBrowser.GetContentDOMWindowAttribute();
				}
				else if (uuid == typeof(nsIDOMDocument).GUID)
				{
					obj = this.WebBrowser.GetContentDOMWindowAttribute().GetDocumentAttribute();
				}
			}
			
			IntPtr ppv, pUnk = Marshal.GetIUnknownForObject(obj);
			
			Marshal.QueryInterface(pUnk, ref uuid, out ppv);
			
			Marshal.Release(pUnk);

			return ppv;
		}

		#endregion

		#region nsIEmbeddingSiteWindow Members

		void nsIEmbeddingSiteWindow.SetDimensions(uint flags, int x, int y, int cx, int cy)
		{
			const int DIM_FLAGS_POSITION = 1;
			const int DIM_FLAGS_SIZE_INNER = 2;
			const int DIM_FLAGS_SIZE_OUTER = 4;
			
			BoundsSpecified specified = 0;
			if ((flags & DIM_FLAGS_POSITION) != 0)
			{
				specified |= BoundsSpecified.Location;
			}
			if ((flags & DIM_FLAGS_SIZE_INNER) != 0 || (flags & DIM_FLAGS_SIZE_OUTER) != 0)
			{
				specified |= BoundsSpecified.Size;
			}
			
			OnWindowSetBounds(new GeckoWindowSetBoundsEventArgs(new Rectangle(x, y, cx, cy), specified));			
		}
	
		void nsIEmbeddingSiteWindow.GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy)
		{			
			if ((flags & nsIEmbeddingSiteWindowConstants.DIM_FLAGS_POSITION) != 0)
			{
				Point pt = PointToScreen(Point.Empty);
				x = pt.X;
				y = pt.Y;
			}
			
			Control topLevel = this.TopLevelControl;
			
			Size nonClient = new Size(topLevel.Width - ClientSize.Width, topLevel.Height - ClientSize.Height);
			cx = ClientSize.Width;
			cy = ClientSize.Height;
			
			if ((this.ChromeFlags & (int)GeckoWindowFlags.OpenAsChrome) != 0)
			{
				BaseWindow.GetSize(ref cx, ref cy);
			}
			
			if ((flags & nsIEmbeddingSiteWindowConstants.DIM_FLAGS_SIZE_INNER) == 0)
			{
				cx += nonClient.Width;
				cy += nonClient.Height;
			}			
		}

		void nsIEmbeddingSiteWindow.SetFocus()
		{
			Focus();
			if (BaseWindow != null)
			{
				BaseWindow.SetFocus();
			}			
		}

		bool nsIEmbeddingSiteWindow.GetVisibilityAttribute()
		{
			return Visible;
		}

		void nsIEmbeddingSiteWindow.SetVisibilityAttribute(bool aVisibility)
		{
			//if (aVisibility)
			//{
			//      Form form = FindForm();
			//      if (form != null)
			//      {
			//            form.Visible = aVisibility;
			//      }
			//}
			
			Visible = aVisibility;
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

		#endregion

		#region nsIEmbeddingSiteWindow2 Members
		
		void nsIEmbeddingSiteWindow2.SetDimensions(uint flags, int x, int y, int cx, int cy)
		{
			(this as nsIEmbeddingSiteWindow).SetDimensions(flags, x, y, cx, cy);
		}

		void nsIEmbeddingSiteWindow2.GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy)
		{
			(this as nsIEmbeddingSiteWindow).GetDimensions(flags, ref x, ref y, ref cx, ref cy);
		}

		void nsIEmbeddingSiteWindow2.SetFocus()
		{
			(this as nsIEmbeddingSiteWindow).SetFocus();			
		}

		bool nsIEmbeddingSiteWindow2.GetVisibilityAttribute()
		{
			return (this as nsIEmbeddingSiteWindow).GetVisibilityAttribute();
		}

		void nsIEmbeddingSiteWindow2.SetVisibilityAttribute(bool aVisibility)
		{
			(this as nsIEmbeddingSiteWindow).SetVisibilityAttribute(aVisibility);
		}

		string nsIEmbeddingSiteWindow2.GetTitleAttribute()
		{
			return (this as nsIEmbeddingSiteWindow).GetTitleAttribute();
		}

		void nsIEmbeddingSiteWindow2.SetTitleAttribute(string aTitle)
		{
			(this as nsIEmbeddingSiteWindow).SetTitleAttribute(aTitle);
		}

		IntPtr nsIEmbeddingSiteWindow2.GetSiteWindowAttribute()
		{
			return (this as nsIEmbeddingSiteWindow).GetSiteWindowAttribute();
		}

		void nsIEmbeddingSiteWindow2.Blur()
		{
		      //throw new NotImplementedException();			
		}

		#endregion
		
		#region nsISupportsWeakReference Members

		nsIWeakReference nsISupportsWeakReference.GetWeakReference()
		{
			return this;			
		}

		#endregion

		#region nsIWeakReference Members
		IntPtr nsIWeakReference.QueryReferent(ref Guid uuid)
		{
			IntPtr ppv, pUnk = Marshal.GetIUnknownForObject(this);
			
			Marshal.QueryInterface(pUnk, ref uuid, out ppv);

			if (Xpcom.IsMono)
			{
				// TODO FIXME - remove this hack.
				Marshal.AddRef(ppv);
			}
			
			Marshal.Release(pUnk);
			
			if (ppv != IntPtr.Zero)
			{
			      Marshal.Release(ppv);
			}

			return ppv;
		}

		#endregion
		
		#region nsIWebProgressListener Members

		void nsIWebProgressListener.OnStateChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aStateFlags, int aStatus)
		{
			bool cancelled = false;

			/*
			 *  http://zenit.senecac.on.ca/wiki/dxr/source.cgi/mozilla/netwerk/protocol/viewsource/src/nsViewSourceChannel.cpp
			 *  "View source" always wants the currently cached content.
			 *  Method "aRequest.GetNameAttribute" failed on such requests.
			 */
			uint loadAttr = aRequest.GetLoadFlagsAttribute();
			if (((loadAttr & (1 << 10)) /* nsIRequest::LOAD_FROM_CACHE */) == 0)
				if ((aStateFlags & nsIWebProgressListenerConstants.STATE_START) != 0 && (aStateFlags & nsIWebProgressListenerConstants.STATE_IS_NETWORK) != 0)
				{
					IsBusy = true;

					Uri uri;
					Uri.TryCreate(nsString.Get(aRequest.GetNameAttribute), UriKind.Absolute, out uri);

					GeckoNavigatingEventArgs ea = new GeckoNavigatingEventArgs(uri);
					OnNavigating(ea);

					if (ea.Cancel)
					{
						aRequest.Cancel(0);
						cancelled = true;
					}
				}
			
			if (cancelled || ((aStateFlags & nsIWebProgressListenerConstants.STATE_STOP) != 0 && (aStateFlags & nsIWebProgressListenerConstants.STATE_IS_NETWORK) != 0))
			{
				// clear busy state
				IsBusy = false;
				
				// kill any cached document and raise DocumentCompleted event
				UnloadDocument();
				OnDocumentCompleted(EventArgs.Empty);
				
				// clear progress bar
				OnProgressChanged(new GeckoProgressEventArgs(100, 100));
				
				// clear status bar
				StatusText = "";
			}
		}

		void nsIWebProgressListener.OnProgressChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress)
		{
			int nProgress = aCurTotalProgress;
			int nProgressMax = Math.Max(aMaxTotalProgress, 0);
			
			if (nProgressMax == 0)
				nProgressMax = Int32.MaxValue;
			
			if (nProgress > nProgressMax)
				nProgress = nProgressMax;
			
			OnProgressChanged(new GeckoProgressEventArgs(nProgress, nProgressMax));
		}

		void nsIWebProgressListener.OnLocationChange(nsIWebProgress aWebProgress, nsIRequest aRequest, nsIURI aLocation)
		{
			// make sure we're loading the top-level window
			nsIDOMWindow domWindow = aWebProgress.GetDOMWindowAttribute();
			if (domWindow != null)
			{
			      if (domWindow != domWindow.GetTopAttribute())
			            return;
			}

			Uri uri = new Uri(nsString.Get(aLocation.GetSpecAttribute));
			
			OnNavigated(new GeckoNavigatedEventArgs(uri, aRequest));
			UpdateCommandStatus();
		}

		void nsIWebProgressListener.OnStatusChange(nsIWebProgress aWebProgress, nsIRequest aRequest, int aStatus, string aMessage)
		{
			if (aWebProgress.GetIsLoadingDocumentAttribute())
			{
				StatusText = aMessage;
				UpdateCommandStatus();
			}
		}

		void nsIWebProgressListener.OnSecurityChange(nsIWebProgress aWebProgress, nsIRequest aRequest, uint aState)
		{
			SecurityState = ( GeckoSecurityState ) aState;
		}
		
		/// <summary>
		/// Gets a value which indicates whether the current page is secure.
		/// </summary>
		[Browsable(false)]
		public GeckoSecurityState SecurityState
		{
			get { return _SecurityState; }
			private set
			{
				if (_SecurityState == value) return;
				_SecurityState = value;
				OnSecurityStateChanged(EventArgs.Empty);
			}
		}
		GeckoSecurityState _SecurityState;
	
		
		#region public event EventHandler SecurityStateChanged
		/// <summary>
		/// Occurs when the value of the <see cref="SecurityState"/> property is changed.
		/// </summary>
		[Category("Property Changed"), Description("Occurs when the value of the SecurityState property is changed.")]
		public event EventHandler SecurityStateChanged
		{
			add { this.Events.AddHandler(SecurityStateChangedEvent, value); }
			remove { this.Events.RemoveHandler(SecurityStateChangedEvent, value); }
		}
		private static object SecurityStateChangedEvent = new object();

		/// <summary>Raises the <see cref="SecurityStateChanged"/> event.</summary>
		/// <param name="e">The data for the event.</param>
		protected virtual void OnSecurityStateChanged(EventArgs e)
		{
			if (((EventHandler)this.Events[SecurityStateChangedEvent]) != null)
				((EventHandler)this.Events[SecurityStateChangedEvent])(this, e);
		}
		#endregion

		#endregion

		#region nsIDOMEventListener Members

		void nsIDOMEventListener.HandleEvent(nsIDOMEvent e)
		{
			string type = nsString.Get( e.GetTypeAttribute );
			
			GeckoDomEventArgs ea = null;
			
			switch (type)
			{
				case "keydown": OnDomKeyDown((GeckoDomKeyEventArgs)(ea = new GeckoDomKeyEventArgs((nsIDOMKeyEvent)e))); break;
				case "keyup": OnDomKeyUp((GeckoDomKeyEventArgs)(ea = new GeckoDomKeyEventArgs((nsIDOMKeyEvent)e))); break;
				case "keypress": OnDomKeyPress((GeckoDomKeyEventArgs)(ea = new GeckoDomKeyEventArgs((nsIDOMKeyEvent)e))); break;
				
				case "mousedown": OnDomMouseDown((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;
				case "mouseup": OnDomMouseUp((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;
				case "mousemove": OnDomMouseMove((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;
				case "mouseover": OnDomMouseOver((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;
				case "mouseout": OnDomMouseOut((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;
				case "click": OnDomClick(ea = new GeckoDomEventArgs(e)); break;
				case "dblclick": OnDomDoubleClick(ea = new GeckoDomEventArgs(e)); break;
				case "submit": OnDomSubmit(ea = new GeckoDomEventArgs(e)); break;
				case "compositionstart": OnDomCompositionStart(ea = new GeckoDomEventArgs(e)); break;
				case "compositionend": OnDomCompositionEnd(ea = new GeckoDomEventArgs(e)); break;
				case "contextmenu": OnDomContextMenu((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;				
				case "DOMMouseScroll": OnDomMouseScroll((GeckoDomMouseEventArgs)(ea = new GeckoDomMouseEventArgs((nsIDOMMouseEvent)e))); break;				
				case "focus": OnDomFocus(ea = new GeckoDomEventArgs(e)); break;
				case "blur": OnDomBlur(ea = new GeckoDomEventArgs(e)); break;
				case "load": OnLoad(ea = new GeckoDomEventArgs(e)); break;
				case "change": OnDomContentChanged(ea = new GeckoDomEventArgs(e)); break;

				default:
					Action<string> action;
					if(_messageEventListeners.TryGetValue(type, out action))
					{

						action.Invoke(new GeckoDomMessageEventArgs((nsIDOMMessageEvent)e).Message);
					}
					break;
			}
			
			

			if (ea != null && ea.Cancelable && ea.Handled)
				e.PreventDefault();
			
		}

		#endregion

		#region nsIWindowProvider Members
		//int nsIWindowProvider.provideWindow(nsIDOMWindow aParent, uint aChromeFlags, bool aPositionSpecified, bool aSizeSpecified, nsIURI aURI, nsAString aName, nsAString aFeatures, out bool aWindowIsNew, out nsIDOMWindow ret)
		//{
		//      if (!this.IsDisposed)
		//      {
		//            GeckoCreateWindowEventArgs e = new GeckoCreateWindowEventArgs((GeckoWindowFlags)aChromeFlags);                
		//            this.OnCreateWindow(e);
				
		//            if (e.WebBrowser != null)
		//            {
		//                  aWindowIsNew = true;
		//                  ret = (nsIDOMWindow)e.WebBrowser.Window.DomWindow;
		//                  return 0;
		//            }
		//            else
		//            {
		//                  System.Media.SystemSounds.Beep.Play();
		//            }
		//      }
			
		//      aWindowIsNew = true;
		//      ret = null;
		//      return -1;
		//}
		#endregion

		#region nsISHistoryListener Members
		void nsISHistoryListener.OnHistoryNewEntry(nsIURI aNewURI)
		{
			OnHistoryNewEntry(new GeckoHistoryEventArgs(new Uri(nsString.Get(aNewURI.GetSpecAttribute))));
		}

		bool nsISHistoryListener.OnHistoryGoBack(nsIURI aBackURI)
		{
			GeckoHistoryEventArgs e = new GeckoHistoryEventArgs(new Uri(nsString.Get(aBackURI.GetSpecAttribute)));
			OnHistoryGoBack(e);
			return !e.Cancel;
		}

		bool nsISHistoryListener.OnHistoryGoForward(nsIURI aForwardURI)
		{
			GeckoHistoryEventArgs e = new GeckoHistoryEventArgs(new Uri(nsString.Get(aForwardURI.GetSpecAttribute)));
			OnHistoryGoForward(e);
			return !e.Cancel;
		}

		bool nsISHistoryListener.OnHistoryReload(nsIURI aReloadURI, uint aReloadFlags)
		{
			GeckoHistoryEventArgs e = new GeckoHistoryEventArgs(new Uri(nsString.Get(aReloadURI.GetSpecAttribute)));
			OnHistoryReload(e);
			return !e.Cancel;
		}

		bool nsISHistoryListener.OnHistoryGotoIndex(int aIndex, nsIURI aGotoURI)
		{
			GeckoHistoryGotoIndexEventArgs e = new GeckoHistoryGotoIndexEventArgs(new Uri(nsString.Get(aGotoURI.GetSpecAttribute)), aIndex);
			OnHistoryGotoIndex(e);
			return !e.Cancel;
		}

		bool nsISHistoryListener.OnHistoryPurge(int aNumEntries)
		{
			GeckoHistoryPurgeEventArgs e = new GeckoHistoryPurgeEventArgs(aNumEntries);
			OnHistoryPurge(e);
			return !e.Cancel;
		}

		#endregion

		#region nsITooltipListener Members

		void nsITooltipListener.OnShowTooltip(int aXCoords, int aYCoords, string aTipText)
		{
			ToolTip = new ToolTipWindow();
			ToolTip.Location = PointToScreen(new Point(aXCoords, aYCoords)) + new Size(0, 24);
			ToolTip.Text = aTipText;
			ToolTip.Show();			
		}
		
		ToolTipWindow ToolTip;

		void nsITooltipListener.OnHideTooltip()
		{
			if (ToolTip != null)
			{
				ToolTip.Close();
			}
			
		}		
		#endregion

		/// <summary>
		/// Register a listener for a custom jscrip-initiated MessageEvent
		/// https://developer.mozilla.org/en/DOM/document.createEvent
		/// http://help.dottoro.com/ljknkjqd.php
		/// </summary>
		/// <param name="eventName"></param>
		/// <param name="action"></param>
		/// <example>AddMessageEventListener("callMe", (message=>MessageBox.Show(message)));</example>
		public void AddMessageEventListener(string eventName, Action<string> action)
		{
			nsIDOMEventTarget target = Xpcom.QueryInterface<nsIDOMWindow>(WebBrowser.GetContentDOMWindowAttribute()).GetWindowRootAttribute();
			target.AddEventListener(new nsAString(eventName), this, /*Review*/ true, true, /*what's this?*/2);
			_messageEventListeners.Add(eventName, action);
		}


        public void Observe(nsISupports aSubject, string aTopic, string aData)
        {
            if (aTopic.Equals(ObserverNotifications.HttpRequests.HttpOnModifyRequest))
            {
                HttpChannel httpChannel =HttpChannel.Create(aSubject);

            	Uri uri = httpChannel.Uri;
                Uri uriRef = httpChannel.Referrer;
            	var reqMethod = httpChannel.RequestMethod;
                var evt = new GeckoObserveHttpModifyRequestEventArgs(uri, uriRef, reqMethod, aData);

                OnObserveHttpModifyRequest(evt);

                if (evt.Cancel)
                {
                    httpChannel.Cancel(nsIHelperAppLauncherConstants.NS_BINDING_ABORTED);
                }
            }
        }

        #region nsIHttpActivityObserver members

        public Dictionary<nsIHttpChannel, GeckoJavaScriptHttpChannelWrapper> origJavaScriptHttpChannels = new Dictionary<nsIHttpChannel, GeckoJavaScriptHttpChannelWrapper>();

        public bool IsAjaxBusy
        {
            get { return (origJavaScriptHttpChannels.Count > 0); }
        }

        //public void ObserveActivity(nsISupports aHttpChannel, uint aActivityType, uint aActivitySubtype, uint aTimestamp, ulong aExtraSizeData, nsACString aExtraStringData)
        public void ObserveActivity(nsISupports aHttpChannel,
                             UInt32 aActivityType,
                             UInt32 aActivitySubtype,
                             Int64 aTimestamp,
                             UInt64 aExtraSizeData,
							 nsACStringBase aExtraStringData)
        {
            nsIHttpChannel httpChannel = Xpcom.QueryInterface<nsIHttpChannel>(aHttpChannel);

            if (httpChannel != null)
            {
                switch (aActivityType)
                {
                    case nsIHttpActivityObserverConstants.ACTIVITY_TYPE_SOCKET_TRANSPORT:
                        switch (aActivitySubtype)
                        {
                            case nsISocketTransportConstants.STATUS_RESOLVING:
                                break;
                            case nsISocketTransportConstants.STATUS_RESOLVED:
                                break;
                            case nsISocketTransportConstants.STATUS_CONNECTING_TO:
                                break;
                            case nsISocketTransportConstants.STATUS_CONNECTED_TO:
                                break;
                            case nsISocketTransportConstants.STATUS_SENDING_TO:
                                break;
                            case nsISocketTransportConstants.STATUS_WAITING_FOR:
                                break;
                            case nsISocketTransportConstants.STATUS_RECEIVING_FROM:
                                break;
                        }
                        break;
                    case nsIHttpActivityObserverConstants.ACTIVITY_TYPE_HTTP_TRANSACTION:
                        switch (aActivitySubtype)
                        {
                            case nsIHttpActivityObserverConstants.ACTIVITY_SUBTYPE_REQUEST_HEADER:
                                {
                                    var callbacks = httpChannel.GetNotificationCallbacksAttribute();
                                    var httpChannelXHR = Xpcom.QueryInterface<nsIXMLHttpRequest>(callbacks);

                                    if (httpChannelXHR != null)
                                    {
                                        nsIDOMEventListener origEventListener = httpChannelXHR.GetOnreadystatechangeAttribute();
                                        var newEventListener = new GeckoJavaScriptHttpChannelWrapper(this, httpChannel, origEventListener);
                                        origJavaScriptHttpChannels.Add(httpChannel, newEventListener);
                                        httpChannelXHR.SetOnreadystatechangeAttribute(newEventListener);
                                         
                                        #region POST data
                                        /**
                                        nsIUploadChannel uploadChannel = Xpcom.QueryInterface<nsIUploadChannel>(httpChannel);

                                        if (uploadChannel != null)
                                        {
                                            var uploadChannelStream = uploadChannel.GetUploadStreamAttribute();

                                            if (uploadChannelStream != null)
                                            {
                                                nsISeekableStream seekableChannelStream = Xpcom.QueryInterface<nsISeekableStream>(uploadChannelStream);

                                                if (seekableChannelStream != null)
                                                {
                                                    seekableChannelStream.Seek(0, 0);

                                                    var sis = Xpcom.CreateInstance<nsIScriptableInputStream>("@mozilla.org/scriptableinputstream;1");

                                                    var stream = Xpcom.QueryInterface<nsIInputStream>(uploadChannelStream);

                                                    sis.Init(stream);

                                                    StringBuilder sb = new StringBuilder();

                                                    for (var count = sis.Available(); count != 0; count = sis.Available())
                                                    {
                                                        sb.Append(sis.Read(count));
                                                    }
                                                }
                                            }
                                        }
                                        /**/
                                        #endregion POST data
                                    }
                                }
                                break;
                            case nsIHttpActivityObserverConstants.ACTIVITY_SUBTYPE_REQUEST_BODY_SENT:
                                break;
                            case nsIHttpActivityObserverConstants.ACTIVITY_SUBTYPE_RESPONSE_START:
                                break;
                            case nsIHttpActivityObserverConstants.ACTIVITY_SUBTYPE_RESPONSE_COMPLETE:
                                break;
                            case nsIHttpActivityObserverConstants.ACTIVITY_SUBTYPE_TRANSACTION_CLOSE:
                                break;
                        }
                        break;
                }
            }
        }

        public bool GetIsActiveAttribute()
        {
            return true;
        }
        #endregion nsIHttpActivityObserver members
	}
	

	#region public enum GeckoLoadFlags
	public enum GeckoLoadFlags
	{
		/// <summary>
		/// This is the default value for the load flags parameter.
		/// </summary>
		None = nsIWebNavigationConstants.LOAD_FLAGS_NONE,

		/// <summary>
		/// This flag specifies that the load should have the semantics of an HTML
		/// META refresh (i.e., that the cache should be validated).  This flag is
		/// only applicable to loadURI.
		/// XXX the meaning of this flag is poorly defined.
		/// </summary>
		IsRefresh = nsIWebNavigationConstants.LOAD_FLAGS_IS_REFRESH,

		/// <summary>
		/// This flag specifies that the load should have the semantics of a link
		/// click.  This flag is only applicable to loadURI.
		/// XXX the meaning of this flag is poorly defined.
		/// </summary>
		IsLink = nsIWebNavigationConstants.LOAD_FLAGS_IS_LINK,

		/// <summary>
		/// This flag specifies that history should not be updated.  This flag is only
		/// applicable to loadURI.
		/// </summary>
		BypassHistory = nsIWebNavigationConstants.LOAD_FLAGS_BYPASS_HISTORY,

		/// <summary>
		/// This flag specifies that any existing history entry should be replaced.
		/// This flag is only applicable to loadURI.
		/// </summary>
		ReplaceHistory = nsIWebNavigationConstants.LOAD_FLAGS_REPLACE_HISTORY,

		/// <summary>
		/// This flag specifies that the local web cache should be bypassed, but an
		/// intermediate proxy cache could still be used to satisfy the load.
		/// </summary>
		BypassCache = nsIWebNavigationConstants.LOAD_FLAGS_BYPASS_CACHE,

		/// <summary>
		/// This flag specifies that any intermediate proxy caches should be bypassed
		/// (i.e., that the content should be loaded from the origin server).
		/// </summary>
		BypassProxy = nsIWebNavigationConstants.LOAD_FLAGS_BYPASS_PROXY,

		/// <summary>
		/// This flag specifies that a reload was triggered as a result of detecting
		/// an incorrect character encoding while parsing a previously loaded
		/// document.
		/// </summary>
		CharsetChange = nsIWebNavigationConstants.LOAD_FLAGS_CHARSET_CHANGE,

		/// <summary>
		/// If this flag is set, Stop() will be called before the load starts
		/// and will stop both content and network activity (the default is to
		/// only stop network activity).  Effectively, this passes the
		/// STOP_CONTENT flag to Stop(), in addition to the STOP_NETWORK flag.
		/// </summary>
		StopContent = nsIWebNavigationConstants.LOAD_FLAGS_STOP_CONTENT,

		/// <summary>
		/// A hint this load was prompted by an external program: take care!
		/// </summary>
		FromExternal = nsIWebNavigationConstants.LOAD_FLAGS_FROM_EXTERNAL,

		/// <summary>
		/// This flag specifies that the URI may be submitted to a third-party
		/// server for correction. This should only be applied to non-sensitive
		/// URIs entered by users.
		/// </summary>
		AllowThirdPartyFixup = nsIWebNavigationConstants.LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP,

		/// <summary>
		/// This flag specifies that this is the first load in this object.
		/// Set with care, since setting incorrectly can cause us to assume that
		/// nothing was actually loaded in this object if the load ends up being
		/// handled by an external application.
		/// </summary>
		FirstLoad = nsIWebNavigationConstants.LOAD_FLAGS_FIRST_LOAD,
	}
	#endregion
	
	#region public enum GeckoSecurityState
	public enum GeckoSecurityState
	{
		/// <summary>
		/// This flag indicates that the data corresponding to the request was received over an insecure channel.
		/// </summary>
		Insecure = nsIWebProgressListenerConstants.STATE_IS_INSECURE,
		/// <summary>
		/// This flag indicates an unknown security state.  This may mean that the request is being loaded as part of
		/// a page in which some content was received over an insecure channel.
		/// </summary>
		Broken = nsIWebProgressListenerConstants.STATE_IS_BROKEN,
		/// <summary>
		/// This flag indicates that the data corresponding to the request was received over a secure channel.
		/// The degree of security is expressed by GeckoSecurityStrength.
		/// </summary>
		Secure = nsIWebProgressListenerConstants.STATE_IS_SECURE,
	}
	#endregion
	
	#region public enum GeckoWindowFlags
	[Flags]
	public enum GeckoWindowFlags
	{
		Default = 0x1,
		WindowBorders = 0x2,
		WindowClose = 0x4,
		WindowResize = 0x8,
		MenuBar = 0x10,
		ToolBar = 0x20,
		LocationBar = 0x40,
		StatusBar = 0x80,
		PersonalToolbar = 0x100,
		ScrollBars = 0x200,
		TitleBar = 0x400,
		Extra = 0x800,
		
		CreateWithSize = 0x1000,
		CreateWithPosition = 0x2000,
		
		WindowMin = 0x00004000,
		WindowPopup = 0x00008000,
		WindowRaised = 0x02000000,
		WindowLowered = 0x04000000,
		CenterScreen = 0x08000000,
		Dependent = 0x10000000,
		Modal = 0x20000000,
		OpenAsDialog = 0x40000000,
		OpenAsChrome = unchecked((int)0x80000000),
		All = 0x00000ffe,
	}
	#endregion

    #region GeckoJavaScriptHttpChannelWrapper
    public class GeckoJavaScriptHttpChannelWrapper : nsIDOMEventListener
    {
        private readonly GeckoWebBrowser m_browser;
        private readonly nsIHttpChannel m_httpChannel;
        private readonly nsIDOMEventListener m_origEventListener;
        private readonly nsIXMLHttpRequest m_notificationCallsbacks;

        public GeckoJavaScriptHttpChannelWrapper(GeckoWebBrowser p_browser, nsIHttpChannel p_httpChannel, nsIDOMEventListener p_origEventListener)
        {
            m_browser = p_browser;
            m_httpChannel = p_httpChannel;
            m_origEventListener = p_origEventListener;

            m_notificationCallsbacks = Xpcom.QueryInterface<nsIXMLHttpRequest>(m_httpChannel.GetNotificationCallbacksAttribute());
        }

        public void HandleEvent(nsIDOMEvent @event)
        {
            var xhr_uri = (new Uri(nsString.Get(m_httpChannel.GetOriginalURIAttribute().GetSpecAttribute))).ToString();
            var xhr_status = m_notificationCallsbacks.GetStatusAttribute();
            var xhr_readyState = m_notificationCallsbacks.GetReadyStateAttribute();

            try
            {
                m_origEventListener.HandleEvent(@event);
            }
            catch (COMException)
            {
            }

            // remove when finished
            if (xhr_readyState == 4)
            {
                m_browser.origJavaScriptHttpChannels.Remove(m_httpChannel);
            }
        }
    }
    #endregion GeckoJavaScriptHttpChannelWrapper
}
