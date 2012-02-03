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
// Generated by IDLImporter from file nsISHistoryInternal.idl
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
	using System.Windows.Forms;
	
	
	/// <summary>nsISHistoryInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e27cf38e-c19f-4294-bd31-d7e0916e7fa2")]
	public interface nsISHistoryInternal
	{
		
		/// <summary>
        /// Add a new Entry to the History List
        /// @param aEntry - The entry to add
        /// @param aPersist - If true this specifies that the entry should persist
        /// in the list.  If false, this means that when new entries are added
        /// this element will not appear in the session history list.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddEntry([MarshalAs(UnmanagedType.Interface)] nsISHEntry aEntry, [MarshalAs(UnmanagedType.Bool)] bool aPersist);
		
		/// <summary>
        /// Get the root transaction
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHTransaction GetRootTransactionAttribute();
		
		/// <summary>
        /// The toplevel docshell object to which this SHistory object belongs to.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell GetRootDocShellAttribute();
		
		/// <summary>
        /// The toplevel docshell object to which this SHistory object belongs to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRootDocShellAttribute([MarshalAs(UnmanagedType.Interface)] nsIDocShell aRootDocShell);
		
		/// <summary>
        /// Update the index maintained by sessionHistory
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateIndex();
		
		/// <summary>
        /// Replace the nsISHEntry at a particular index
        /// @param aIndex - The index at which the entry should be replaced
        /// @param aReplaceEntry - The replacement entry for the index.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReplaceEntry(int aIndex, [MarshalAs(UnmanagedType.Interface)] nsISHEntry aReplaceEntry);
		
		/// <summary>
        /// Get handle to the history listener
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHistoryListener GetListenerAttribute();
		
		/// <summary>
        /// Evict content viewers which don't lie in the "safe" range around aIndex.
        /// In practice, this should leave us with no more than gHistoryMaxViewers
        /// viewers associated with this SHistory object.
        ///
        /// Also make sure that the total number of content viewers in all windows is
        /// not greater than our global max; if it is, evict viewers as appropriate.
        ///
        /// @param aIndex - The index around which the "safe" range is centered.  In
        /// general, if you just navigated the history, aIndex should be the index
        /// history was navigated to.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvictOutOfRangeContentViewers(int aIndex);
		
		/// <summary>
        /// Evict the content viewer associated with a bfcache entry
        /// that has timed out.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvictExpiredContentViewerForEntry([MarshalAs(UnmanagedType.Interface)] nsIBFCacheEntry aEntry);
		
		/// <summary>
        /// Evict all the content viewers in this session history
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EvictAllContentViewers();
		
		/// <summary>
        /// Removes entries from the history if their docshellID is in
        /// aIDs array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveEntries(System.IntPtr aIDs, int aStartIndex);
	}
}
