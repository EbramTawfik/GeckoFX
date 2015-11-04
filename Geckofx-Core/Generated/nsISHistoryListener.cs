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
// Generated by IDLImporter from file nsISHistoryListener.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// nsISHistoryListener defines the interface one can implement to receive
    /// notifications about activities in session history and to be able to
    /// cancel them.
    ///
    /// A session history listener will be notified when pages are added, removed
    /// and loaded from session history. It can prevent any action (except adding
    /// a new session history entry) from happening by returning false from the
    /// corresponding callback method.
    ///
    /// A session history listener can be registered on a particular nsISHistory
    /// instance via the nsISHistory::addSHistoryListener() method.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("125c0833-746a-400e-9b89-d2d18545c08a")]
	public interface nsISHistoryListener
	{
		
		/// <summary>
        /// Called when a new document is added to session history. New documents are
        /// added to session history by docshell when new pages are loaded in a frame
        /// or content area, for example via nsIWebNavigation::loadURI()
        ///
        /// @param aNewURI     The URI of the document to be added to session history.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHistoryNewEntry([MarshalAs(UnmanagedType.Interface)] nsIURI aNewURI);
		
		/// <summary>
        /// Called when navigating to a previous session history entry, for example
        /// due to a nsIWebNavigation::goBack() call.
        ///
        /// @param aBackURI    The URI of the session history entry being navigated to.
        /// @return            Whether the operation can proceed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoBack([MarshalAs(UnmanagedType.Interface)] nsIURI aBackURI);
		
		/// <summary>
        /// Called when navigating to a next session history entry, for example
        /// due to a nsIWebNavigation::goForward() call.
        ///
        /// @param aForwardURI   The URI of the session history entry being navigated to.
        /// @return              Whether the operation can proceed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGoForward([MarshalAs(UnmanagedType.Interface)] nsIURI aForwardURI);
		
		/// <summary>
        /// Called when the current document is reloaded, for example due to a
        /// nsIWebNavigation::reload() call.
        ///
        /// @param aReloadURI    The URI of the document to be reloaded.
        /// @param aReloadFlags  Flags that indicate how the document is to be
        /// refreshed. See constants on the nsIWebNavigation
        /// interface.
        /// @return              Whether the operation can proceed.
        ///
        /// @see  nsIWebNavigation
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryReload([MarshalAs(UnmanagedType.Interface)] nsIURI aReloadURI, uint aReloadFlags);
		
		/// <summary>
        /// Called when navigating to a session history entry by index, for example,
        /// when nsIWebNavigation::gotoIndex() is called.
        ///
        /// @param aIndex        The index in session history of the entry to be loaded.
        /// @param aGotoURI      The URI of the session history entry to be loaded.
        /// @return              Whether the operation can proceed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryGotoIndex(int aIndex, [MarshalAs(UnmanagedType.Interface)] nsIURI aGotoURI);
		
		/// <summary>
        /// Called when entries are removed from session history. Entries can be
        /// removed from session history for various reasons, for example to control
        /// the memory usage of the browser, to prevent users from loading documents
        /// from history, to erase evidence of prior page loads, etc.
        ///
        /// To purge documents from session history call nsISHistory::PurgeHistory()
        ///
        /// @param aNumEntries   The number of entries to be removed from session history.
        /// @return              Whether the operation can proceed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool OnHistoryPurge(int aNumEntries);
		
		/// <summary>
        /// Called when an entry is replaced in the session history. Entries are
        /// replaced when navigating away from non-persistent history entries (such as
        /// about pages) and when history.replaceState is called.
        ///
        /// @param aIndex        The index in session history of the entry being
        /// replaced
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnHistoryReplaceEntry(int aIndex);
	}
}
