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
// Generated by IDLImporter from file nsIDNSService.idl
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
    /// nsIDNSService
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("de5642c6-61fc-4fcf-9a47-03226b0d4e21")]
	public interface nsIDNSService
	{
		
		/// <summary>
        /// kicks off an asynchronous host lookup.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        /// @param aListener
        /// the listener to be notified when the result is available.
        /// @param aListenerTarget
        /// optional parameter (may be null).  if non-null, this parameter
        /// specifies the nsIEventTarget of the thread on which the
        /// listener's onLookupComplete should be called.  however, if this
        /// parameter is null, then onLookupComplete will be called on an
        /// unspecified thread (possibly recursively).
        ///
        /// @return An object that can be used to cancel the host lookup.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICancelable AsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);
		
		/// <summary>
        /// Attempts to cancel a previously requested async DNS lookup
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        /// @param aListener
        /// the original listener which was to be notified about the host lookup
        /// result - used to match request information to requestor.
        /// @param aReason
        /// nsresult reason for the cancellation
        ///
        /// @return An object that can be used to cancel the host lookup.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelAsyncResolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);
		
		/// <summary>
        /// called to synchronously resolve a hostname.  warning this method may
        /// block the calling thread for a long period of time.  it is extremely
        /// unwise to call this function on the UI thread of an application.
        ///
        /// @param aHostName
        /// the hostname or IP-address-literal to resolve.
        /// @param aFlags
        /// a bitwise OR of the RESOLVE_ prefixed constants defined below.
        ///
        /// @return DNS record corresponding to the given hostname.
        /// @throws NS_ERROR_UNKNOWN_HOST if host could not be resolved.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDNSRecord Resolve([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags);
		
		/// <summary>
        /// kicks off an asynchronous host lookup.
        ///
        /// This function is identical to asyncResolve except an additional
        /// parameter aNetwortInterface. If parameter aNetworkInterface is an empty
        /// string function will return the same result as asyncResolve.
        /// Setting aNetworkInterface value make only sense for gonk,because it
        /// an per networking interface query is possible.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICancelable AsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, [MarshalAs(UnmanagedType.Interface)] nsIEventTarget aListenerTarget);
		
		/// <summary>
        /// Attempts to cancel a previously requested async DNS lookup
        /// This is an extended versin with a additional parameter aNetworkInterface
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelAsyncResolveExtended([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHostName, uint aFlags, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aNetworkInterface, [MarshalAs(UnmanagedType.Interface)] nsIDNSListener aListener, int aReason);
		
		/// <summary>
        /// The method takes a pointer to an nsTArray
        /// and fills it with cache entry data
        /// Called by the networking dashboard
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDNSCacheEntries(System.IntPtr args);
		
		/// <summary>
        /// @return the hostname of the operating system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMyHostNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMyHostName);
	}
	
	/// <summary>nsIDNSServiceConsts </summary>
	public class nsIDNSServiceConsts
	{
		
		// <summary>
        // if set, this flag suppresses the internal DNS lookup cache.
        // </summary>
		public const ulong RESOLVE_BYPASS_CACHE = (1<<0);
		
		// <summary>
        // if set, the canonical name of the specified host will be queried.
        // </summary>
		public const ulong RESOLVE_CANONICAL_NAME = (1<<1);
		
		// <summary>
        // if set, the query is given lower priority. Medium takes precedence
        // if both are used.
        // </summary>
		public const ulong RESOLVE_PRIORITY_MEDIUM = (1<<2);
		
		// 
		public const ulong RESOLVE_PRIORITY_LOW = (1<<3);
		
		// <summary>
        // if set, indicates request is speculative. Speculative requests
        // return errors if prefetching is disabled by configuration.
        // </summary>
		public const ulong RESOLVE_SPECULATE = (1<<4);
		
		// <summary>
        // If set, only IPv4 addresses will be returned from resolve/asyncResolve.
        // </summary>
		public const ulong RESOLVE_DISABLE_IPV6 = (1<<5);
		
		// <summary>
        // If set, only literals and cached entries will be returned from resolve/
        // asyncResolve.
        // </summary>
		public const ulong RESOLVE_OFFLINE = (1<<6);
		
		// <summary>
        // If set, only IPv6 addresses will be returned from resolve/asyncResolve.
        // </summary>
		public const ulong RESOLVE_DISABLE_IPV4 = (1<<7);
		
		// <summary>
        // If set, allow name collision results (127.0.53.53) which are normally filtered.
        // </summary>
		public const ulong RESOLVE_ALLOW_NAME_COLLISION = (1<<8);
	}
}
