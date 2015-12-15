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
// Generated by IDLImporter from file nsINativeFileWatcher.idl
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
    /// The interface for the callback invoked when there is an error.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5DAEDDC3-FC94-4880-8A4F-26D910B92662")]
	public interface nsINativeFileWatcherErrorCallback
	{
		
		/// <summary>
        /// @param xpcomError The XPCOM error code.
        /// @param osError The native OS error (errno under Unix, GetLastError under Windows).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Complete(int xpcomError, int osError);
	}
	
	/// <summary>
    /// The interface for the callback invoked when a change on a watched
    /// resource is detected.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("FE4D86C9-243F-4195-B544-AECE3DF4B86A")]
	public interface nsINativeFileWatcherCallback
	{
		
		/// <summary>
        /// @param resourcePath
        /// The path of the changed resource. If there were too many changes,
        /// the string "*" is passed.
        /// @param flags Reserved for future uses, not currently used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase resourcePath, int flags);
	}
	
	/// <summary>
    /// The interface for the callback invoked when a file watcher operation
    /// successfully completes.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("C3D7F542-681B-4ABD-9D65-9D799B29A42B")]
	public interface nsINativeFileWatcherSuccessCallback
	{
		
		/// <summary>
        /// @param resourcePath
        /// The path of the resource for which the operation completes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase resourcePath);
	}
	
	/// <summary>
    /// A service providing native implementations of path changes notification.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B3A4E8D8-7DC8-47DB-A8B4-83736D7AC1AA")]
	public interface nsINativeFileWatcherService
	{
		
		/// <summary>
        /// Watches the passed path for changes. If it's a directory, every file
        /// it contains is watched. Recursively watches subdirectories. If the
        /// resource is already being watched, does nothing. If the passed path
        /// is a file, the behaviour is not specified.
        ///
        /// @param pathToWatch The path to watch for changes.
        /// @param onChange
        /// The callback invoked whenever a change on a watched
        /// resource is detected.
        /// @param onError
        /// The optional callback invoked whenever an error occurs.
        /// @param onSuccess
        /// The optional callback invoked when the file watcher starts
        /// watching the resource for changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase pathToWatch, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherCallback onChange, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherErrorCallback onError, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherSuccessCallback onSuccess);
		
		/// <summary>
        /// Removes the provided path from the watched resources. If the path
        /// was not being watched or the callbacks were not registered, silently
        /// ignores the request.
        /// Please note that the file watcher only considers the onChange callbacks
        /// when deciding to close a watch on a resource. If there are no more onChange
        /// callbacks associated to the watch, it gets closed (even though it still has
        /// some error callbacks associated).
        ///
        /// @param pathToUnwatch The path to un-watch.
        /// @param onChange
        /// The registered callback invoked whenever a change on a watched
        /// resource is detected.
        /// @param onError
        /// The optionally registered callback invoked whenever an error
        /// occurs.
        /// @param onSuccess
        /// The optional callback invoked when the file watcher stops
        /// watching the resource for changes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemovePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase pathToUnwatch, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherCallback onChange, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherErrorCallback onError, [MarshalAs(UnmanagedType.Interface)] nsINativeFileWatcherSuccessCallback onSuccess);
	}
}
