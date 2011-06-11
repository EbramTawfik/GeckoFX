// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIBrowserDOMWindow.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The C++ source has access to the browser script source through
    /// nsIBrowserDOMWindow. It is intended to be attached to the chrome DOMWindow
    /// of a toplevel browser window (a XUL window). A DOMWindow that does not
    /// happen to be a browser chrome window will simply have no access to any such
    /// interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3ab89888-eb41-4dc8-b347-115555f47c80")]
	public interface nsIBrowserDOMWindow
	{
		
		/// <summary>
        /// Load a URI
        /// @param aURI the URI to open. null is allowed.  If null is passed in, no
        /// load will be done, though the window the load would have
        /// happened in will be returned.
        /// @param aWhere see possible values described above.
        /// @param aOpener window requesting the open (can be null).
        /// @param aContext the context in which the URI is being opened. This
        /// is used only when aWhere == OPEN_DEFAULTWINDOW.
        /// @return the window into which the URI was opened.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow OpenURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aOpener, short aWhere, short aContext);
		
		/// <summary>
        /// As above, but return the nsIFrameLoaderOwner for the new window.
        ///   // XXXbz is this the right API? Do we really need the opener here?
        ///   // See bug 537428
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OpenURIInFrame([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aOpener, short aWhere, short aContext);
		
		/// <summary>
        /// @param  aWindow the window to test.
        /// @return whether the window is the main content window for any
        /// currently open tab in this toplevel browser window.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsTabContentWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aWindow);
	}
}
