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
// Generated by IDLImporter from file nsIClassOfService.idl
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
    /// nsIClassOfService.idl
    ///
    /// Used to express class dependencies and characteristics - complimentary to
    /// nsISupportsPriority which is used to express weight
    ///
    /// Channels that implement this interface may make use of this
    /// information in different ways.
    ///
    /// The default gecko HTTP/1 stack makes Followers wait for Leaders to
    /// complete before dispatching followers. Other classes run in
    /// parallel - neither being blocked nor blocking. All grouping is done
    /// based on the Load Group - separate load groups proceed
    /// independently.
    ///
    /// HTTP/2 does not use the load group, but prioritization is done per
    /// HTTP/2 session. HTTP/2 dispatches all the requests as soon as
    /// possible.
    /// The various classes are assigned logical priority
    /// dependency groups and then transactions of that class depend on the
    /// group. In this model Followers block on Leaders and Speculative
    /// depends on Background. See Http2Stream.cpp for weighting details.
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1ccb58ec-5e07-4cf9-a30d-ac5490d23b41")]
	public interface nsIClassOfService
	{
		
		/// <summary>
        /// nsIClassOfService.idl
        ///
        /// Used to express class dependencies and characteristics - complimentary to
        /// nsISupportsPriority which is used to express weight
        ///
        /// Channels that implement this interface may make use of this
        /// information in different ways.
        ///
        /// The default gecko HTTP/1 stack makes Followers wait for Leaders to
        /// complete before dispatching followers. Other classes run in
        /// parallel - neither being blocked nor blocking. All grouping is done
        /// based on the Load Group - separate load groups proceed
        /// independently.
        ///
        /// HTTP/2 does not use the load group, but prioritization is done per
        /// HTTP/2 session. HTTP/2 dispatches all the requests as soon as
        /// possible.
        /// The various classes are assigned logical priority
        /// dependency groups and then transactions of that class depend on the
        /// group. In this model Followers block on Leaders and Speculative
        /// depends on Background. See Http2Stream.cpp for weighting details.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClassFlagsAttribute();
		
		/// <summary>
        /// nsIClassOfService.idl
        ///
        /// Used to express class dependencies and characteristics - complimentary to
        /// nsISupportsPriority which is used to express weight
        ///
        /// Channels that implement this interface may make use of this
        /// information in different ways.
        ///
        /// The default gecko HTTP/1 stack makes Followers wait for Leaders to
        /// complete before dispatching followers. Other classes run in
        /// parallel - neither being blocked nor blocking. All grouping is done
        /// based on the Load Group - separate load groups proceed
        /// independently.
        ///
        /// HTTP/2 does not use the load group, but prioritization is done per
        /// HTTP/2 session. HTTP/2 dispatches all the requests as soon as
        /// possible.
        /// The various classes are assigned logical priority
        /// dependency groups and then transactions of that class depend on the
        /// group. In this model Followers block on Leaders and Speculative
        /// depends on Background. See Http2Stream.cpp for weighting details.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassFlagsAttribute(uint aClassFlags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearClassFlags(uint flags);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddClassFlags(uint flags);
	}
	
	/// <summary>nsIClassOfServiceConsts </summary>
	public class nsIClassOfServiceConsts
	{
		
		// 
		public const ulong Leader = 1<<0;
		
		// 
		public const ulong Follower = 1<<1;
		
		// 
		public const ulong Speculative = 1<<2;
		
		// 
		public const ulong Background = 1<<3;
		
		// 
		public const ulong Unblocked = 1<<4;
	}
}
