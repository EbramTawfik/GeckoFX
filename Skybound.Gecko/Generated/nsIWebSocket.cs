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
// Generated by IDLImporter from file nsIWebSocket.idl
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
    /// The nsIWebSocket interface enables Web applications to maintain
    /// bidirectional communications with server-side processes as described in:
    ///
    /// http://dev.w3.org/html5/websockets/
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4403cd57-07fc-477f-a062-d6ba7dd0781b")]
	public interface nsIWebSocket
	{
		
		/// <summary>
        /// The nsIWebSocket interface enables Web applications to maintain
        /// bidirectional communications with server-side processes as described in:
        ///
        /// http://dev.w3.org/html5/websockets/
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetUrlAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aUrl);
		
		/// <summary>
        ///ready state
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetReadyStateAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetBufferedAmountAttribute();
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnopenAttribute();
		
		/// <summary>
        /// event handler attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnopenAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnopen);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnmessageAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmessageAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnmessage);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnerrorAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnerror);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOncloseAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncloseAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnclose);
		
		/// <summary>
        /// Transmits data using the connection.
        ///
        /// @param data The data to be transmited.
        /// @return if the connection is still established (and the data was queued or
        /// sent successfully).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Send([MarshalAs(UnmanagedType.LPStruct)] nsAString data);
		
		/// <summary>
        /// Closes the Web Socket connection or connection attempt, if any.
        /// If the connection is already closed, it does nothing.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Initialize the object for use from C++ code with the principal, script
        /// context, and owner window that should be used.
        ///
        /// @param principal The principal to use for the request. This must not be
        /// null.
        /// @param scriptContext The script context to use for the request. May be
        /// null.
        /// @param ownerWindow The associated window for the request. May be null.
        /// @param url The url for opening the socket. This must not be empty, and
        /// must have an absolute url, using either the ws or wss schemes.
        /// @param protocol  Specifies a sub-protocol that the server must support for
        /// the connection to be successful. If empty, no protocol is
        /// specified.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIPrincipal  principal, System.IntPtr scriptContext, System.IntPtr ownerWindow, [MarshalAs(UnmanagedType.LPStruct)] nsAString url, [MarshalAs(UnmanagedType.LPStruct)] nsAString protocol);
	}
}
