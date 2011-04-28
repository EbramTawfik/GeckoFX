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
using System.Runtime.InteropServices;
using System.Text;
using System.Runtime.CompilerServices;

namespace Skybound.Gecko
{
	/**
	 * The mother of all xpcom interfaces.
	 *
	 *  In order to get both the right typelib and the right header we force
	 *  the 'real' output from xpidl to be commented out in the generated header
	 *  and includes a copy of the original nsISupports.h. This is all just to deal 
	 *  with the Mac specific ": public __comobject" thing.
	 */
	[Guid("00000000-0000-0000-c000-000000000046"), ComImport]
	public interface nsISupports
	{
		object QueryInterface(ref Guid iid);
		int AddRef();							// [noscript]
		int Release();							// [noscript]
	}

	/**
	 * The nsIComponentManager interface.
	 */
	[Guid("a88e5a60-205a-4bb1-94e1-2628daf51eae"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIComponentManager : nsISupports
	{
		/// <summary>
		/// Returns the factory object that can be used to create instances of Guid aClass.
		/// </summary>
		/// <param name="aClass">The classid of the factory that is being requested</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns>The factory object that can be used to create instances of aClass</returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetClassObject(ref Guid aClass, ref Guid aIID);

		/// <summary>
		/// Returns the factory object that can be used to create instances of Guid aClass.
		/// </summary>
		/// <param name="aContractID">The classid of the factory that is being requested</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns>The factory object that can be used to create instances of aClass</returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetClassObjectByContractID(string aContractID, ref Guid aIID);

		/// <summary>
		/// Create an instance of the Guid aClass and return the interface aIID.
		/// </summary>
		/// <param name="aClass">ClassID of object instance requested</param>
		/// <param name="aDelegate">Used for aggregation</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object CreateInstance(ref Guid aClass, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);

		/// <summary>
		/// Create an instance of the CID that implements aContractID and return the interface aIID.
		/// </summary>
		/// <param name="aContractID">ContractID of object instance requested</param>
		/// <param name="aDelegate">Used for aggregation</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns></returns>		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object CreateInstanceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, [MarshalAs(UnmanagedType.Interface)] nsISupports aDelegate, ref Guid aIID);
	}

	/**
	 * The nsIServiceManager manager interface provides a means to obtain
	 * global services in an application. The service manager depends on the 
	 * repository to find and instantiate factories to obtain services.
	 *
	 * Users of the service manager must first obtain a pointer to the global
	 * service manager by calling NS_GetServiceManager. After that, 
	 * they can request specific services by calling GetService. When they are
	 * finished they can NS_RELEASE() the service as usual.
	 *
	 * A user of a service may keep references to particular services indefinitely
	 * and only must call Release when it shuts down.
	 */
	[Guid("8bb35ed9-e332-462d-9155-4a002ab5c958"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIServiceManager
	{
		/// <summary>
		/// Returns the instance that implements aClass or aContractID and the interface aIID.  This may result in the instance being created.
		/// </summary>
		/// <param name="aClass">aClass or aContractID of object instance requested</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns>Resulting service</returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetService(ref Guid aClass, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Interface)] 		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		object GetServiceByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);

		/// <summary>
		/// isServiceInstantiated will return a true if the service has already been created, otherwise false
		/// </summary>
		/// <param name="aClass">aClass or aContractID of object instance requested</param>
		/// <param name="aIID">IID of interface requested</param>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiated(ref Guid aClass, ref Guid aIID);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsServiceInstantiatedByContractID([MarshalAs(UnmanagedType.LPStr)] string aContractID, ref Guid aIID);
	}

	/**
	 * The nsIWebBrowser interface is implemented by web browser objects.
	 * Embedders use this interface during initialisation to associate
	 * the new web browser instance with the embedders chrome and
	 * to register any listeners. The interface may also be used at runtime
	 * to obtain the content DOM window and from that the rest of the DOM.
	 */
	[Guid("33e9d001-caab-4ba9-8961-54902f197202"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowser
	{
		/// <summary>
		/// Registers a listener of the type specified by the iid to receive
		/// callbacks. The browser stores a weak reference to the listener to avoid any circular dependencies.
		/// Typically this method will be called to register an object
		/// to receive <CODE>nsIWebProgressListener</CODE> or 
		/// <CODE>nsISHistoryListener</CODE> notifications in which case the
		/// the IID is that of the interface.
		/// </summary>
		/// <param name="aListener">The listener to be added.</param>
		/// <param name="aIID">The IID of the interface that will be called on the listener as appropriate.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);

		/// <summary>
		/// Removes a previously registered listener.
		/// </summary>
		/// <param name="aListener">The listener to be removed.</param>
		/// <param name="aIID">The IID of the interface on the listener that will no longer be called.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWebBrowserListener([MarshalAs(UnmanagedType.Interface)] nsIWeakReference aListener, ref Guid aIID);

		/// <summary>
		/// The chrome object associated with the browser instance. The embedder
		/// must create one chrome object for <I>each</I> browser object
		/// that is instantiated. The embedder must associate the two by setting
		/// this property to point to the chrome object before creating the browser
		/// window via the browser's <CODE>nsIBaseWindow</CODE> interface. 
		/// 
		/// The chrome object must also implement <CODE>nsIEmbeddingSiteWindow</CODE>.
		/// 
		/// The chrome may optionally implement <CODE>nsIInterfaceRequestor</CODE>,
		/// <CODE>nsIWebBrowserChromeFocus</CODE>,
		/// <CODE>nsIContextMenuListener</CODE> and
		/// <CODE>nsITooltipListener</CODE> to receive additional notifications
		/// from the browser object.
		/// 
		/// The chrome object may optionally implement <CODE>nsIWebProgressListener</CODE> 
		/// instead of explicitly calling <CODE>addWebBrowserListener</CODE> and
		/// <CODE>removeWebBrowserListener</CODE> to register a progress listener
		/// object. If the implementation does this, it must also implement
		/// <CODE>nsIWeakReference</CODE>.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome GetContainerWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContainerWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome containerWindow);

		/// <summary>
		/// URI content listener parent. The embedder may set this property to
		/// their own implementation if they intend to override or prevent
		/// how certain kinds of content are loaded.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIContentListener GetParentURIContentListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentURIContentListener([MarshalAs(UnmanagedType.IUnknown)] object parentURIContentListener);

		/// <summary>
		/// The top-level DOM window. The embedder may walk the entire
		/// DOM starting from this value.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetContentDOMWindow();

		/// <summary>
		/// Whether this web browser is active. Active means that it's visible
		/// enough that we want to avoid certain optimizations like discarding
		/// decoded image data and throttling the refresh driver. In Firefox,
		/// this corresponds to the visible tab.
		/// 
		/// Defaults to true. For optimal performance, set it to false when
		/// appropriate.
		/// </summary>
		bool isActive();
	}

	/**
	 * nsIURIContentListener is an interface used by components which
	 * want to know (and have a chance to handle) a particular content type.
	 * Typical usage scenarios will include running applications which register
	 * a nsIURIContentListener for each of its content windows with the uri
	 * dispatcher service. 
	 */
	[Guid("94928ab3-8b63-11d3-989d-001083010e9b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIURIContentListener
	{
		/// <summary>
		/// Gives the original content listener first crack at stopping a load before
		/// it happens.
		/// </summary>
		/// <param name="aURI">URI that is being opened.</param>
		/// <returns>False if the load can continue. True if the open should be aborted.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnStartURIOpen([MarshalAs(UnmanagedType.Interface)] nsIURI aURI);

		/// <summary>
		/// Notifies the content listener to hook up an nsIStreamListener capable of consuming the data stream.
		/// </summary>
		/// <param name="aContentType">Content type of the data.</param>
		/// <param name="aIsContentPreferred">Indicates whether the content should 
		/// be preferred by this listener.</param>
		/// <param name="aRequest">Request that is providing the data.</param>
		/// <param name="aContentHandler">nsIStreamListener that will consume the 
		/// data. This should be set to Null if this content listener can't handle 
		/// the content type.</param>
		/// <returns>
		/// True if the consumer wants to handle the load completely by itself.  
		/// This causes the URI Loader do nothing else...
		/// False if the URI Loader should continue handling the load and call 
		/// the returned streamlistener's methods.
		/// </returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DoContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, bool aIsContentPreferred, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, out IntPtr aContentHandler); // aContentHandler=nsIStreamListener

		/// <summary>
		/// When given a uri to dispatch, if the URI is specified as 'preferred 
		/// content' then the uri loader tries to find a preferred content handler
		/// for the content type. The thought is that many content listeners may
		/// be able to handle the same content type if they have to. i.e. the mail
		/// content window can handle text/html just like a browser window content
		/// listener. However, if the user clicks on a link with text/html content,
		/// then the browser window should handle that content and not the mail
		/// window where the user may have clicked the link.  This is the difference
		/// between isPreferred and canHandleContent.
		/// </summary>
		/// <param name="aContentType">Content type of the data.</param>
		/// <param name="aDesiredContentType">Indicates that aContentType must be converted
		/// to aDesiredContentType before processing the
		/// data.  This causes a stream converted to be
		/// inserted into the nsIStreamListener chain.
		/// This argument can be <code>nsnull</code> if
		/// the content should be consumed directly as
		/// aContentType.</param>
		/// <returns>True if this is a preferred
		/// content handler for aContentType;
		/// False otherwise.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPreferred([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.LPStr)] out string aDesiredContentType);

		/// <summary>
		/// When given a uri to dispatch, if the URI is not specified as 'preferred
		/// content' then the uri loader calls canHandleContent to see if the content
		/// listener is capable of handling the content.
		/// </summary>
		/// <param name="aContentType">Content type of the data.</param>
		/// <param name="aIsContentPreferred">Indicates whether the content should be
		/// preferred by this listener.</param>
		/// <param name="aDesiredContentType">Indicates that aContentType must be converted
		/// to aDesiredContentType before processing the
		/// data.  This causes a stream converted to be
		/// inserted into the nsIStreamListener chain.
		/// This argument can be <code>nsnull</code> if
		/// the content should be consumed directly as
		/// aContentType.</param>
		/// <returns><code>true</code> if the data can be consumed.
		/// <code>false</code> otherwise.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanHandleContent([MarshalAs(UnmanagedType.LPStr)] string aContentType, [MarshalAs(UnmanagedType.Bool)]bool aIsContentPreferred, [MarshalAs(UnmanagedType.LPStr)] out string aDesiredContentType);

		/// <summary>
		/// The load context associated with a particular content listener.
		/// The URI Loader stores and accesses this value as needed.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetLoadCookie();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadCookie([MarshalAs(UnmanagedType.Interface)] nsISupports aLoadCookie);

		/// <summary>
		/// The parent content listener if this particular listener is part of a chain
		/// of content listeners (i.e. a docshell!)
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURIContentListener GetParentContentListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentContentListener([MarshalAs(UnmanagedType.Interface)]nsIURIContentListener aParentContentListener);
	}
	
	static class nsIWebBrowserChromeConstants
	{
		public const int STATUS_SCRIPT = 1;
		public const int STATUS_SCRIPT_DEFAULT = 2;
		public const int STATUS_LINK = 3;
		
		public const int CHROME_DEFAULT = 1;
		public const int CHROME_WINDOW_BORDERS = 2;
		public const int CHROME_WINDOW_CLOSE = 4;
		public const int CHROME_WINDOW_RESIZE = 8;
		public const int CHROME_MENUBAR = 16;
		public const int CHROME_TOOLBAR = 32;
		public const int CHROME_LOCATIONBAR = 64;
		public const int CHROME_STATUSBAR = 128;
		public const int CHROME_PERSONAL_TOOLBAR = 256;
		public const int CHROME_SCROLLBARS = 512;
		public const int CHROME_TITLEBAR = 1024;
		public const int CHROME_EXTRA = 2048;
		public const int CHROME_WITH_SIZE = 4096;
		public const int CHROME_WITH_POSITION = 8192;
		public const int CHROME_WINDOW_MIN = 16384;
		public const int CHROME_WINDOW_POPUP = 32768;
		public const int CHROME_WINDOW_RAISED = 33554432;
		public const int CHROME_WINDOW_LOWERED = 67108864;
		public const int CHROME_CENTER_SCREEN = 134217728;
		public const int CHROME_DEPENDENT = 268435456;
		public const int CHROME_MODAL = 536870912;
		public const int CHROME_OPENAS_DIALOG = 1073741824;
		public const int CHROME_OPENAS_CHROME = unchecked((int)2147483648);
		public const int CHROME_ALL = 4094;
	}

	/**
	 * nsIWebBrowserChrome corresponds to the top-level, outermost window
	 * containing an embedded Gecko web browser.
	 */
	[Guid("ba434c60-9d52-11d3-afb0-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserChrome
	{
		/// <summary>
		/// Called when the status text in the chrome needs to be updated.
		/// </summary>
		/// <param name="statusType">indicates what is setting the text</param>
		/// <param name="status">status string. null is an acceptable value meaning
		/// no status.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatus(int statusType, [MarshalAs(UnmanagedType.LPWStr)] string status);

		/// <summary>
		/// The currently loaded WebBrowser.  The browser chrome may be
		/// told to set the WebBrowser object to a new object by setting this
		/// attribute.  In this case the implementer is responsible for taking the 
		/// new WebBrowser object and doing any necessary initialization or setup 
		/// as if it had created the WebBrowser itself.  This includes positioning
		/// setting up listeners etc.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowser GetWebBrowser();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWebBrowser([MarshalAs(UnmanagedType.Interface)] nsIWebBrowser webBrowser);

		/// <summary>
		/// The chrome flags for this browser chrome. The implementation should
		/// reflect the value of this attribute by hiding or showing its chrome
		/// appropriately.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChromeFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeFlags(int flags);

		/// <summary>
		/// Asks the implementer to destroy the window associated with this
		/// WebBrowser object.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyBrowserWindow();

		/// <summary>
		/// Tells the chrome to size itself such that the browser will be the 
		/// specified size.
		/// </summary>
		/// <param name="cx">new width of the browser</param>
		/// <param name="cy">new height of the browser</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeBrowserTo(int cx, int cy);

		/// <summary>
		/// Shows the window as a modal window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowAsModal();

		/// <summary>
		/// Is the window modal (that is, currently executing a modal loop)?
		/// </summary>
		/// <returns>true if it's a modal window</returns>
		[return: MarshalAs(UnmanagedType.Bool)]		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWindowModal();

		/// <summary>
		/// Exit a modal event loop if we're in one. The implementation
		/// should also exit out of the loop if the window is destroyed.
		/// </summary>
		/// <param name="status">the result code to return from showAsModal</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitModalEventLoop(int status);
	}

	/** nsIWindowCreator is a callback interface used by Gecko to create
	 * new browser windows. The application, either Mozilla or an embedding app,
	 * must provide an implementation of the Window Watcher component and
	 * notify the WindowWatcher during application initialization.
	 */
	[Guid("30465632-a777-44cc-90f9-8145475ef999"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowCreator
	{
		/// <summary>
		/// Create a new window. Gecko will/may call this method, if made
		/// available to it, to create new windows.
		/// </summary>
		/// <param name="parent">parent window, if any. null if not. the newly created
		/// window should be made a child/dependent window of
		/// the parent, if any (and if the concept applies
		/// to the underlying OS).</param>
		/// <param name="chromeFlags">chrome features from nsIWebBrowserChrome</param>
		/// <returns>the new window</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome parent, uint chromeFlags);
	}

	/**
	 * nsIWindowWatcher is the keeper of Gecko/DOM Windows. It maintains
	 * a list of open top-level windows, and allows some operations on them.
	 */
	[Guid("002286a8-494b-43b3-8ddd-49e3fc50622b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowWatcher
	{
		/// <summary>
		/// Create a new window. It will automatically be added to our list
		/// </summary>
		/// <param name="aParent">parent window, if any. Null if no parent.  If it is
		/// impossible to get to an nsIWebBrowserChrome from aParent, this
		/// method will effectively act as if aParent were null.</param>
		/// <param name="aUrl">url to which to open the new window. Must already be
		/// escaped, if applicable. can be null.</param>
		/// <param name="aName">window name from JS window.open. can be null.  If a window
		/// with this name already exists, the openWindow call may just load
		/// aUrl in it (if aUrl is not null) and return it.</param>
		/// <param name="aFeatures">window features from JS window.open. can be null.</param>
		/// <param name="aArguments">extra argument(s) to the new window, to be attached
		/// as the |arguments| property. An nsISupportsArray will be
		/// unwound into multiple arguments (but not recursively!).
		/// can be null.</param>
		/// <returns>the new window</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.Interface)] nsISupports aArguments);

		/// <summary>
		/// Clients of this service can register themselves to be notified
		/// when a window is opened or closed (added to or removed from this
		/// service). This method adds an aObserver to the list of objects
		/// to be notified.
		/// </summary>
		/// <param name="aObserver">the object to be notified when windows are
		/// opened or closed.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

		/// <summary>
		/// Clients of this service can register themselves to be notified
		/// when a window is opened or closed (added to or removed from this
		/// service). This method removes an aObserver from the list of objects
		/// to be notified.
		/// </summary>
		/// <param name="aObserver">the observer to be removed.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterNotification([MarshalAs(UnmanagedType.Interface)] nsIObserver aObserver);

		/// <summary>
		/// Get an iterator for currently open windows in the order they were opened,
		/// guaranteeing that each will be visited exactly once.
		/// </summary>
		/// <returns>an enumerator which will itself return nsISupports objects which
		/// can be QIed to an nsIDOMWindow</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetWindowEnumerator();

		/// <summary>
		/// Return a newly created nsIPrompt implementation.
		/// </summary>
		/// <param name="aParent">the parent window used for posing alerts. can be null.</param>
		/// <returns>a new nsIPrompt object</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetNewPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);

		/// <summary>
		/// Return a newly created nsIAuthPrompt implementation.
		/// </summary>
		/// <param name="aParent">the parent window used for posing alerts. can be null.</param>
		/// <returns>a new nsIAuthPrompt object</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetNewAuthPrompter([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent);

		/// <summary>
		/// Set the window creator callback. It must be filled in by the app.
		/// openWindow will use it to create new windows.
		/// </summary>
		/// <param name="creator">the callback. if null, the callback will be cleared
		/// and window creation capabilities lost.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWindowCreator([MarshalAs(UnmanagedType.Interface)] nsIWindowCreator creator);

		/// <summary>
		/// Retrieve the chrome window mapped to the given DOM window. Window
		/// Watcher keeps a list of all top-level DOM windows currently open,
		/// along with their corresponding chrome interfaces. Since DOM Windows
		/// lack a (public) means of retrieving their corresponding chrome,
		/// this method will do that.
		/// </summary>
		/// <param name="aWindow">the DOM window whose chrome window the caller needs</param>
		/// <returns>the corresponding chrome window</returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome GetChromeForWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

		/// <summary>
		/// Retrieve an existing window (or frame).
		/// </summary>
		/// <param name="aTargetName">the window name</param>
		/// <param name="aCurrentWindow">a starting point in the window hierarchy to
		/// begin the search.  If null, each toplevel window
		/// will be searched.</param>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetWindowByName([MarshalAs(UnmanagedType.LPWStr)] string aTargetName, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aCurrentWindow);

		/// <summary>
		/// The Watcher serves as a global storage facility for the current active
		/// (frontmost non-floating-palette-type) window, storing and returning
		/// it on demand. Users must keep this attribute current, including after
		/// the topmost window is closed. This attribute obviously can return null
		/// if no windows are open, but should otherwise always return a valid
		/// window.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetActiveWindow();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetActiveWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aActiveWindow);
	}

	/**
	 * The nsIWindowProvider interface exists so that the window watcher's default
	 * behavior of opening a new window can be easly modified.  When the window
	 * watcher needs to open a new window, it will first check with the
	 * nsIWindowProvider it gets from the parent window.  If there is no provider
	 * or the provider does not provide a window, the window watcher will proceed
	 * to actually open a new window.
	 */
	[Guid("5119ac7f-81dd-4061-96a7-71f2cf5efee4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWindowProvider
	{
		/// <summary>
		/// A method to request that this provider provide a window.  The window
		/// returned need not to have the right name or parent set on it; setting
		/// those is the caller's responsibility.  The provider can always return null
		/// to have the caller create a brand-new window.
		/// </summary>
		/// <param name="aParent">Must not be null.  This is the window that the caller wants
		/// to use as the parent for the new window.  Generally,
		/// nsIWindowProvider implementors can expect to be somehow
		/// related to aParent; the relationship may depend on the
		/// nsIWindowProvider implementation.</param>
		/// <param name="aChromeFlags">The chrome flags the caller will use to create a new
		/// window if this provider returns null.  See
		/// nsIWebBrowserChrome for the possible values of this
		/// field.</param>
		/// <param name="aCalledFromJS">Whether or not the method was called from JavaScript.
		/// </param>
		/// <param name="aPositionSpecified">Whether the attempt to create a window is trying
		/// to specify a position for the new window.</param>
		/// <param name="aSizeSpecified">Whether the attempt to create a window is trying to
		/// specify a size for the new window.</param>
		/// <param name="aURI">The URI to be loaded in the new window.  The nsIWindowProvider
		/// implementation MUST NOT load this URI in the window it
		/// returns.  This URI is provided solely to help the
		/// nsIWindowProvider implementation make decisions; the caller
		/// will handle loading the URI in the window returned if
		/// provideWindow returns a window.  Note that the URI may be null
		/// if the load cannot be represented by a single URI (e.g. if
		/// the load has extra load flags, POST data, etc).</param>
		/// <param name="aName">The name of the window being opened.  Setting the name on the
		/// return value of provideWindow will be handled by the caller;
		/// aName is provided solely to help the nsIWindowProvider
		/// implementation make decisions.</param>
		/// <param name="aFeatures">The feature string for the window being opened.  This may
		/// be empty.  The nsIWindowProvider implementation is
		/// allowed to apply the feature string to the window it
		/// returns in any way it sees fit.  See the nsIWindowWatcher
		/// interface for details on feature strings.</param>
		/// <param name="aWindowIsNew">Whether the window being returned was just
		/// created by the window provider implementation.
		/// This can be used by callers to keep track of which
		/// windows were opened by the user as opposed to
		/// being opened programmatically.  This should be set
		/// to false if the window being returned existed
		/// before the provideWindow() call.  The value of this
		/// out parameter is meaningless if provideWindow()
		/// returns null.</param>
		/// <returns>A window the caller should use or null if the caller should just
		/// create a new window.  The returned window may be newly opened by
		/// the nsIWindowProvider implementation or may be a window that
		/// already existed.</returns>
		[PreserveSig]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int provideWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, uint aChromeFlags, [MarshalAs(UnmanagedType.Bool)] bool aPositionSpecified, [MarshalAs(UnmanagedType.Bool)] bool aSizeSpecified, nsIURI aURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString aName,[MarshalAs(UnmanagedType.LPStruct)] nsAString aFeatures, [MarshalAs(UnmanagedType.Bool)] out bool aWindowIsNew, [MarshalAs(UnmanagedType.Interface)] out nsIDOMWindow ret);
	}

	static class nsIXulWindowConstants
	{
		public const uint lowestZ = 0;
		public const uint loweredZ = 4;	// "alwaysLowered" attribute
		public const uint normalZ = 5;
		public const uint raisedZ = 6;	// "alwaysRaised" attribute
		public const uint highestZ = 9;
	}

	/**
	 * The nsIXULWindow
	 *
	 * When the window is destroyed, it will fire a "xul-window-destroyed"
	 * notification through the global observer service.
	 */
	[Guid("5869c5e5-743d-473c-bb71-41752146d373"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIXULWindow
	{
		/// <summary>
		/// The docshell owning the XUL for this window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetDocShell(); // nsIDocShell

		/// <summary>
		/// Indicates if this window is instrinsically sized.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIntrinsicallySized();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntrinsicallySized([MarshalAs(UnmanagedType.Bool)] bool aIntrinsicallySized);

		/// <summary>
		/// The primary content shell. 
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetPrimaryContentShell();

		/// <summary>
		/// The content shell specified by the supplied id.
		/// </summary>
		/// <param name="ID">ID of the content shell to return.</param>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetContentShellById([MarshalAs(UnmanagedType.LPWStr)] string ID);

		/// <summary>
		/// Tell this window that it has picked up a child XUL window
		/// </summary>
		/// <param name="aChild">the child window being added</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChildWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aChild);

		/// <summary>
		/// Tell this window that it has lost a child XUL window
		/// </summary>
		/// <param name="aChild">the child window being removed</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveChildWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aChild);

		/// <summary>
		/// Move the window to a centered position.
		/// </summary>
		/// <param name="aRelative">If not null, the window relative to which the window is
		/// moved. See aScreen parameter for details.</param>
		/// <param name="aScreen">PR_TRUE to center the window relative to the screen
		/// containing aRelative if aRelative is not null. If
		/// aRelative is null then relative to the screen of the
		/// opener window if it was initialized by passing it to
		/// nsWebShellWindow::Initialize. Failing that relative to
		/// the main screen.
		/// PR_FALSE to center it relative to aRelative itself.</param>
		/// <param name="aAlert">PR_TRUE to move the window to an alert position,
		/// generally centered horizontally and 1/3 down from the top.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Center([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aRelative, [MarshalAs(UnmanagedType.Bool)] bool aScreen, [MarshalAs(UnmanagedType.Bool)] bool aAlert);

		/// <summary>
		/// Shows the window as a modal window. That is, ensures that it is visible
		/// and runs a local event loop, exiting only once the window has been closed.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowModal();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetZLevel();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetZLevel(uint aZLevel);

		/// <summary>
		/// contextFlags are from nsIWindowCreator2
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetContextFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContextFlags(uint aContextFlags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetChromeFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChromeFlags(uint aChromeFlags);

		/// <summary>
		/// Begin assuming |chromeFlags| don't change hereafter, and assert
		/// if they do change.  The state change is one-way and idempotent.
		/// </summary>
		void AssumeChromeFlagsAreFrozen();

		/// <summary>
		/// Create a new window.
		/// </summary>
		/// <param name="aChromeFlags">see nsIWebBrowserChrome</param>
		/// <returns>the newly minted window</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow CreateNewWindow(uint aChromeFlags, [MarshalAs(UnmanagedType.IUnknown)] object aAppShell); // aAppShell=nsIAppShell
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetXULBrowserWindow(); // nsIXULBrowserWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXULBrowserWindow(IntPtr aXULBrowserWindow); // nsIXULBrowserWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ApplyChromeFlags();
	}

	[Guid("361facd0-6e9a-4ff1-a0d4-450744cf0023"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAppShellService
	{
		/// <summary>
		/// Create a window, which will be initially invisible.
		/// </summary>
		/// <param name="aParent">the parent window.  Can be null.</param>
		/// <param name="aUrl">the contents of the new window.</param>
		/// <param name="aChromeMask">chrome flags affecting the kind of OS border
		/// given to the window. see nsIBrowserWindow for
		/// bit/flag definitions.</param>
		/// <param name="aInitialWidth">width, in pixels, of the window.  Width of window
		/// at creation.  Can be overridden by the "width"
		/// tag in the XUL.  Set to NS_SIZETOCONTENT to force
		/// the window to wrap to its contents.</param>
		/// <param name="aInitialHeight">like aInitialWidth, but subtly different.</param>
		/// <param name="aAppShell">a widget "appshell" (event processor) to associate
		/// with the new window</param>
		/// <returns>the newly created window</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow CreateTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aParent, [MarshalAs(UnmanagedType.Interface)]nsIURI aUrl, uint aChromeMask, int aInitialWidth, int aInitialHeight, [MarshalAs(UnmanagedType.IUnknown)] object aAppShell);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateHiddenWindow([MarshalAs(UnmanagedType.IUnknown)] object aAppShell); // nsIAppShell
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DestroyHiddenWindow();

		/// <summary>
		/// Return the (singleton) application hidden window, automatically created
		/// and maintained by this AppShellService.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULWindow GetHiddenWindow();

		/// <summary>
		/// Return the (singleton) application hidden window, automatically created
		/// and maintained by this AppShellService.
		/// </summary>
		/// <returns></returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetHiddenDOMWindow(); // nsIDOMWindowInternal

		/// <summary>
		/// Return the (singleton) application hidden window as an nsIDOMWindowInternal,
		/// and, the corresponding JavaScript context pointer.  This is useful
		/// if you'd like to subsequently call OpenDialog on the hidden window.
		/// </summary>
		/// <param name="aHiddenDOMWindow">the hidden window QI'd to type nsIDOMWindowInternal</param>
		/// <param name="aJSContext">the corresponding JavaScript context</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHiddenWindowAndJSContext(out IntPtr aHiddenDOMWindow, IntPtr aJSContext); // nsIDOMWindowInternal JSContext

		/// <returns>Return true if the application hidden window was provided by the
		/// application. If it wasn't, the default hidden window was used. This will
		/// usually be false on all non-mac platforms.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetApplicationProvidedHiddenWindow();

		/// <summary>
		/// Add a window to the application's registry of windows.  These windows
		/// are generally shown in the Windows taskbar, and the application
		/// knows it can't quit until it's out of registered windows.
		/// </summary>
		/// <param name="aWindow">the window to register</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aWindow);

		/// <summary>
		/// Remove a window from the application's window registry. Note that
		/// this method won't automatically attempt to quit the app when
		/// the last window is unregistered. For that, see Quit().
		/// </summary>
		/// <param name="aWindow">the window to unregister</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterTopLevelWindow([MarshalAs(UnmanagedType.Interface)]nsIXULWindow aWindow);
	}

	/**
	 * Private "control" methods on the Window Watcher. These are annoying
	 * bookkeeping methods, not part of the public (embedding) interface.
	 */
	[Guid("8624594a-28d7-4bc3-8d12-b1c2b9eefd90"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsPIWindowWatcher
	{
		/// <summary>
		/// A window has been created. Add it to our list.
		/// </summary>
		/// <param name="aWindow">the window to add</param>
		/// <param name="aChrome">the corresponding chrome window. The DOM window
		/// and chrome will be mapped together, and the corresponding
		/// chrome can be retrieved using the (not private)
		/// method getChromeForWindow. If null, any extant mapping
		/// will be cleared.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddWindow([MarshalAs(UnmanagedType.IUnknown)]nsIDOMWindow aWindow, [MarshalAs(UnmanagedType.IUnknown)]nsIWebBrowserChrome aChrome);

		/// <summary>
		/// A window has been closed. Remove it from our list.
		/// </summary>
		/// <param name="aWindow">the window to remove</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveWindow([MarshalAs(UnmanagedType.IUnknown)]nsIDOMWindow aWindow);

		/// <summary>
		/// Like the public interface's open(), but can deal with openDialog
		/// style arguments.
		/// </summary>
		/// <param name="aParent">parent window, if any. Null if no parent.  If it is
		/// impossible to get to an nsIWebBrowserChrome from aParent, this
		/// method will effectively act as if aParent were null.</param>
		/// <param name="aUrl">url to which to open the new window. Must already be
		/// escaped, if applicable. can be null.</param>
		/// <param name="aName">window name from JS window.open. can be null.  If a window
		/// with this name already exists, the openWindow call may just load
		/// aUrl in it (if aUrl is not null) and return it.</param>
		/// <param name="aFeatures">window features from JS window.open. can be null.</param>
		/// <param name="aDialog">use dialog defaults</param>
		/// <param name="aArgs">Window argument</param>
		/// <returns>the new window</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenWindowJS([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPStr)] string aUrl, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.LPStr)] string aFeatures, [MarshalAs(UnmanagedType.Bool)] bool aDialog, [MarshalAs(UnmanagedType.IUnknown)] object aArgs);

		/// <summary>
		/// Find a named docshell tree item amongst all windows registered
		/// with the window watcher.  This may be a subframe in some window,
		/// for example.
		/// </summary>
		/// <param name="aName">the name of the window.  Must not be null.</param>
		/// <param name="aRequestor">the tree item immediately making the request.
		/// We should make sure to not recurse down into its findItemWithName
		/// method.</param>
		/// <param name="aOriginalRequestor">the original treeitem that made the request.
		/// Used for security checks.</param>
		/// <returns>the tree item with aName as the name, or null if there
		/// isn't one.  "Special" names, like _self, _top, etc, will be
		/// treated specially only if aRequestor is null; in that case they
		/// will be resolved relative to the first window the windowwatcher
		/// knows about.</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string aName, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
	}

	/**
	 * This interface is implemented by an object that wants
	 * to observe an event corresponding to a topic.
	 */
	[Guid("db242e01-e4d9-11d2-9dde-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIObserver
	{
		/// <summary>
		/// Observe will be called when there is a notification for the
		/// topic |aTopic|.  This assumes that the object implementing
		/// this interface has been registered with an observer service
		/// such as the nsIObserverService. 
		/// 
		/// If you expect multiple topics/subjects, the impl is 
		/// responsible for filtering.
		/// 
		/// You should not modify, add, remove, or enumerate 
		/// notifications in the implemention of observe.
		/// </summary>
		/// <param name="aSubject">Notification specific interface pointer.</param>
		/// <param name="aTopic">The notification topic or subject.</param>
		/// <param name="aData">Notification specific wide string.
		/// subject event.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Observe(nsISupports aSubject, [MarshalAs(UnmanagedType.LPStr)] string aTopic, [MarshalAs(UnmanagedType.LPWStr)] string aData);
	}

	/**
	 * The nsIBaseWindow describes a generic window and basic operations that 
	 * can be performed on it.  This is not to be a complete windowing interface
	 * but rather a common set that nearly all windowed objects support.    
	 */
	[Guid("046bc8a0-8015-11d3-af70-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIBaseWindow
	{
		/// <summary>
		/// Allows a client to initialize an object implementing this interface with
		/// the usually required window setup information.
		/// It is possible to pass null for both parentNativeWindow and parentWidget,
		/// but only docshells support this.
		/// </summary>
		/// <param name="parentNativeWindow">This allows a system to pass in the parenting
		/// window as a native reference rather than relying on the calling
		/// application to have created the parent window as an nsIWidget.  This 
		/// value will be ignored (should be nsnull) if an nsIWidget is passed in to
		/// the parentWidget parameter.</param>
		/// <param name="parentWidget">This allows a system to pass in the parenting widget.
		/// This allows some objects to optimize themselves and rely on the view
		/// system for event flow rather than creating numerous native windows.  If
		/// one of these is not available, nsnull should be passed.</param>
		/// <param name="x">This is the x co-ordinate relative to the parent to place the
		/// window.</param>
		/// <param name="y">This is the y co-ordinate relative to the parent to place the 
		/// window.</param>
		/// <param name="cx">This is the width for the window to be.</param>
		/// <param name="cy">This is the height for the window to be.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWindow(IntPtr parentNativeWindow, IntPtr /* nsIWidget */ parentWidget, int x, int y, int cx, int cy);

		/// <summary>
		/// Tells the window that intialization and setup is complete.  When this is
		/// called the window can actually create itself based on the setup
		/// information handed to it.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create();

		/// <summary>
		/// Tell the window that it should destroy itself.  This call should not be
		/// necessary as it will happen implictly when final release occurs on the
		/// object.  If for some reaons you want the window destroyed prior to release
		/// due to cycle or ordering issues, then this call provides that ability.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Destroy();

		/// <summary>
		/// Sets the current x and y coordinates of the control.  This is relative to
		/// the parent window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPosition(int x, int y);

		/// <summary>
		/// Gets the current x and y coordinates of the control.  This is relatie to the
		/// parent window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPosition(out int x, out int y);

		/// <summary>
		/// Sets the width and height of the control.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSize(int cx, int cy, [MarshalAs(UnmanagedType.Bool)] bool fRepaint);

		/// <summary>
		/// Gets the width and height of the control.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSize(out int cx, out int cy);

		/// <summary>
		/// Convenience function combining the SetPosition and SetSize into one call.
		/// Also is more efficient than calling both.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPositionAndSize(int x, int y, int cx, int cy, [MarshalAs(UnmanagedType.Bool)] bool fRepaint);

		/// <summary>
		/// Convenience function combining the GetPosition and GetSize into one call.
		/// Also is more efficient than calling both.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPositionAndSize(out int x, out int y, out int cx, out int cy);

		/// <summary>
		/// Tell the window to repaint itself
		/// </summary>
		/// <param name="force">if true, repaint immediately
		/// if false, the window may defer repainting as it sees fit.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Repaint([MarshalAs(UnmanagedType.Bool)] bool force);

		/// <summary>
		/// This is the parenting widget for the control.  This may be null if the
		/// native window was handed in for the parent during initialization.
		/// If this is returned, it should refer to the same object as
		/// parentNativeWindow.
		/// 
		/// Setting this after Create() has been called may not be supported by some
		/// implementations.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetParentWidget(); // returns: nsIWidget
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentWidget(IntPtr aParentWidget);

		/// <summary>
		/// This is the native window parent of the control.
		/// 
		/// Setting this after Create() has been called may not be supported by some
		/// implementations.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetParentNativeWindow(); // returns: nativeWindow
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetParentNativeWindow(IntPtr aParentNativeWindow);

		/// <summary>
		/// Attribute controls the visibility of the object behind this interface.
		/// Setting this attribute to false will hide the control.  Setting it to 
		/// true will show it.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibility();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibility(bool aVisibility);

		/// <summary>
		/// a disabled window should accept no user interaction; it's a dead window,
		/// like the parent of a modal window.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEnabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnabled([MarshalAs(UnmanagedType.Bool)] bool aEnabled);

		/// <summary>
		/// set blurSuppression to true to suppress handling of blur events.
		/// set it false to re-enable them. query it to determine whether
		/// blur events are suppressed. The implementation should allow
		/// for blur events to be suppressed multiple times.
		/// </summary>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBlurSuppression();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBlurSuppression([MarshalAs(UnmanagedType.Bool)]bool aBlurSuppression);

		/// <summary>
		/// Allows you to find out what the widget is of a given object.  Depending
		/// on the object, this may return the parent widget in which this object
		/// lives if it has not had to create its own widget.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetMainWidget();			// [noscript]

		/// <summary>
		/// Give the window focus.
		/// </summary>

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocus();

		/// <summary>
		/// Title of the window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] 
		string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle); 
	}
	
	static class nsIWebNavigationConstants
	{
		/****************************************************************************
		 * The following flags may be bitwise combined to form the load flags
		 * parameter passed to either the loadURI or reload method.  Some of these
		 * flags are only applicable to loadURI.
		 */
		public const int LOAD_FLAGS_MASK = 65535;
		public const int LOAD_FLAGS_NONE = 0;
		public const int LOAD_FLAGS_IS_REFRESH = 16;
		public const int LOAD_FLAGS_IS_LINK = 32;
		public const int LOAD_FLAGS_BYPASS_HISTORY = 64;
		public const int LOAD_FLAGS_REPLACE_HISTORY = 128;
		public const int LOAD_FLAGS_BYPASS_CACHE = 256;
		public const int LOAD_FLAGS_BYPASS_PROXY = 512;
		public const int LOAD_FLAGS_CHARSET_CHANGE = 1024;
		public const int LOAD_FLAGS_STOP_CONTENT = 2048;
		public const int LOAD_FLAGS_FROM_EXTERNAL = 4096;
		public const int LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP = 8192;
		public const int LOAD_FLAGS_FIRST_LOAD = 16384;

		/****************************************************************************
		* The following flags may be passed as the stop flags parameter to the stop
		* method defined on this interface.
		*/
		public const int STOP_NETWORK = 1;
		public const int STOP_CONTENT = 2;
		public const int STOP_ALL = 3;
	}

	/**
	 * The nsIWebNavigation interface defines an interface for navigating the web.
	 * It provides methods and attributes to direct an object to navigate to a new
	 * location, stop or restart an in process load, or determine where the object
	 * has previously gone.
	 */
	[Guid("f5d9e7b0-d930-11d3-b057-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebNavigation
	{
		/// <summary>
		/// Indicates if the object can go back.  If true this indicates that
		/// there is back session history available for navigation.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		bool GetCanGoBack();

		/// <summary>
		/// Indicates if the object can go forward.  If true this indicates that
		/// there is forward session history available for navigation
		/// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCanGoForward();

		/// <summary>
		/// Tells the object to navigate to the previous session history item.  When a
		/// page is loaded from session history, all content is loaded from the cache
		/// (if available) and page state (such as form values and scroll position) is
		/// restored.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoBack();

		/// <summary>
		/// Tells the object to navigate to the next session history item.  When a
		/// page is loaded from session history, all content is loaded from the cache
		/// (if available) and page state (such as form values and scroll position) is
		/// restored.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GoForward();

		/// <summary>
		/// Tells the object to navigate to the session history item at a given index.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GotoIndex(int index);

		/// <summary>
		/// Loads a given URI.  This will give priority to loading the requested URI
		/// in the object implementing this interface.  If it can't be loaded here
		/// however, the URI dispatcher will go through its normal process of content
		/// loading.
		/// </summary>
		/// <param name="aURI">The URI string to load.  For HTTP and FTP URLs and possibly others,
		/// characters above U+007F will be converted to UTF-8 and then URL-
		/// escaped per the rules of RFC 2396.</param>
		/// <param name="aLoadFlags">Flags modifying load behaviour.  This parameter is a bitwise
		/// combination of the load flags defined above.  (Undefined bits are
		/// reserved for future use.)  Generally you will pass LOAD_FLAGS_NONE
		/// for this parameter.</param>
		/// <param name="aReferrer">The referring URI.  If this argument is null, then the referring
		/// URI will be inferred internally.</param>
		/// <param name="aPostData">If the URI corresponds to a HTTP request, then this stream is
		/// appended directly to the HTTP request headers.  It may be prefixed
		/// with additional HTTP headers.  This stream must contain a "\r\n"
		/// sequence separating any HTTP headers from the HTTP request body.
		/// This parameter is optional and may be null.</param>
		/// <param name="aHeaders"></param>
		/// <returns>If the URI corresponds to a HTTP request, then any HTTP headers
		/// contained in this stream are set on the HTTP request.  The HTTP
		/// header stream is formatted as:
		/// ( HEADER "\r\n" )*
		/// This parameter is optional and may be null.</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int LoadURI([MarshalAs(UnmanagedType.LPWStr)] string aURI, uint aLoadFlags, [MarshalAs(UnmanagedType.Interface)]nsIURI aReferrer, [MarshalAs(UnmanagedType.Interface)]nsIInputStream aPostData, [MarshalAs(UnmanagedType.Interface)]nsIInputStream aHeaders);

		/// <summary>
		/// Tells the Object to reload the current page.  There may be cases where the
		/// user will be asked to confirm the reload (for example, when it is
		/// determined that the request is non-idempotent).
		/// </summary>
		/// <param name="aReloadFlags">Flags modifying load behaviour.  This parameter is a bitwise
		/// combination of the Load Flags defined in nsIWebNavigationConstants.  (Undefined bits are
		/// reserved for future use.)  Generally you will pass LOAD_FLAGS_NONE
		/// for this parameter.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reload(uint aReloadFlags);

		/// <summary>
		/// Stops a load of a URI.
		/// </summary>
		/// <param name="aStopFlags">This parameter is one of the stop flags defined in nsIWebNavigationConstants.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Stop(uint aStopFlags);

		/// <summary>
		/// Retrieves the current DOM document for the frame, or lazily creates a
		/// blank document if there is none.  This attribute never returns null except
		/// for unexpected error situations.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocument();

		/// <summary>
		/// The currently loaded URI or null.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr /*nsURI*/ GetCurrentURI();

		/// <summary>
		/// The referring URI for the currently loaded URI or null.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr /*nsIURI*/ GetReferringURI();

		/// <summary>
		/// The session history object used by this web navigation instance.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHistory GetSessionHistory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSessionHistory([MarshalAs(UnmanagedType.IUnknown)] object aSessionHistory);
	}

	/**
	 * nsISHistoryListener defines the interface one can implement to receive
	 * notifications about activities in session history and to be able to
	 * cancel them.
	 *
	 * A session history listener will be notified when pages are added, removed
	 * and loaded from session history. It can prevent any action (except adding
	 * a new session history entry) from happening by returning false from the
	 * corresponding callback method.
	 *
	 * A session history listener can be registered on a particular nsISHistory
	 * instance via the nsISHistory::addSHistoryListener() method.
	 */
	[Guid("3b07f591-e8e1-11d4-9882-00c04fa02f40"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsISHistoryListener
	{
		/// <summary>
		/// Called when a new document is added to session history. New documents are
		/// added to session history by docshell when new pages are loaded in a frame
		/// or content area.
		/// </summary>
		/// <param name="aNewURI">The URI of the document to be added to session history.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHistoryNewEntry([MarshalAs(UnmanagedType.Interface)]nsIURI aNewURI);

		/// <summary>
		/// Called when navigating to a previous session history entry.
		/// </summary>
		/// <param name="aBackURI">The URI of the session history entry being navigated to.</param>
		/// <returns>Whether the operation can proceed.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoBack([MarshalAs(UnmanagedType.Interface)]nsIURI aBackURI);

		/// <summary>
		/// Called when navigating to a next session history entry.
		/// </summary>
		/// <param name="aForwardURI">The URI of the session history entry being navigated to.</param>
		/// <returns>Whether the operation can proceed.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoForward([MarshalAs(UnmanagedType.Interface)]nsIURI aForwardURI);

		/// <summary>
		/// Called when the current document is reloaded.
		/// </summary>
		/// <param name="aReloadURI">The URI of the document to be reloaded.</param>
		/// <param name="aReloadFlags">Flags that indicate how the document is to be 
		/// refreshed. See constants on the nsIWebNavigation
		/// interface.</param>
		/// <returns>Whether the operation can proceed.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryReload(nsIURI aReloadURI, uint aReloadFlags);

		/// <summary>
		/// Called when navigating to a session history entry by index.
		/// </summary>
		/// <param name="aIndex">The index in session history of the entry to be loaded.</param>
		/// <param name="aGotoURI">The URI of the session history entry to be loaded.</param>
		/// <returns>Whether the operation can proceed.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGotoIndex(int aIndex, nsIURI aGotoURI);

		/// <summary>
		/// Called when entries are removed from session history. Entries can be
		/// removed from session history for various reasons, for example to control
		/// the memory usage of the browser, to prevent users from loading documents
		/// from history, to erase evidence of prior page loads, etc.
		/// </summary>
		/// <param name="aNumEntries">The number of entries to be removed from session history.</param>
		/// <returns>Whether the operation can proceed.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryPurge(int aNumEntries);		
	}

	/**
	 * Used to enumerate over elements defined by its implementor.
	 * Although hasMoreElements() can be called independently of getNext(),
	 * getNext() must be pre-ceeded by a call to hasMoreElements(). There is
	 * no way to "reset" an enumerator, once you obtain one.
	 */
	[Guid("d1899240-f9d2-11d2-bdd6-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsISimpleEnumerator
	{
		/// <summary>
		/// Called to determine whether or not the enumerator has
		/// any elements that can be returned via getNext(). This method
		/// is generally used to determine whether or not to initiate or
		/// continue iteration over the enumerator, though it can be
		/// called without subsequent getNext() calls. Does not affect
		/// internal state of enumerator.
		/// </summary>
		/// <returns>PR_TRUE if there are remaining elements in the enumerator.
		/// PR_FALSE if there are no more elements in the enumerator.</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();

		/// <summary>
		/// Called to retrieve the next element in the enumerator. The "next"
		/// element is the first element upon the first call. Must be
		/// pre-ceeded by a call to hasMoreElements() which returns PR_TRUE.
		/// This method is generally called within a loop to iterate over
		/// the elements in the enumerator.
		/// </summary>
		/// <returns>the next element in the enumeration.</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetNext();
	}

	/**
	 * nsIWebBrowserFocus
	 * Interface that embedders use for controlling and interacting
	 * with the browser focus management. The embedded browser can be focused by
	 * clicking in it or tabbing into it. If the browser is currently focused and
	 * the embedding application's top level window is disabled, deactivate() must
	 * be called, and activate() called again when the top level window is
	 * reactivated for the browser's focus memory to work correctly.
	 */
	[Guid("9c5d3c58-1dd1-11b2-a1c9-f3699284657a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebBrowserFocus
	{
		/// <summary>
		/// MANDATORY
		/// activate() is a mandatory call that must be made to the browser
		/// when the embedding application's window is activated *and* the 
		/// browser area was the last thing in focus.  This method can also be called
		/// if the embedding application wishes to give the browser area focus,
		/// without affecting the currently focused element within the browser.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Activate();

		/// <summary>
		/// MANDATORY
		/// deactivate() is a mandatory call that must be made to the browser
		/// when the embedding application's window is deactivated *and* the
		/// browser area was the last thing in focus.  On non-windows platforms,
		/// deactivate() should also be called when focus moves from the browser
		/// to the embedding chrome.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Deactivate();

		/// <summary>
		/// Give the first element focus within mozilla.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusAtFirstElement();

		/// <summary>
		/// Give the last element focus within mozilla.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusAtLastElement();

		/// <summary>
		/// The currently focused nsDOMWindow when the browser is active,
		/// or the last focused nsDOMWindow when the browser is inactive.
		/// </summary>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetFocusedWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aFocusedWindow);

		/// <summary>
		/// The currently focused nsDOMElement when the browser is active,
		/// or the last focused nsDOMElement when the browser is inactive.
		/// </summary>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFocusedElement();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocusedElement([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aFocusedElement);		
	}

	static class nsIWebBrowserPersistConstants
	{
		public const uint PERSIST_FLAGS_NONE = 0;
		public const uint PERSIST_FLAGS_FROM_CACHE = 1;
		public const uint PERSIST_FLAGS_BYPASS_CACHE = 2;
		public const uint PERSIST_FLAGS_IGNORE_REDIRECTED_DATA = 4;
		public const uint PERSIST_FLAGS_IGNORE_IFRAMES = 8;
		public const uint PERSIST_FLAGS_NO_CONVERSION = 16;
		public const uint PERSIST_FLAGS_REPLACE_EXISTING_FILES = 32;
		public const uint PERSIST_FLAGS_NO_BASE_TAG_MODIFICATIONS = 64;
		public const uint PERSIST_FLAGS_FIXUP_ORIGINAL_DOM = 128;
		public const uint PERSIST_FLAGS_FIXUP_LINKS_TO_DESTINATION = 256;
		public const uint PERSIST_FLAGS_DONT_FIXUP_LINKS = 512;
		public const uint PERSIST_FLAGS_SERIALIZE_OUTPUT = 1024;
		public const uint PERSIST_FLAGS_DONT_CHANGE_FILENAMES = 2048;
		public const uint PERSIST_FLAGS_FAIL_ON_BROKEN_LINKS = 4096;
		public const uint PERSIST_FLAGS_CLEANUP_ON_FAILURE = 8192;
		public const uint PERSIST_FLAGS_AUTODETECT_APPLY_CONVERSION = 16384;
		public const uint PERSIST_FLAGS_APPEND_TO_FILE = 32768;
		public const uint PERSIST_FLAGS_FORCE_ALLOW_COOKIES = 65536;

		public const uint PERSIST_STATE_READY = 1;
		public const uint PERSIST_STATE_SAVING = 2;
		public const uint PERSIST_STATE_FINISHED = 3;

		public const uint ENCODE_FLAGS_SELECTION_ONLY = 1;
		public const uint ENCODE_FLAGS_FORMATTED = 2;
		public const uint ENCODE_FLAGS_RAW = 4;
		public const uint ENCODE_FLAGS_BODY_ONLY = 8;
		public const uint ENCODE_FLAGS_PREFORMATTED = 16;
		public const uint ENCODE_FLAGS_WRAP = 32;
		public const uint ENCODE_FLAGS_FORMAT_FLOWED = 64;
		public const uint ENCODE_FLAGS_ABSOLUTE_LINKS = 128;
		public const uint ENCODE_FLAGS_ENCODE_W3C_ENTITIES = 256;
		public const uint ENCODE_FLAGS_CR_LINEBREAKS = 512;
		public const uint ENCODE_FLAGS_LF_LINEBREAKS = 1024;
		public const uint ENCODE_FLAGS_NOSCRIPT_CONTENT = 2048;
		public const uint ENCODE_FLAGS_NOFRAMES_CONTENT = 4096;
		public const uint ENCODE_FLAGS_ENCODE_BASIC_ENTITIES = 8192;
		public const uint ENCODE_FLAGS_ENCODE_LATIN1_ENTITIES = 16384;
		public const uint ENCODE_FLAGS_ENCLODE_HTML_ENTITIES = 32768;
	}
	
	[Guid("dd4e0a6a-210f-419a-ad85-40e8543b9465"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserPersist : nsICancelable
	{
		/// <summary>
		/// Flags governing how data is fetched and saved from the network. 
		/// It is best to set this value explicitly unless you are prepared
		/// to accept the default values.
		/// </summary>
		uint GetPersistFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistFlags(uint aPersistFlags);

		/// <summary>
		/// Current state of the persister object.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCurrentState();

		/// <summary>
		/// Value indicating the success or failure of the persist
		/// operation.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetResult();

		/// <summary>
		/// Callback listener for progress notifications. The object that the
		/// embbedder supplies may also implement nsIInterfaceRequestor and be
		/// prepared to return nsIAuthPrompt or other interfaces that may be required
		/// to download data.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebProgressListener GetProgressListener();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aProgressListener);

		/// <summary>
		/// Save the specified URI to file.
		/// </summary>
		/// <param name="aURI">URI to save to file. Some implementations of this interface
		/// may also support <CODE>nsnull</CODE> to imply the currently
		/// loaded URI.</param>
		/// <param name="aCacheKey">An object representing the URI in the cache or
		/// <CODE>nsnull</CODE>.  This can be a necko cache key,
		/// an nsIWebPageDescriptor, or the currentDescriptor of an
		/// nsIWebPageDescriptor.</param>
		/// <param name="aReferrer">The referrer URI to pass with an HTTP request or
		/// <CODE>nsnull</CODE>.</param>
		/// <param name="aPostData">Post data to pass with an HTTP request or
		/// <CODE>nsnull</CODE>.</param>
		/// <param name="aExtraHeaders">Additional headers to supply with an HTTP request
		/// or <CODE>nsnull</CODE>.</param>
		/// <param name="aFile">Target file. This may be a nsILocalFile object or an
		/// nsIURI object with a file scheme or a scheme that
		/// supports uploading (e.g. ftp).</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveURI([MarshalAs(UnmanagedType.Interface)]nsIURI aURI, [MarshalAs(UnmanagedType.Interface)]nsISupports aCacheKey, [MarshalAs(UnmanagedType.Interface)]nsIURI aReferrer, IntPtr aPostData, [MarshalAs(UnmanagedType.LPStr)] string aExtraHeaders, [MarshalAs(UnmanagedType.Interface)]nsISupports aFile); // aPostData=nsIInputStream

		/// <summary>
		/// Save a channel to a file. It must not be opened yet.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveChannel(IntPtr aChannel, [MarshalAs(UnmanagedType.Interface)] nsISupports aFile); // aChannel=nsIChannel

		/// <summary>
		/// Save the specified DOM document to file and optionally all linked files
		/// (e.g. images, CSS, JS, and subframes). Do not call this method until the
		/// document has finished loading!
		/// </summary>
		/// <param name="aDocument">Document to save to file. Some implementations of
		/// this interface may also support <CODE>nsnull</CODE>
		/// to imply the currently loaded document.</param>
		/// <param name="aFile">Target local file. This may be a nsILocalFile object or an
		/// nsIURI object with a file scheme or a scheme that
		/// supports uploading (e.g. ftp).</param>
		/// <param name="aDataPath">Path to directory where URIs linked to the document
		/// are saved or nsnull if no linked URIs should be saved.
		/// This may be a nsILocalFile object or an nsIURI object
		/// with a file scheme.</param>
		/// <param name="aOutputContentType">The desired MIME type format to save the 
		/// document and all subdocuments into or nsnull to use
		/// the default behaviour.</param>
		/// <param name="aEncodingFlags">Flags to pass to the encoder.</param>
		/// <param name="aWrapColumn">For text documents, indicates the desired width to
		/// wrap text at. Parameter is ignored if wrapping is not
		/// specified by the encoding flags.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SaveDocument([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.IUnknown)] object aFile, [MarshalAs(UnmanagedType.Interface)] nsISupports aDataPath, [MarshalAs(UnmanagedType.LPStr)] string aOutputContentType, uint aEncodingFlags, uint aWrapColumn);

		/// <summary>
		/// ancels the current operation. The caller is responsible for cleaning up
		/// partially written files or directories. This has the same effect as calling
		/// cancel with an argument of NS_BINDING_ABORTED.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelSave();
	}

	static class nsIContextMenuListener2Constants
	{
		public const uint CONTEXT_NONE = 0;
		public const uint CONTEXT_LINK = 1;
		public const uint CONTEXT_IMAGE = 2;
		public const uint CONTEXT_DOCUMENT = 4;
		public const uint CONTEXT_TEXT = 8;
		public const uint CONTEXT_INPUT = 16;
		public const uint CONTEXT_BACKGROUND_IMAGE = 32;
	}

	/**
	 * nsIContextMenuListener2
	 *
	 * This is an extended version of nsIContextMenuListener
	 * It provides a helper class, nsIContextMenuInfo, to allow access to
	 * background images as well as various utilities.
	 */
	[Guid("7fb719b3-d804-4964-9596-77cf924ee314"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIContextMenuListener2
	{
		/// <summary>
		/// Called when the browser receives a context menu event (e.g. user is right-mouse
		/// clicking somewhere on the document). The combination of flags, along with the
		/// attributes of <CODE>aUtils</CODE>, indicate where and what was clicked on.
		/// </summary>
		/// <param name="aContextFlags">Flags indicating the kind of context.</param>
		/// <param name="aUtils">Context information and helper utilities.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowContextMenu(uint aContextFlags, nsIContextMenuInfo aUtils); 
	}

	/**
	 * nsIContextMenuInfo
	 *
	 * A helper object for implementors of nsIContextMenuListener2.
	 */
	[Guid("2f977d56-5485-11d4-87e2-0010a4e75ef2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIContextMenuInfo
	{
		/// <summary>
		/// The DOM context menu event.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEvent GetMouseEvent();

		/// <summary>
		/// The DOM node most relevant to the context.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetTargetNode();

		/// <summary>
		/// Given the <CODE>CONTEXT_LINK</CODE> flag, <CODE>targetNode</CODE> may not
		/// nescesarily be a link. This returns the anchor from <CODE>targetNode</CODE>
		/// if it has one or that of its nearest ancestor if it does not.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetAssociatedLink([MarshalAs(UnmanagedType.LPStruct)]nsAString aAssociatedLink);

		/// <summary>
		/// Given the <CODE>CONTEXT_IMAGE</CODE> flag, these methods can be
		/// used in order to get the image for viewing, saving, or for the clipboard.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetImageContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetImageSrc([MarshalAs(UnmanagedType.Interface)]out nsIURI result);

		/// <summary>
		/// Given the <CODE>CONTEXT_BACKGROUND_IMAGE</CODE> flag, these methods can be
		/// used in order to get the image for viewing, saving, or for the clipboard.
		/// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		imgIContainer GetBackgroundImageContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetBackgroundImageSrc([MarshalAs(UnmanagedType.Interface)]out nsIURI result); 
	}

	static class imgIContainerConstants
	{
		public const ushort TYPE_RASTER = 0;
		public const ushort TYPE_VECTOR = 1;

		public const long FLAG_NONE = 0x0;
		public const long FLAG_SYNC_DECODE = 0x1;
		public const long FLAG_DECODE_NO_PREMULTIPLY_ALPHA = 0x2;
		public const long FLAG_DECODE_NO_COLORSPACE_CONVERSION = 0x4;

		public const uint FRAME_FIRST = 0;
		public const uint FRAME_CURRENT = 1;
		public const uint FRAME_MAX_VALUE = 1;

		public const short kNormalAnimMode = 0;
		public const short kDontAnimMode = 1;
		public const short kLoopOnceAnimMode = 2;
	}

	/**
	 * imgIContainer is the interface that represents an image. It allows
	 * access to frames as Thebes surfaces, and permits users to extract subregions
	 * as other imgIContainers. It also allows drawing of images on to Thebes
	 * contexts.
	 *
	 * Internally, imgIContainer also manages animation of images.
	 */
	[Guid("239dfa70-2285-4d63-99cd-e9b7ff9555c7"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface imgIContainer
	{
		/// <summary>
		/// The width of the container rectangle.  In the case of any error,
		/// zero is returned, and an exception will be thrown.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetWidth();

		/// <summary>
		/// The height of the container rectangle.  In the case of any error,
		/// zero is returned, and an exception will be thrown.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetHeight();

		/// <summary>
		/// The type of this image
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ushort GetType();

		/// <summary>
		/// Whether this image is animated. You can only be guaranteed that querying
		/// this will not throw if STATUS_DECODE_COMPLETE is set on the imgIRequest.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool Animated();

		/// <summary>
		/// Whether the current frame is opaque; that is, needs the background painted
		/// behind it.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CurrentFrameIsOpaque();

		/// <summary>
		/// Get a surface for the given frame. This may be a platform-native,
		/// optimized surface, so you cannot inspect its pixel data.
		/// </summary>
		/// <param name="aWhichFrame">Frame specifier of the FRAME_* variety.</param>
		/// <param name="aFlags">Flags of the FLAG_* variety</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr GetFrame(uint aWhichFrame, uint aFlags);

		/// <summary>
		/// Create and return a new copy of the given frame that you can write to
		/// and otherwise inspect the pixels of.
		/// </summary>
		/// <param name="aWhichFrame">Frame specifier of the FRAME_* variety.</param>
		/// <param name="aFlags">Flags of the FLAG_* variety</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr CopyFrame(uint aWhichFrame, uint aFlags);

		/// <summary>
		/// Create a new imgContainer that contains only a single frame, which itself
		/// contains a subregion of the given frame.
		/// </summary>
		/// <param name="aWhichFrame">Frame specifier of the FRAME_* variety.</param>
		/// <param name="aRect">the area of the current frame to be duplicated in the
		/// returned imgContainer's frame.</param>
		/// <param name="aFlags">Flags of the FLAG_* variety</param>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		imgIContainer ExtractFrame(uint aWhichFrame, IntPtr aRect, uint aFlags);

		/// <summary>
		/// Draw the current frame on to the context specified.
		/// </summary>
		/// <param name="aContext">The Thebes context to draw the image to.</param>
		/// <param name="aFilter">The filter to be used if we're scaling the image.</param>
		/// <param name="aUserSpaceToImageSpace">The transformation from user space (e.g.,
		/// appunits) to image space.</param>
		/// <param name="aFill">The area in the context to draw pixels to. Image will be
		/// automatically tiled as necessary.</param>
		/// <param name="aSubimage">The area of the image, in pixels, that we are allowed to
		/// sample from.</param>
		/// <param name="aViewportSize">The size (in CSS pixels) of the viewport that would be available
		/// for the full image to occupy, if we were drawing the full image.</param>
		/// <param name="aFlags">Flags of the FLAG_* variety</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void Draw(IntPtr aContext, IntPtr aFilter, IntPtr aUserSpaceToImageSpace, IntPtr aFill, IntPtr aSubimage, IntPtr aViewportSize, uint aFlags);	// [noscript]

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr GetRootLayoutFrame();	// [notxpcom]

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void RequestDecode();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void LockImage();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void UnlockImage();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		ushort GetAnimationMode();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetAnimationMode(ushort aAnimationMode);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ResetAnimation();
	}

	/**
	 * The nsIInterfaceRequestor interface defines a generic interface for 
	 * requesting interfaces that a given object might provide access to.
	 * This is very similar to QueryInterface found in nsISupports.  
	 * The main difference is that interfaces returned from GetInterface()
	 * are not required to provide a way back to the object implementing this 
	 * interface.  The semantics of QI() dictate that given an interface A that 
	 * you QI() on to get to interface B, you must be able to QI on B to get back 
	 * to A.  This interface however allows you to obtain an interface C from A 
	 * that may or most likely will not have the ability to get back to A. 
	 */
	[Guid("033a1470-8b2a-11d3-af88-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIInterfaceRequestor
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetInterface(ref Guid uuid);
	}
	
	static class nsIEmbeddingSiteWindowConstants
	{
		public const int DIM_FLAGS_POSITION = 1;
		public const int DIM_FLAGS_SIZE_INNER = 2;
		public const int DIM_FLAGS_SIZE_OUTER = 4;
	}

	/**
	 * The nsIEmbeddingSiteWindow is implemented by the embedder to provide
	 * Gecko with the means to call up to the host to resize the window,
	 * hide or show it and set/get its title.
	 */
	[Guid("3e5432cd-9568-4bd1-8cbe-d50aba110743"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIEmbeddingSiteWindow
	{
		/// <summary>
		/// Sets the dimensions for the window; the position & size. The
		/// flags to indicate what the caller wants to set and whether the size
		/// refers to the inner or outer area. The inner area refers to just
		/// the embedded area, wheras the outer area can also include any 
		/// surrounding chrome, window frame, title bar, and so on.
		/// </summary>
		/// <param name="flags">Combination of position, inner and outer size flags.</param>
		/// <param name="x">Left hand corner of the outer area.</param>
		/// <param name="y">Top corner of the outer area.</param>
		/// <param name="cx">Width of the inner or outer area.</param>
		/// <param name="cy">Height of the inner or outer area.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDimensions(uint flags, int x, int y, int cx, int cy);

		/// <summary>
		/// Gets the dimensions of the window. The caller may pass
		/// <CODE>nsnull</CODE> for any value it is uninterested in receiving.
		/// </summary>
		/// <param name="flags">Combination of position, inner and outer size flags.</param>
		/// <param name="x">Left hand corner of the outer area.</param>
		/// <param name="y">Top corner of the outer area.</param>
		/// <param name="cx">Width of the inner or outer area.</param>
		/// <param name="cy">Height of the inner or outer area.</param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]	
		void GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy);

		/// <summary>
		/// Give the window focus.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetFocus();

		/// <summary>
		/// Visibility of the window.
		/// </summary>
		/// <returns></returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetVisibility();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibility([MarshalAs(UnmanagedType.Bool)] bool aVisibility);

		/// <summary>
		/// Title of the window.
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle);

		/// <summary>
		/// Native window for the site's window. The implementor should copy the
		/// native window object into the address supplied by the caller. The
		/// type of the native window that the address refers to is  platform
		/// and OS specific
		/// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetSiteWindow();
	}
	
	[Guid("e932bf55-0a64-4beb-923a-1f32d3661044"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIEmbeddingSiteWindow2 : nsIEmbeddingSiteWindow
	{			
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDimensions(uint flags, int x, int y, int cx, int cy);
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new void GetDimensions(uint flags, ref int x, ref int y, ref int cx, ref int cy);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFocus();
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetVisibility();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetVisibility([MarshalAs(UnmanagedType.Bool)] bool aVisibility);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] new string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitle([MarshalAs(UnmanagedType.LPWStr)] string aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetSiteWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
	}
	
	[Guid("29fb2a18-1dd2-11b2-8dd9-a6fd5d5ad12f"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOM3Node
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBaseURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aBaseURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort CompareDocumentPosition(nsIDOMNode other);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextContent([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextContent([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSameNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode other);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEqualNode(nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetFeature([MarshalAs(UnmanagedType.LPStruct)]nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr SetUserData([MarshalAs(UnmanagedType.LPStr)] string key, IntPtr data, IntPtr handler); // data=nsIVariant, handler=nsIDOMUserDataHandler, returns nsIVariant
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetUserData([MarshalAs(UnmanagedType.LPStr)] string key); // returns nsIVariant
	}
	
	[Guid("9188bc86-f92e-11d2-81ef-0060083a0bcf"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsISupportsWeakReference
	{
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWeakReference GetWeakReference();
	}
	
	[Guid("9188bc85-f92e-11d2-81ef-0060083a0bcf"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWeakReference
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr QueryReferent(ref Guid uuid);
	}
	
	[Guid("7d935d63-6d2a-4600-afb5-9a4f7d68b825"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDocShellTreeItem
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPWStr)] string aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NameEquals([MarshalAs(UnmanagedType.LPWStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemType(int aItemType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.IUnknown)] object aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTreeOwner(); // nsIDocShellTreeOwner
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeOwner(IntPtr treeOwner);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChildOffset(int aChildOffset); 		
	}
	
	[Guid("09b54ec1-d98a-49a9-bc95-3219e8b55089"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDocShellTreeItem19
	{
		// nsIDocShellTreeNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildCount();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddChild([MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem child);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem child);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetChildAt(int index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindChildWithName([MarshalAs(UnmanagedType.LPWStr)] string aName, [MarshalAs(UnmanagedType.Bool)] bool aRecurse, [MarshalAs(UnmanagedType.Bool)]bool aSameType, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);

		// nsIDocShellTreeItem:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPWStr)] string aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool NameEquals([MarshalAs(UnmanagedType.LPWStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetItemType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetItemType(int aItemType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetRootTreeItem();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem GetSameTypeRootTreeItem();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShellTreeItem FindItemWithName([MarshalAs(UnmanagedType.LPWStr)] string name, [MarshalAs(UnmanagedType.Interface)]nsISupports aRequestor, [MarshalAs(UnmanagedType.Interface)]nsIDocShellTreeItem aOriginalRequestor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTreeOwner(); // nsIDocShellTreeOwner
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTreeOwner(IntPtr treeOwner); // nsIDocShellTreeOwner
	}
	
	static class nsIDocShellTreeItemConstants
	{
		public const int typeChrome = 0;
		public const int typeContent = 1;
		public const int typeContentWrapper = 2;
		public const int typeChromeWrapper = 3;
		public const int typeAll = 2147483647;
	}
	
	static class nsIWebProgressListenerConstants
	{
		public const int STATE_START = 1;
		public const int STATE_REDIRECTING = 2;
		public const int STATE_TRANSFERRING = 4;
		public const int STATE_NEGOTIATING = 8;
		public const int STATE_STOP = 16;
		public const int STATE_IS_REQUEST = 65536;
		public const int STATE_IS_DOCUMENT = 131072;
		public const int STATE_IS_NETWORK = 262144;
		public const int STATE_IS_WINDOW = 524288;
		public const int STATE_RESTORING = 16777216;
		public const int STATE_IS_INSECURE = 4;
		public const int STATE_IS_BROKEN = 1;
		public const int STATE_IS_SECURE = 2;
		public const int STATE_SECURE_HIGH = 262144;
		public const int STATE_SECURE_MED = 65536;
		public const int STATE_SECURE_LOW = 131072;
	}
	
	[Guid("570f39d1-efd0-11d3-b093-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebProgressListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStateChange([MarshalAs(UnmanagedType.Interface)]nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)]nsIRequest aRequest, int aStateFlags, int aStatus);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnProgressChange([MarshalAs(UnmanagedType.Interface)]nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)]nsIRequest aRequest, int aCurSelfProgress, int aMaxSelfProgress, int aCurTotalProgress, int aMaxTotalProgress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnLocationChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, [MarshalAs(UnmanagedType.Interface)] nsIURI aLocation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStatusChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aStatus, [MarshalAs(UnmanagedType.LPWStr)] string aMessage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsIWebProgress aWebProgress, [MarshalAs(UnmanagedType.Interface)] nsIRequest aRequest, int aState); 
	}
	
	[Guid("ef6bfbd2-fd46-48d8-96b7-9f8f0fd387fe"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIRequest
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)]nsACString aName);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsPending();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStatus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aStatus);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suspend();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetLoadGroup(); // nsILoadGroup
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadGroup(IntPtr aLoadGroup);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLoadFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadFlags(int aLoadFlags);
	}
	
	[Guid("570f39d0-efd0-11d3-b093-00a024ffc08c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIWebProgress
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener, int aNotifyMask);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProgressListener([MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aListener);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetDOMWindow();
		
		[return: MarshalAs(UnmanagedType.Bool)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsLoadingDocument();
	}
	
	[Guid("07a22cc0-0ce5-11d3-9331-00104ba0fd40"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIURI
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpec([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outSpec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpec([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inSpec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPrePath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outPrePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetScheme([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScheme([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUserPass([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outUserPass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUserPass([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String inUserPass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsername([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String outUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsername([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPassword([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPassword([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostPort([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHostPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHostPort([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHostPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHost([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHost([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aHost);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPort();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPort(int aPort);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPath([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aPath);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals(nsIURI other);
		
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SchemeIs([MarshalAs(UnmanagedType.LPStr)] string scheme);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resolve([MarshalAs(UnmanagedType.LPStruct)]nsACString relativePath, [MarshalAs(UnmanagedType.LPStruct)]nsACString resolved);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiSpec([MarshalAs(UnmanagedType.LPStruct)]nsACString spec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAsciiHost([MarshalAs(UnmanagedType.LPStruct)]nsACString spec);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOriginCharset([MarshalAs(UnmanagedType.LPStruct)]nsACString charset); 
	}
	
	[Guid("df31c120-ded6-11d1-bd85-00805f8ae3f4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEventListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent e);
	}
	
	[Guid("a66b7b80-ff46-bd97-0080-5f8ae38add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEvent
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
	}
	
	[Guid("a6cf90c3-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMUIEvent : nsIDOMEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
		
		// nsIDOMUIEvent:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAbstractView GetView();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMAbstractView viewArg, int detailArg); 
	}
	
	[Guid("028e0e6e-8b01-11d3-aae7-0010838a3123"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMKeyEvent : nsIDOMUIEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
		
		// nsIDOMUIEvent:
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAbstractView GetView();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMAbstractView viewArg, int detailArg); 
		
		// nsIDOMKeyEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetCharCode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKeyCode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAltKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCtrlKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShiftKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetMetaKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitKeyEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMAbstractView viewArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, uint keyCodeArg, uint charCodeArg); 
	}
	
	[Guid("ff751edc-8b02-aae7-0010-8301838a3123"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMMouseEvent : nsIDOMUIEvent
	{
		// nsIDOMEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetTarget();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget GetCurrentTarget();
				
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new ushort GetEventPhase();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetBubbles();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCancelable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new UInt64 GetTimeStamp(); // DOMTimeStamp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)]nsACString eventTypeArg, bool canBubbleArg, bool cancelableArg);
				
		// nsIDOMUIEvent:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new nsIDOMAbstractView GetView();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		new int GetDetail();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitUIEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMAbstractView viewArg, int detailArg); 
		
		// nsIDOMMouseEvent:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScreenX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScreenY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCtrlKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShiftKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAltKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetMetaKey();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetButton();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetRelatedTarget();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitMouseEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, bool canBubbleArg, bool cancelableArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMAbstractView viewArg, int detailArg, int screenXArg, int screenYArg, int clientXArg, int clientYArg, bool ctrlKeyArg, bool altKeyArg, bool shiftKeyArg, bool metaKeyArg, ushort buttonArg, [MarshalAs(UnmanagedType.Interface)]nsIDOMEventTarget relatedTargetArg); 
	}
	
	[Guid("a6cf906b-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMWindow
	{
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		IntPtr GetScrollbars(); // nsIDOMBarProp
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		IntPtr GetFrames(); // nsIDOMWindowCollection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetTextZoom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextZoom(float aTextZoom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollX();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollY();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollTo(int xScroll, int yScroll);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollBy(int xScrollDif, int yScrollDif);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISelection GetSelection(); // nsISelection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByLines(int numLines);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollByPages(int numPages);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SizeToContent(); 
	}


	[Guid("efff0d88-3b94-4375-bdeb-676a847ecd7d"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMWindow2 : nsIDOMWindow
	{
		// nsIDOMWindow2:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget GetWindowRoot();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		IntPtr /*nsIDOMOfflineResourceList*/ GetApplicationCache();
	
		/// <summary>
		/// Depreacated
		/// </summary>
		void CreateBlobURL(IntPtr blob, IntPtr retval);

		/// <summary>
		/// Depreacated
		/// </summary>
		void RevokeBlobURL(IntPtr URL);
	}
	
	[Guid("b2c7ed59-8634-4352-9e37-5484c8b6e4e1"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsISelection
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetAnchorNode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		int GetAnchorOffset();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetFocusNode();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetFocusOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCollapsed();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetRangeCount();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange GetRangeAt(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Collapse([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Extend([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CollapseToStart();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CollapseToEnd();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ContainsNode(nsIDOMNode node, bool partlyContained);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAllChildren([MarshalAs(UnmanagedType.Interface)]nsIDOMNode parentNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddRange([MarshalAs(UnmanagedType.Interface)]nsIDOMRange range);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveRange([MarshalAs(UnmanagedType.Interface)]nsIDOMRange range);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAllRanges();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteFromDocument();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectionLanguageChange(bool langRTL);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPWStr)] string ToString();
	}

	[Guid("7b9badc6-c9bc-447a-8670-dbd195aed24b"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMDocumentRange
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMRange CreateRange();	
	}
	
	[Guid("a6cf90ce-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMRange
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetStartContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStartOffset();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		nsIDOMNode GetEndContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndOffset();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCollapsed();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetCommonAncestorContainer();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStart([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnd([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartAfter([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndAfter([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Collapse(bool toStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNodeContents([MarshalAs(UnmanagedType.Interface)]nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short CompareBoundaryPoints(ushort how, [MarshalAs(UnmanagedType.Interface)]nsIDOMRange sourceRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ExtractContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CloneContents();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SurroundContents([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newParent);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange CloneRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Detach();
	}
	
	[Guid("a6cf906f-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMWindowCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow Item(uint index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow NamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
	
	[Guid("1c773b30-d1cf-11d2-bd95-00805f8ae3f4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMEventTarget
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEventListener([MarshalAs(UnmanagedType.LPStruct)] nsAString type, [MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener listener, bool useCapture);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool DispatchEvent([MarshalAs(UnmanagedType.Interface)]nsIDOMEvent evt);
	}
	
	static class nsIDOMNodeConstants
	{
		public const int ELEMENT_NODE = 1;
		public const int ATTRIBUTE_NODE = 2;
		public const int TEXT_NODE = 3;
		public const int CDATA_SECTION_NODE = 4;
		public const int ENTITY_REFERENCE_NODE = 5;
		public const int ENTITY_NODE = 6;
		public const int PROCESSING_INSTRUCTION_NODE = 7;
		public const int COMMENT_NODE = 8;
		public const int DOCUMENT_NODE = 9;
		public const int DOCUMENT_TYPE_NODE = 10;
		public const int DOCUMENT_FRAGMENT_NODE = 11;
		public const int NOTATION_NODE = 12;
	}
	
	[Guid("a6cf907b-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNamedNodeMap
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItem([MarshalAs(UnmanagedType.Interface)]nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItemNS([MarshalAs(UnmanagedType.Interface)]nsIDOMNode arg);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
	}
	
	/**
	 * The nsIDOMNodeList interface provides the abstraction of an ordered 
	 * collection of nodes, without defining or constraining how this collection 
	 * is implemented.
	 * The items in the list are accessible via an integral index, starting from 0.
	 *
	 * For more information on this interface please see 
	 * http://www.w3.org/TR/DOM-Level-2-Core/
	 */
	[Guid("a6cf907c-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttributes(); 
	}

	/**
	 * The nsIDOMNodeList interface provides the abstraction of an ordered 
	 * collection of nodes, without defining or constraining how this collection 
	 * is implemented.
	 * The items in the list are accessible via an integral index, starting from 0.
	 *
	 * For more information on this interface please see 
	 * http://www.w3.org/TR/DOM-Level-2-Core/
	 */
	[Guid("a6cf907d-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMNodeList
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength(); 
	}

	/**
	 * The nsIDOMAttr interface represents an attribute in an "Element" object. 
	 * Typically the allowable values for the attribute are defined in a document 
	 * type definition.
	 *
	 * For more information on this interface please see 
	 * http://www.w3.org/TR/DOM-Level-2-Core/
	 */
	[Guid("a6cf9070-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMAttr : nsIDOMNode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpecified();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetValue([MarshalAs(UnmanagedType.LPStruct)]nsAString aValue);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOwnerElement();
	}
	
	/**
	 * The nsIDOMElement interface represents an element in an HTML or 
	 * XML document. 
	 *
	 * For more information on this interface please see 
	 * http://www.w3.org/TR/DOM-Level-2-Core/
	 */
	[Guid("a6cf9078-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMElement : nsIDOMNode
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
	
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr oldAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName, [MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)]nsIDOMAttr newAttr);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName); 
	}

	/**
	 * The nsIDOMDocument interface represents the entire HTML or XML document.
	 * Conceptually, it is the root of the document tree, and provides the 
	 * primary access to the document's data.
	 * Since elements, text nodes, comments, processing instructions, etc. 
	 * cannot exist outside the context of a Document, the nsIDOMDocument 
	 * interface also contains the factory methods needed to create these 
	 * objects.
	 *
	 * For more information on this interface please see 
	 * http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html
	 */
	[Guid("a6cf9075-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMDocument : nsIDOMNode
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIDOMDocumentType GetDoctype();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetImplementation(); // nsIDOMDOMImplementation
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetDocumentElement();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateDocumentFragment(); // nsIDOMDocumentFragment
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMText
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMComment
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMCDATASection
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target,[MarshalAs(UnmanagedType.LPStruct)] nsAString data); // nsIDOMProcessingInstruction
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr CreateEntityReference([MarshalAs(UnmanagedType.LPStruct)] nsAString name); // nsIDOMEntityReference
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);

		#region DOM Level 2

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode ImportNode(nsIDOMNode importedNode, bool deep);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId);

		#endregion
	}

	/**
	 * The nsIDOMDOMConfiguration interface represents the configuration
	 * of a document and maintains a table of recognized parameters.
	 *
	 * For more information on this interface, please see
	 * http://www.w3.org/TR/DOM-Level-3-Core/
	 */
	[Guid("cfb5b821-9016-4a79-9d98-87b57c3ea0c7"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMConfiguration : nsISupports
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetParameter([MarshalAs(UnmanagedType.LPStruct)]nsAString Name, [MarshalAs(UnmanagedType.Interface)]nsIVariant value);

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsIVariant GetParameter([MarshalAs(UnmanagedType.LPStruct)]nsAString Name);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool CanSetParameter([MarshalAs(UnmanagedType.LPStruct)]nsAString name, [MarshalAs(UnmanagedType.Interface)]nsIVariant value);
	}

	static class nsIDataTypeConstants
	{
		public const int VTYPE_INT8 = 0; // TD_INT8					= 0,
		public const int VTYPE_INT16 = 1; // TD_INT16				= 1,
		public const int VTYPE_INT32 = 2; // TD_INT32				= 2,
		public const int VTYPE_INT64 = 3; // TD_INT64				= 3,
		public const int VTYPE_UINT8 = 4; // TD_UINT8				= 4,
		public const int VTYPE_UINT16 = 5; // TD_UINT16				= 5,
		public const int VTYPE_UINT32 = 6; // TD_UINT32				= 6,
		public const int VTYPE_UINT64 = 7; // TD_UINT64				= 7,
		public const int VTYPE_FLOAT = 8; // TD_FLOAT				= 8, 
		public const int VTYPE_DOUBLE = 9; // TD_DOUBLE				= 9,
		public const int VTYPE_BOOL = 10; // TD_BOOL				= 10,
		public const int VTYPE_CHAR = 11; // TD_CHAR				= 11,
		public const int VTYPE_WCHAR = 12; // TD_WCHAR				= 12,
		public const int VTYPE_VOID = 13; // TD_VOID				= 13,
		public const int VTYPE_ID = 14; // TD_PNSIID				= 14,
		public const int VTYPE_DOMSTRING = 15; // TD_DOMSTRING			= 15,
		public const int VTYPE_CHAR_STR = 16; // TD_PSTRING				= 16,
		public const int VTYPE_WCHAR_STR = 17; // TD_PWSTRING			= 17,
		public const int VTYPE_INTERFACE = 18; // TD_INTERFACE_TYPE		= 18,
		public const int VTYPE_INTERFACE_IS = 19; // TD_INTERFACE_IS_TYPE	= 19,
		public const int VTYPE_ARRAY = 20; // TD_ARRAY				= 20,
		public const int VTYPE_STRING_SIZE_IS = 21; // TD_PSTRING_SIZE_IS		= 21,
		public const int VTYPE_WSTRING_SIZE_IS = 22; // TD_PWSTRING_SIZE_IS	= 22,
		public const int VTYPE_UTF8STRING = 23; // TD_UTF8STRING			= 23,
		public const int VTYPE_CSTRING = 24; // TD_CSTRING				= 24,
		public const int VTYPE_ASTRING = 25; // TD_ASTRING				= 25,
		public const int VTYPE_EMPTY_ARRAY = 254;
		public const int VTYPE_EMPTY = 255;
	}

	[Guid("4d12e540-83d7-11d5-90ed-0010a4e73d9a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDataType : nsISupports
	{

	}

	/**
	 * XPConnect has magic to transparently convert between nsIVariant and JS types.
	 * We mark the interface [scriptable] so that JS can use methods
	 * that refer to this interface. But we mark all the methods and attributes
	 * [noscript] since any nsIVariant object will be automatically converted to a
	 * JS type anyway.
	 */
	[Guid("81e4c2de-acac-4ad6-901a-b5fb1b851a0d"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIVariant : nsISupports
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int GetDatatType();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		int GetAsInt8();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Int16 GetAsInt16();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Int32 GetAsInt32();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		Int64 GetAsInt64();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		uint GetAsUInt8();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UInt16 GetAsUInt16();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UInt32 GetAsUInt32();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		UInt64 GetAsUInt64();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		float GetAsFloat();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		double GetAsDouble();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetAsBool();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		char GetAsChar();
		//wchar GetAsWChar();
		//nsresult GetAsID();		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetAsAString([MarshalAs(UnmanagedType.LPStruct)]nsAString aString); 
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetAsDOMString([MarshalAs(UnmanagedType.LPStruct)]nsAString aString);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetAsACString([MarshalAs(UnmanagedType.LPStruct)]nsAString aString);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void GetAsAUTF8String([MarshalAs(UnmanagedType.LPStruct)]nsAUTF8String aString); 

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		string GetAsString();
		//wstring GetAsWString();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		nsISupports GetAsISupports();
		//jsval GetAsJSVal();
	}

	/**
	 * The nsIDOMHTMLElement interface is the primary [X]HTML element
	 * interface. It represents a single [X]HTML element in the document
	 * tree.
	 *
	 * This interface is trying to follow the DOM Level 2 HTML specification:
	 * http://www.w3.org/TR/DOM-Level-2-HTML/
	 *
	 * with changes from the work-in-progress WHATWG HTML specification:
	 * http://www.whatwg.org/specs/web-apps/current-work/
	 */	
	[Guid("a6cf9085-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLElement : nsIDOMElement
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetId([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetId([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLang([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLang([MarshalAs(UnmanagedType.LPStruct)] nsAString aLang);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
	}
	
	[Guid("a6cf9084-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLDocument : nsIDOMDocument
	{
		// nsIDOMNode:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeType();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature,[MarshalAs(UnmanagedType.LPStruct)] nsAString version);

		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsAString GetNamespaceURI();

		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsAString GetPrefix();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes(); 
		
		// nsIDOMDocument:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentType GetDoctype();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr GetImplementation();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetDocumentElement();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAString tagName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateDocumentFragment();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAString target,[MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new IntPtr CreateEntityReference([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString tagname);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ImportNode([MarshalAs(UnmanagedType.Interface)]nsIDOMNode importedNode, bool deep);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI,[MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAString elementId);

		// nsIDOMHTMLDocument:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8String aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrer([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetURL([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLElement GetBody();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBody([MarshalAs(UnmanagedType.Interface)]nsIDOMHTMLElement aBody);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetImages();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetApplets();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetLinks();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetForms();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLCollection GetAnchors();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCookie([MarshalAs(UnmanagedType.LPStruct)] nsAString aCookie);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCookie([MarshalAs(UnmanagedType.LPStruct)]nsAString aCookie);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Open();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Write([MarshalAs(UnmanagedType.LPStruct)] nsAString text);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Writeln([MarshalAs(UnmanagedType.LPStruct)] nsAString text);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByName([MarshalAs(UnmanagedType.LPStruct)] nsAString elementName);
	}
	
	[Guid("a6cf9077-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIDOMDocumentType : nsIDOMNode
	{		
		#region nsIDOMNode

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void GetNodeName([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void GetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void SetNodeValue([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new ushort GetNodeType();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNode();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodes();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChild();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChild();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSibling();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSibling();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributes();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocument();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode refChild);

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode oldChild);

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)]nsIDOMNode newChild);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new bool HasChildNodes();

		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(bool deep);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void Normalize();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);

		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsAString GetNamespaceURI();

		[return: MarshalAs(UnmanagedType.LPStruct)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new nsAString GetPrefix();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void SetPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new void GetLocalName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		new bool HasAttributes(); 

		#endregion

		#region nsIDOMDocumentType
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetName([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetEntities();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNamedNodeMap GetNotations();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPublicId([MarshalAs(UnmanagedType.LPStruct)] nsAString aPublicId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSystemId([MarshalAs(UnmanagedType.LPStruct)] nsAString aSystemId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInternalSubset([MarshalAs(UnmanagedType.LPStruct)] nsAString aInternalSubset);

		#endregion
	}
	
	[Guid("a6cf9083-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLCollection
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(int index);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode NamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}

	[Guid("f0ffe1d2-9615-492b-aae1-05428ebc2a70"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMNSHTMLElement
	{		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOffsetHeight();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetOffsetParent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetInnerHTML([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInnerHTML([MarshalAs(UnmanagedType.LPStruct)] nsAString aInnerHTML);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetHidden();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetHidden(bool hidden);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetTabIndex();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTabIndex(int aTabIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentEditable([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentEditable([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentEditable);

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		bool GetDraggable();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetDraggable(bool draggable);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollIntoView(bool top);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSpellcheck();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpellcheck(bool aSpellcheck);
	}

	
	[Guid("3d9f4973-dd2e-48f5-b5f7-2634e09eadd9"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMDocumentStyle
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheetList GetStyleSheets();
	}
	
	[Guid("a6cf9081-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMStyleSheetList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet Item(int index);
	}
	
	[Guid("a6cf9080-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMStyleSheet
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabled(bool aDisabled);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetOwnerNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet GetParentStyleSheet();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
	}
	
	[Guid("9b0c2ed7-111c-4824-adf9-ef0da6dad371"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMMediaList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMediaText([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMediaText([MarshalAs(UnmanagedType.LPStruct)] nsAString aMediaText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Item(int index,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString oldMedium);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendMedium([MarshalAs(UnmanagedType.LPStruct)] nsAString newMedium);
	}
	
	[Guid("a6cf90c2-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleSheet
	{
		// nsIDOMStyleSheet:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetType([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDisabled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisabled(bool aDisabled);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetOwnerNode();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMStyleSheet GetParentStyleSheet();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString aHref);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
		
		// nsIDOMCSSStyleSheet:
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetOwnerRule();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int GetCssRules([MarshalAs(UnmanagedType.Interface)]out nsIDOMCSSRuleList ret); // 0x8053000F
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int InsertRule([MarshalAs(UnmanagedType.LPStruct)] nsAString rule, int index, out int result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteRule(int index);
	}
	
	[Guid("a6cf90c1-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSRule
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
	}
	
	[Guid("a6cf90bf-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleRule : nsIDOMCSSRule
	{
		// nsIDOMCSSRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCSSRule GetParentRule();

		// nsIDOMCSSStyleRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSelectorText([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectorText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectorText([MarshalAs(UnmanagedType.LPStruct)] nsAString aSelectorText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleDeclaration GetStyle();
	}
	
	[Guid("a6cf90cf-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSImportRule
	{
		// nsIDOMCSSRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetParentStyleSheet();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
		
		// nsIDOMCSSImportRule:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHref([MarshalAs(UnmanagedType.LPStruct)] nsAString str);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMMediaList GetMedia();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleSheet GetStyleSheet();
	}
	
	[Guid("a6cf90c0-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSRuleList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule Item(int index);
	}
	
	[Guid("a6cf90be-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSStyleDeclaration
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyValue([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSValue GetPropertyCSSValue([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyPriority([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString propertyName,[MarshalAs(UnmanagedType.LPStruct)] nsAString value,[MarshalAs(UnmanagedType.LPStruct)] nsAString priority);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLength();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Item(int index,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSRule GetParentRule();
	}
	
	[Guid("009f7ea5-9e80-41be-b008-db62f10823f2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSSValue
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssText([MarshalAs(UnmanagedType.LPStruct)] nsAString aCssText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetCssValueType();
	}
	
	class PRUnicharMarshaler : ICustomMarshaler
	{
		public static ICustomMarshaler GetInstance(string cookie)
		{
			return (_Instance == null) ? (_Instance = new PRUnicharMarshaler()) : _Instance;
		}
		static PRUnicharMarshaler _Instance;
		
		public void CleanUpManagedData(object ManagedObj) { }
		public void CleanUpNativeData(IntPtr pNativeData) { }
		public int GetNativeDataSize() { return 0; }

		public IntPtr MarshalManagedToNative(object ManagedObj)
		{
			byte [] bytes = Encoding.Unicode.GetBytes(ManagedObj.ToString() + "\0");
			IntPtr alloc = Xpcom.Alloc(bytes.Length + 2);
			Marshal.Copy(bytes, 0, alloc, bytes.Length);
			return alloc;
		}

		public object MarshalNativeToManaged(IntPtr pNativeData)
		{
			return Marshal.PtrToStringUni(pNativeData);
		}
	}
	
	#if !NO_CUSTOM_PROMPT_SERVICE
	[Guid("1630c61a-325e-49ca-8759-a31b16c47aa5"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPromptService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Alert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] void AlertCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Confirm([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] bool ConfirmCheck(nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		int ConfirmEx([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aButtonFlags, [MarshalAs(UnmanagedType.LPWStr)] string aButton0Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton1Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton2Title, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, out bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Prompt([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aValue, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		//[PreserveSig] int Prompt(IntPtr aParent, IntPtr aDialogTitle, IntPtr aText, IntPtr aValue, IntPtr aCheckMsg, IntPtr aCheckState, out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Select([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aCount, IntPtr aSelectList, out int aOutSelection);
	}
	
	static class nsIPromptServiceConstants
	{
		public const int BUTTON_POS_0 = 1;
		public const int BUTTON_POS_1 = 256;
		public const int BUTTON_POS_2 = 65536;

		public const int BUTTON_TITLE_OK = 1;
		public const int BUTTON_TITLE_CANCEL = 2;
		public const int BUTTON_TITLE_YES = 3;
		public const int BUTTON_TITLE_NO = 4;
		public const int BUTTON_TITLE_SAVE = 5;
		public const int BUTTON_TITLE_DONT_SAVE = 6;
		public const int BUTTON_TITLE_REVERT = 7;
		public const int BUTTON_TITLE_IS_STRING = 127;

		public const int BUTTON_POS_0_DEFAULT = 0;
		public const int BUTTON_POS_1_DEFAULT = 16777216;
		public const int BUTTON_POS_2_DEFAULT = 33554432;
		
		public const int BUTTON_DELAY_ENABLE = 67108864;
		public const int STD_OK_CANCEL_BUTTONS = 513;
		public const int STD_YES_NO_BUTTONS = 1027;
	}
	
	[Guid("e800ef97-ae37-46b7-a46c-31fbe79657ea"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsINonBlockingAlertService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowNonBlockingAlert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
	}

	[Guid("cf86d196-dbee-4482-9dfa-3477aa128319"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPromptService2 : nsIPromptService
	{
		// nsIPromptService:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Alert([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] new void AlertCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Confirm([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] new bool ConfirmCheck([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, ref bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int ConfirmEx([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aButtonFlags, [MarshalAs(UnmanagedType.LPWStr)] string aButton0Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton1Title, [MarshalAs(UnmanagedType.LPWStr)] string aButton2Title, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, out bool aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Prompt([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aValue, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptUsernameAndPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aUsername, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool PromptPassword([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(PRUnicharMarshaler))] ref string aPassword, [MarshalAs(UnmanagedType.LPWStr)] string aCheckMsg, IntPtr aCheckState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Select([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, [MarshalAs(UnmanagedType.LPWStr)] string aDialogTitle, [MarshalAs(UnmanagedType.LPWStr)] string aText, uint aCount, IntPtr aSelectList, out int aOutSelection);

		// nsIPromptService2:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PromptAuth([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aParent, IntPtr aChannel, int level, nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.LPWStr)] string checkboxLabel, IntPtr checkValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsICancelable AsyncPromptAuth(nsIDOMWindow aParent, IntPtr aChannel, nsIAuthPromptCallback aCallback, nsISupports aContext, uint level, nsIAuthInformation authInfo, [MarshalAs(UnmanagedType.LPWStr)] string checkboxLabel, IntPtr checkValue);
	}
	
	[Guid("0d73639c-2a92-4518-9f92-28f71fea5f20"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAuthInformation
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlags();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRealm([MarshalAs(UnmanagedType.LPStruct)] nsAString aRealm);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAuthenticationScheme([MarshalAs(UnmanagedType.LPStruct)]nsACString aAuthenticationScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUsername([MarshalAs(UnmanagedType.LPStruct)] nsAString aUsername);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPassword([MarshalAs(UnmanagedType.LPStruct)] nsAString aPassword);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDomain([MarshalAs(UnmanagedType.LPStruct)] nsAString aDomain);
	}
	
	[Guid("bdc387d7-2d29-4cac-92f1-dd75d786631d"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAuthPromptCallback
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthAvailable([MarshalAs(UnmanagedType.Interface)]nsISupports aContext, [MarshalAs(UnmanagedType.Interface)]nsIAuthInformation aAuthInfo);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnAuthCancelled([MarshalAs(UnmanagedType.Interface)]nsISupports aContext, bool userCancel);
	}
	
	[Guid("d94ac0a0-bb18-46b8-844e-84159064b0bd"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICancelable
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel(int aReason);
	}
	
	#endif
	
	[Guid("decb9cc7-c08f-4ea5-be91-a8fc637ce2d2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrefService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadUserPrefs([MarshalAs(UnmanagedType.Interface)]nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetUserPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SavePrefFile([MarshalAs(UnmanagedType.Interface)]nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsIPrefBranch GetBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.Interface)]
		nsIPrefBranch GetDefaultBranch([MarshalAs(UnmanagedType.LPStr)] string aPrefRoot);
	}
	
	[Guid("56c35506-f14b-11d3-99d3-ddbfac2ccf65"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrefBranch
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetRoot();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrefType([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBoolPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, [MarshalAs(UnmanagedType.LPStr)] string aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIntPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName, int aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, IntPtr aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetComplexValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName, ref Guid aType, nsISupports aValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearUserPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefIsLocked([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnlockPref([MarshalAs(UnmanagedType.LPStr)] string aPrefName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetChildList([MarshalAs(UnmanagedType.LPStr)] string aStartingAt, out uint aCount, [MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.LPStr)] string [] aChildArray);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetBranch([MarshalAs(UnmanagedType.LPStr)] string aStartingAt);
	}
	
	[Guid("00000001-0000-0000-c000-000000000046"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIFactory
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateInstance([MarshalAs(UnmanagedType.Interface)]nsISupports aOuter, ref Guid iid, [MarshalAs(UnmanagedType.IUnknown)] out object result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LockFactory(bool @lock);
	}
	
	[Guid("2417cbfe-65ad-48a6-b4b6-eb84db174392"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIComponentRegistrar
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoRegister(IntPtr aSpec); // nsIFile
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AutoUnregister(IntPtr aSpec); // nsIFile
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactory(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, nsIFactory aFactory);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactory(ref Guid aClass, nsIFactory aFactory);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterFactoryLocation(ref Guid aClass, [MarshalAs(UnmanagedType.LPStr)] string aClassName, [MarshalAs(UnmanagedType.LPStr)] string aContractID, IntPtr aFile, [MarshalAs(UnmanagedType.LPStr)] string aLoaderStr, [MarshalAs(UnmanagedType.LPStr)] string aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterFactoryLocation(ref Guid aClass, IntPtr aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCIDRegistered(ref Guid aClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsContractIDRegistered([MarshalAs(UnmanagedType.LPStr)] string aContractID);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr EnumerateCIDs(); // nsISimpleEnumerator
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr EnumerateContractIDs(); // nsISimpleEnumerator
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string CIDToContractID(ref Guid aClass);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] void ContractIDToCID([MarshalAs(UnmanagedType.LPStr)] string aContractID, out Guid cid);
	}
	
	[Guid("57a66a60-d43a-11d3-8cc2-00609792278c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDirectoryService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterProvider(nsIDirectoryServiceProvider provider);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UnregisterProvider(nsIDirectoryServiceProvider provider);
	}
	
	[Guid("bbf8cab0-d43a-11d3-8cc2-00609792278c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDirectoryServiceProvider
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetFile([MarshalAs(UnmanagedType.LPStr)] string prop, out bool persistent);
	}
	
	[Guid("78650582-4e93-4b60-8e85-26ebd3eb14ca"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIProperties
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr Get([MarshalAs(UnmanagedType.LPStr)] string prop, ref Guid iid);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Set([MarshalAs(UnmanagedType.LPStr)] string prop, nsISupports value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Has([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Undefine([MarshalAs(UnmanagedType.LPStr)] string prop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void STUB_GetKeys();
	}
	
	[Guid("c8c0a080-0868-11d3-915f-d9d889d48e3c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIFile
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Append([MarshalAs(UnmanagedType.LPStruct)] nsAString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendNative([MarshalAs(UnmanagedType.LPStruct)]nsACString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create(uint type, uint permissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove(bool recursive);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissions();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissions(uint aPermissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissionsOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissionsOfLink(uint aPermissionsOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTime();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTime(long aLastModifiedTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTimeOfLink(long aLastModifiedTimeOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileSize(long aFileSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSizeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTarget([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeTarget([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPath([MarshalAs(UnmanagedType.LPStruct)] nsAString aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Exists();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWritable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsReadable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsExecutable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsHidden();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDirectory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSymlink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSpecial();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateUnique(uint type, uint permissions);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals(nsIFile inFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Contains(nsIFile inFile, bool recur);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDirectoryEntries();
	}
	
	[Guid("aa610f20-a889-11d3-8c81-000064657374"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsILocalFile : nsIFile
	{
		// nsIFile:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Append([MarshalAs(UnmanagedType.LPStruct)]nsAString node);
				
		new void AppendNative([MarshalAs(UnmanagedType.LPStruct)]nsACString node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Create(uint type, uint permissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLeafName([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNativeLeafName([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveTo([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir,[MarshalAs(UnmanagedType.LPStruct)] nsAString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MoveToNative([MarshalAs(UnmanagedType.Interface)]nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)]nsACString newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Remove(bool recursive);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetPermissions();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissions(uint aPermissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetPermissionsOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPermissionsOfLink(uint aPermissionsOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetLastModifiedTime();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTime(long aLastModifiedTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetLastModifiedTimeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetLastModifiedTimeOfLink(long aLastModifiedTimeOfLink);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetFileSize();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetFileSize(long aFileSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new long GetFileSizeOfLink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTarget([MarshalAs(UnmanagedType.LPStruct)] nsAString aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativeTarget([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativeTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPath([MarshalAs(UnmanagedType.LPStruct)] nsAString aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString aNativePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Exists();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsWritable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsReadable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsExecutable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsHidden();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDirectory();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSymlink();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSpecial();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CreateUnique(uint type, uint permissions);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Equals([MarshalAs(UnmanagedType.Interface)]nsIFile inFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)]nsIFile inFile, bool recur);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIFile GetParent();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISimpleEnumerator GetDirectoryEntries();

		// nsILocalFile:
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithPath([MarshalAs(UnmanagedType.LPStruct)] nsAString filePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString filePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void InitWithFile(nsILocalFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFollowLinks();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFollowLinks(bool aFollowLinks);
		//PRFileDesc OpenNSPRFileDesc(int flags, int mode);
		//FILE OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);
		//PRLibrary Load();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr OpenNSPRFileDesc(int flags, int mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr Load();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDiskSpaceAvailable();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativePath([MarshalAs(UnmanagedType.LPStruct)] nsAString relativeFilePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)]nsACString relativeFilePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistentDescriptor([MarshalAs(UnmanagedType.LPStruct)]nsACString aPersistentDescriptor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistentDescriptor([MarshalAs(UnmanagedType.LPStruct)]nsACString aPersistentDescriptor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reveal();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Launch();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)]nsILocalFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)]nsILocalFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACString relativeDesc);
	}
	
	[Guid("bddeda3f-9020-4d12-8c70-984ee9f7935e"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIIOService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] string aScheme); // nsIProtocolHandler
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewURI(nsACString aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, [MarshalAs(UnmanagedType.Interface)]nsIURI aBaseURI);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewFileURI(nsIFile aFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr NewChannelFromURI(nsIURI aURI); // returns: nsIChannel
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr NewChannel(nsACString aSpec, [MarshalAs(UnmanagedType.LPStr)] string aOriginCharset, nsIURI aBaseURI); // returns: nsIChannel
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOffline();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOffline(bool aOffline);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowPort(int aPort, [MarshalAs(UnmanagedType.LPStr)] string aScheme);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsACString urlString, [MarshalAs(UnmanagedType.LPStruct)] nsACString _retval);
	}
	
	[Guid("b8100c90-73be-11d2-92a5-00105a1b0d64"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIClipboardCommands
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCutSelection(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopySelection(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyLinkLocation(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyImageLocation(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanCopyImageContents(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[PreserveSig] int CanPaste(out bool result);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CutSelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopySelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyLinkLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyImageLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyImageContents();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Paste();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAll();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNone();
	}
	
	[Guid("080d2001-f91e-11d4-a73c-f9242928207c"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICommandManager
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddCommandObserver(nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandToObserve);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveCommandObserver(nsIObserver aCommandObserver, [MarshalAs(UnmanagedType.LPStr)] string aCommandObserved);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandSupported([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandState([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsIDOMWindow aTargetWindow, nsICommandParams aCommandParams);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand([MarshalAs(UnmanagedType.LPStr)] string aCommandName, nsICommandParams aCommandParams, nsIDOMWindow aTargetWindow);
	}
	
	[Guid("83f892cf-7ed3-490e-967a-62640f3158e1"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsICommandParams
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetValueType([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLongValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStringValue([MarshalAs(UnmanagedType.LPStr)] string name,[MarshalAs(UnmanagedType.LPStruct)] nsAString _retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBooleanValue([MarshalAs(UnmanagedType.LPStr)] string name, bool value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLongValue([MarshalAs(UnmanagedType.LPStr)] string name, int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDoubleValue([MarshalAs(UnmanagedType.LPStr)] string name, double value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStringValue([MarshalAs(UnmanagedType.LPStr)] string name,[MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCStringValue([MarshalAs(UnmanagedType.LPStr)] string name, [MarshalAs(UnmanagedType.LPStr)] string value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetISupportsValue([MarshalAs(UnmanagedType.LPStr)] string name, nsISupports value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveValue([MarshalAs(UnmanagedType.LPStr)] string name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasMoreElements();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void First();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		[return: MarshalAs(UnmanagedType.LPStr)] string GetNext();
	}
	
	[Guid("44b78386-1dd2-11b2-9ad2-e4eee2ca1916"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsITooltipListener
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnShowTooltip(int aXCoords, int aYCoords, [MarshalAs(UnmanagedType.LPWStr)] string aTipText);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHideTooltip();
	}
	
	[Guid("fa9c7f6c-61b3-11d4-9877-00c04fa0cf4a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIInputStream
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Available();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Read(IntPtr aBuf, uint aCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int ReadSegments(IntPtr aWriter, IntPtr aClosure, uint aCount);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		bool IsNonBlocking();
	}
	
	delegate int nsWriteSegmentFun(nsIInputStream aInStream, IntPtr aClosure, IntPtr aFromSegment, int aToOffset, int aCount, out int aWriteCount);
	
	//[Guid("b128a1e6-44f3-4331-8fbe-5af360ff21ee"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	//interface nsITooltipTextProvider
	//{
	//      bool GetNodeText(nsIDOMNode aNode, [MarshalAs(UnmanagedType.LPWStr)] out string aText);
	//}
	
	// 1.9.2
	[Guid("533a8131-8d0c-4ebf-990b-7fad7cd514ee"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMNSDocument
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharacterSet([MarshalAs(UnmanagedType.LPStruct)] nsAString aCharacterSet);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDir([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetLocation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.LPStruct)] nsAString aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContentType([MarshalAs(UnmanagedType.LPStruct)] nsAString aContentType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLastModified([MarshalAs(UnmanagedType.LPStruct)] nsAString aLastModified);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReferrer([MarshalAs(UnmanagedType.LPStruct)] nsAString aReferrer);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		IntPtr GetBoxObjectFor([MarshalAs(UnmanagedType.Interface)]nsIDOMElement elt);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasFocus();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetActiveElement();
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		[return: MarshalAs(UnmanagedType.Interface)] 
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement ElementFromPoint(int x, int y);
	}

	[Guid("D894B5D4-44F3-422A-A220-7763C12D4A94"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMNSElement
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAString classes);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRectList GetClientRects();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRect GetBoundingClientRect();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollTop(int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScrollLeft(int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetScrollWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetClientWidth();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetFirstElementChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetLastElementChild();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetPreviousElementSibling();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetNextElementSibling();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetChildElementCount();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetChildren();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		/* nsIDOMDOMTokenList */ IntPtr GetClassList();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void SetCapture(bool retargetToElement);

		/**
		* If this element has captured the mouse, release the capture. If another
		* element has captured the mouse, this method has no effect.
		*/
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		void ReleaseCapture();

		 /**
		* Returns whether this element would be selected by the given selector
		* string.
		*
		* See <http://dev.w3.org/2006/webapi/selectors-api2/>
		*/
		bool MozMatchesSelector([MarshalAs(UnmanagedType.LPStruct)] nsAString selector);
	}


	[Guid("f8583bbc-c6de-4646-b39f-df7e766442e9"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMClientRect
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetBottom();
	}
	
	[Guid("917da19d-62f5-441d-b47e-9e35f05639c9"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMClientRectList
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetLength();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMClientRect Item(int index);
	}
	
	[Guid("75d1553d-63bf-4b5d-a8f7-e4e4cac21ba4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrintingPromptService
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrintDialog([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)]nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowProgress([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)] nsIWebBrowserPrint webBrowserPrint, [MarshalAs(UnmanagedType.Interface)] nsIPrintSettings printSettings, nsIObserver openDialogObserver, bool isForPrinting, [MarshalAs(UnmanagedType.Interface)] out nsIWebProgressListener webProgressListener, [MarshalAs(UnmanagedType.Interface)] out nsIPrintProgressParams printProgressParams, bool notifyOnOpen);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPageSetup([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings, [MarshalAs(UnmanagedType.Interface)]nsIObserver aObs);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowPrinterProperties([MarshalAs(UnmanagedType.Interface)]nsIDOMWindow parent, [MarshalAs(UnmanagedType.LPWStr)] string printerName, [MarshalAs(UnmanagedType.Interface)]nsIPrintSettings printSettings);
	}
	
	[Guid("ca89b55b-6faf-4051-9645-1c03ef5108f8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIPrintProgressParams
	{
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetDocTitle();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocTitle([MarshalAs(UnmanagedType.LPWStr)] string aDocTitle);
				
		[return: MarshalAs(UnmanagedType.LPWStr)] string GetDocURL();
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURL([MarshalAs(UnmanagedType.LPWStr)] string aDocURL);

	}
	
	[Guid("9a7ca4b0-fbba-11d4-a869-00105a183419"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWebBrowserPrint
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetGlobalPrintSettings();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings GetCurrentPrintSettings();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow GetCurrentChildDOMWindow();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrint();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDoingPrintPreview();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetDocument();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsFramesetFrameSelected();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsIFrameSelected();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsRangeSelection();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintPreviewNumPages();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)]nsIWebProgressListener aWPListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreview([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)]nsIDOMWindow aChildDOMWin, [MarshalAs(UnmanagedType.Interface)]nsIWebProgressListener aWPListener);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreviewNavigate(short aNavType, int aPageNum);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EnumerateDocumentNames(out uint aCount, IntPtr aResult);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitPrintPreview();
	}
	
	[Guid("2f977d52-5485-11d4-87e2-0010a4e75ef2"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIPrintSession
	{
	}
	
	[Guid("5af07661-6477-4235-8814-4a45215855b8"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface nsIPrintSettings
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintOptions(int aType, bool aTurnOnOff);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintOptions(int aType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintOptionsBits();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEffectivePageSize(out double aWidth, double aHeight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings Clone();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Assign([MarshalAs(UnmanagedType.Interface)]nsIPrintSettings aPS);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSession GetPrintSession();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSession([MarshalAs(UnmanagedType.Interface)]nsIPrintSession aPrintSession);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		int GetStartPageRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartPageRange(int aStartPageRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndPageRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetEndPageRange(int aEndPageRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeTop(double aEdgeTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeLeft(double aEdgeLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeBottom(double aEdgeBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetEdgeRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeRight(double aEdgeRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginTop(double aMarginTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginLeft(double aMarginLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginBottom(double aMarginBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetMarginRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginRight(double aMarginRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginTop();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginTop(double aUnwriteableMarginTop);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginLeft(double aUnwriteableMarginLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginBottom();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginBottom(double aUnwriteableMarginBottom);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetUnwriteableMarginRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginRight(double aUnwriteableMarginRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetScaling();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetScaling(double aScaling);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintBGColors();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGColors(bool aPrintBGColors);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintBGImages();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintBGImages(bool aPrintBGImages);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintRange(short aPrintRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitle();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle( string aTitle);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetDocURL();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocURL( string aDocURL);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrLeft( string aHeaderStrLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrCenter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrCenter( string aHeaderStrCenter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetHeaderStrRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeaderStrRight( string aHeaderStrRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrLeft();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrLeft( string aFooterStrLeft);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrCenter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrCenter( string aFooterStrCenter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetFooterStrRight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFooterStrRight( string aFooterStrRight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetHowToEnableFrameUI();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHowToEnableFrameUI(short aHowToEnableFrameUI);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsCancelled();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsCancelled(bool aIsCancelled);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameTypeUsage();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameTypeUsage(short aPrintFrameTypeUsage);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPrintFrameType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintFrameType(short aPrintFrameType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintSilent();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintSilent(bool aPrintSilent);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShrinkToFit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShrinkToFit(bool aShrinkToFit);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetShowPrintProgress();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetShowPrintProgress(bool aShowPrintProgress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPaperName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperName( string aPaperName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeType();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperSizeType(short aPaperSizeType);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperData();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperData(short aPaperData);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperWidth();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperWidth(double aPaperWidth);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetPaperHeight();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPaperHeight(double aPaperHeight);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetPaperSizeUnit();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaperSizeUnit(short aPaperSizeUnit);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		string GetPlexName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPlexName( string aPlexName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		string GetColorspace();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColorspace( string aColorspace);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetResolutionName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetResolutionName( string aResolutionName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetDownloadFonts();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetDownloadFonts(bool aDownloadFonts);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintReversed();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintReversed(bool aPrintReversed);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintInColor();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintInColor(bool aPrintInColor);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetOrientation();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrientation(int aOrientation);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrintCommand();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintCommand( string aPrintCommand);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetNumCopies();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNumCopies(int aNumCopies);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetPrinterName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrinterName( string aPrinterName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetPrintToFile();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]		
		void SetPrintToFile(bool aPrintToFile);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetToFileName();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetToFileName( string aToFileName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetOutputFormat();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutputFormat(short aOutputFormat);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPrintPageDelay();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrintPageDelay(int aPrintPageDelay);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInitializedFromPrinter();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrinter(bool aIsInitializedFromPrinter);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetIsInitializedFromPrefs();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsInitializedFromPrefs(bool aIsInitializedFromPrefs);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginInTwips(ref nsMargin aMargin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEdgeInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginInTwips(ref nsMargin aMargin);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEdgeInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupSilentPrinting();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnwriteableMarginInTwips(ref nsMargin aEdge);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUnwriteableMarginInTwips(ref nsMargin aEdge);
	}
	
	public struct nsMargin
	{
	}

	[Guid("ab3725b8-3fca-40cc-a42c-92fb154ef01d"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerMessagePort : nsISupports
	{
		void PostMessage();
	}

	[Guid("508f2d49-e9a0-4fe8-bd33-321820173b4a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerMessageEvent : nsIDOMEvent
	{
		void GetData(nsAString aData);
		void GetOrigin(nsAString aOrigin);
		void GetSource(nsISupports aSource);

		void InitMessageEvent(nsAString aTypeArg, bool aCanBubbleArg, bool aCancelableArg, nsAString aDataArg, nsAString aOriginArg, nsISupports aSourceArg);
	}

	[Guid("73d82c1d-05de-49c9-a23b-7121ff09a67a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerErrorEvent : nsIDOMEvent
	{
		void GetMessage(nsAString aMessage);
		void GetFilename(nsAString aFilename);
		void GetLineNo(nsAString aLineNo);

		void InitErrorEvent(nsAString aTypeArg, bool aCanBubbleArg, bool aCancelableArg, nsAString aMessageArg, nsAString aFilenameArg, long aLineNoArg);
	}

	[Guid("17a005c3-4f2f-4bb6-b169-c181fa6873de"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerLocation : nsISupports
	{
		void GetHref(nsAUTF8String aHref);
		void GetProtocol(nsAUTF8String aProtocol);
		void GetHost(nsAUTF8String aHost);
		void GetHostname(nsAUTF8String aHostname);
		void GetPort(nsAUTF8String aPort);
		void GetPathname(nsAUTF8String aPathname);
		void GetSearch(nsAUTF8String aSearch);
		void GetHash(nsAUTF8String aHash);

		void ToString(nsAUTF8String _retval);
	}

	[Guid("74fb665a-e477-4ce2-b3c6-c58b1b28b6c3"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerNavigator : nsISupports
	{
		void GetAppName(nsAString aAppName);
		void GetAppVersion(nsAString aAppVersion);
		void GetPlatform(nsAString aPlatform);
		void GetUserAgent(nsAString aUserAgent);
	}

	[Guid("c111e7d3-8044-4458-aa7b-637696ffb841"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerGlobalScope : nsISupports
	{
		void GetSelf(nsIWorkerGlobalScope aSelf);
		void GetNavigator(nsIWorkerNavigator aNavigator);
		void GetLocation(nsIWorkerLocation aLocation);

		void GetOnError(nsIDOMEventListener aOnError);
		void SetOnError(nsIDOMEventListener aOnError);
	}

	[Guid("5c55ea4b-e4ac-4ceb-bfeb-46bd5e521b8a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerScope : nsIWorkerGlobalScope
	{
		void PostMessage();
		void Close();

		void GetOnMessage(nsIDOMEventListener aOnMessage);
		void SetOnMessage(nsIDOMEventListener aOnMessage);

		void GetOnClose(nsIDOMEventListener aOnClose);
		void SetOnClose(nsIDOMEventListener aOnClose);
	}

	[Guid("b90b7561-b5e2-4545-84b0-280dbaaa94ea"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIAbstractWorker : nsIDOMEventTarget
	{
		void GetOnError(nsIDOMEventListener aOnError);
		void SetOnError(nsIDOMEventListener aOnError);
	}

	[Guid("daf945c3-8d29-4724-8939-dd383f7d27a7"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorker : nsIAbstractWorker
	{
		void PostMessage();

		void GetOnMessage(nsIDOMEventListener aOnMessage);
		void SetOnMessage(nsIDOMEventListener aOnMessage);

		void Terminate();
	}

	[Guid("cfc4bb32-ca83-4d58-9b6f-66f8054a333a"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIWorkerFactory : nsISupports
	{
		void NewCromeWorker(nsIWorker _retval);
	}

	[Guid("c43448db-0bab-461d-b648-1ca14a967f7e"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMTimeRanges : nsISupports
	{
		void GetLength(long aLength);

		double Start(long Index);

		double End(long Index);
	}
	
	[Guid("0b9341f3-95d4-4fa4-adcd-e119e0db2889"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMViewCSS : nsIDOMAbstractView
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAbstractView GetDocument();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleDeclaration GetComputedStyle([MarshalAs(UnmanagedType.Interface)] nsIDOMElement element, [MarshalAs(UnmanagedType.LPStruct)] nsAString pseudoElt);
	}

	[Guid("1ACDB2BA-1DD2-11B2-95BC-9542495D2569"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMDocumentView
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAbstractView GetDefaultView();
	}

	[Guid("F51EBADE-8B1A-11D3-AAE7-0010830123B4"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMAbstractView
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMAbstractView GetDocument();
	}

	[Guid("99715845-95fc-4a56-aa53-214b65c26e22"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMElementCSSInlineStyle
	{
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMCSSStyleDeclaration GetStyle();
	}

	[Guid("529b987a-cb21-4d58-99d7-9586e7662801"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMCSS2Properties
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAzimuth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAzimuth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackground([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackground([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundAttachment([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundAttachment([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundImage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundImage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundPosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundPosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBackgroundRepeat([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBackgroundRepeat([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorder([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorder([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderCollapse([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderCollapse([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderTopColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderTopColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderRightColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderRightColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderBottomColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderBottomColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderLeftColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderLeftColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderTopStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderTopStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderRightStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderRightStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderBottomStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderBottomStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderLeftStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderLeftStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderTopWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderTopWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderRightWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderRightWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderBottomWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderBottomWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderLeftWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderLeftWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBorderWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBorderWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCaptionSide([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaptionSide([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClear([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClear([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClip([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClip([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContent([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContent([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCounterIncrement([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCounterIncrement([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCounterReset([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCounterReset([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCue([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCue([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCueAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCueAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCueBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCueBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCursor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCursor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDirection([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDirection([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDisplay([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplay([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetElevation([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetElevation([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetEmptyCells([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEmptyCells([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCssFloat([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCssFloat([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFont([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFont([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontFamily([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontFamily([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontSize([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontSize([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontSizeAdjust([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontSizeAdjust([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontStretch([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontStretch([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontVariant([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontVariant([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFontWeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFontWeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLetterSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLetterSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLineHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLineHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListStyleImage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListStyleImage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListStylePosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListStylePosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetListStyleType([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListStyleType([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMargin([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMargin([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarginLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarginLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarkerOffset([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarkerOffset([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMarks([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMarks([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMaxHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMaxWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMinHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinHeight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMinWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrphans([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrphans([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOutline([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutline([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOutlineColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutlineColor([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOutlineStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutlineStyle([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOutlineWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOutlineWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOverflow([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOverflow([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPadding([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPadding([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPaddingTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaddingTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPaddingRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaddingRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPaddingBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaddingBottom([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPaddingLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPaddingLeft([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPage([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageBreakAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageBreakAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageBreakBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageBreakBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPageBreakInside([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPageBreakInside([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPause([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPause([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPauseAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPauseAfter([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPauseBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPauseBefore([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPitch([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPitch([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPitchRange([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPitchRange([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPosition([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetQuotes([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetQuotes([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRichness([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRichness([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRight([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSize([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSize([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpeak([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeak([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpeakHeader([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeakHeader([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpeakNumeral([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeakNumeral([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpeakPunctuation([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeakPunctuation([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSpeechRate([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSpeechRate([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStress([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStress([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTableLayout([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTableLayout([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextAlign([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextAlign([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextDecoration([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextDecoration([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextIndent([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextIndent([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextShadow([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextShadow([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextTransform([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextTransform([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTop([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUnicodeBidi([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUnicodeBidi([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVerticalAlign([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVerticalAlign([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVisibility([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibility([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVoiceFamily([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVoiceFamily([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVolume([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVolume([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWhiteSpace([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWhiteSpace([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWidows([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWidows([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWidth([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWordSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWordSpacing([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetZIndex([MarshalAs(UnmanagedType.LPStruct)]nsAString s);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetZIndex([MarshalAs(UnmanagedType.LPStruct)]nsAString s);		
	}
}
