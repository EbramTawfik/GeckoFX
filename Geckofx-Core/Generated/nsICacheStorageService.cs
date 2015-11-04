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
// Generated by IDLImporter from file nsICacheStorageService.idl
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
    /// Provides access to particual cache storages of the network URI cache.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("44de2fa4-1b0e-4cd3-9e32-211e936f721e")]
	public interface nsICacheStorageService
	{
		
		/// <summary>
        /// Get storage where entries will only remain in memory, never written
        /// to the disk.
        ///
        /// NOTE: Any existing disk entry for [URL|id-extension] will be doomed
        /// prior opening an entry using this memory-only storage.  Result of
        /// AsyncOpenURI will be a new and empty memory-only entry.  Using
        /// OPEN_READONLY open flag has no effect on this behavior.
        ///
        /// @param aLoadContextInfo
        /// Information about the loading context, this focuses the storage JAR and
        /// respects separate storage for private browsing.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheStorage MemoryCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo);
		
		/// <summary>
        /// Get storage where entries will be written to disk when not forbidden by
        /// response headers.
        ///
        /// @param aLookupAppCache
        /// When set true (for top level document loading channels) app cache will
        /// be first to check on to find entries in.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheStorage DiskCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo, [MarshalAs(UnmanagedType.U1)] bool aLookupAppCache);
		
		/// <summary>
        /// Get storage for a specified application cache obtained using some different
        /// mechanism.
        ///
        /// @param aLoadContextInfo
        /// Mandatory reference to a load context information.
        /// @param aApplicationCache
        /// Optional reference to an existing appcache.  When left null, this will
        /// work with offline cache as a whole.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICacheStorage AppCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo, [MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache);
		
		/// <summary>
        /// Evict the whole cache.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Clear();
		
		/// <summary>
        /// Purges data we keep warmed in memory.  Use for tests and for
        /// saving memory.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PurgeFromMemory(uint aWhat);
		
		/// <summary>
        /// I/O thread target to use for any operations on disk
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIEventTarget GetIoTargetAttribute();
		
		/// <summary>
        /// Asynchronously determine how many bytes of the disk space the cache takes.
        /// @see nsICacheStorageConsumptionObserver
        /// @param aObserver
        /// A mandatory (weak referred) observer.  Documented at
        /// nsICacheStorageConsumptionObserver.
        /// NOTE: the observer MUST implement nsISupportsWeakReference.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AsyncGetDiskConsumption([MarshalAs(UnmanagedType.Interface)] nsICacheStorageConsumptionObserver aObserver);
	}
	
	/// <summary>nsICacheStorageServiceConsts </summary>
	public class nsICacheStorageServiceConsts
	{
		
		// <summary>
        // Purge only data of disk backed entries.  Metadata are left for
        // performance purposes.
        // </summary>
		public const long PURGE_DISK_DATA_ONLY = 1;
		
		// <summary>
        // Purge whole disk backed entries from memory.  Disk files will
        // be left unattended.
        // </summary>
		public const long PURGE_DISK_ALL = 2;
		
		// <summary>
        // Purge all entries we keep in memory, including memory-storage
        // entries.  This may be dangerous to use.
        // </summary>
		public const long PURGE_EVERYTHING = 3;
	}
	
	/// <summary>nsICacheStorageConsumptionObserver </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7728ab5b-4c01-4483-a606-32bf5b8136cb")]
	public interface nsICacheStorageConsumptionObserver
	{
		
		/// <summary>
        /// Callback invoked to answer asyncGetDiskConsumption call. Always triggered
        /// on the main thread.
        /// NOTE: implementers must also implement nsISupportsWeakReference.
        ///
        /// @param aDiskSize
        /// The disk consumption in bytes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnNetworkCacheDiskConsumption(long aDiskSize);
	}
}
