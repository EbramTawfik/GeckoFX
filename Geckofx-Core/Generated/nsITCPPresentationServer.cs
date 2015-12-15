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
// Generated by IDLImporter from file nsITCPPresentationServer.idl
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
    /// The device information required for establishing TCP control channel.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("296fd171-e4d0-4de0-99ff-ad8ed52ddef3")]
	public interface nsITCPDeviceInfo
	{
		
		/// <summary>
        /// The device information required for establishing TCP control channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAddressAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aAddress);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPortAttribute();
	}
	
	/// <summary>nsITCPPresentationServerListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("09bddfaf-fcc2-4dc9-b33e-a509a1c2fb6d")]
	public interface nsITCPPresentationServerListener
	{
		
		/// <summary>
        /// Callback while the server socket changes port.
        /// This event won't be cached so you should get current port after setting
        /// this listener to make sure the value is updated.
        /// @param   aPort
        /// The port of the server socket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnPortChange(ushort aPort);
		
		/// <summary>
        /// Callback while the remote host is requesting to start a presentation session.
        /// @param aDeviceInfo The device information related to the remote host.
        /// @param aUrl The URL requested to open by remote device.
        /// @param aPresentationId The Id for representing this session.
        /// @param aControlChannel The control channel for this session.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSessionRequest([MarshalAs(UnmanagedType.Interface)] nsITCPDeviceInfo aDeviceInfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUrl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPresentationId, [MarshalAs(UnmanagedType.Interface)] nsIPresentationControlChannel aControlChannel);
	}
	
	/// <summary>
    /// TCP presentation server which can be used by discovery services.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("55d6b605-2389-4aae-a8fe-60d4440540ea")]
	public interface nsITCPPresentationServer
	{
		
		/// <summary>
        /// This method initialize server socket.
        /// @param   aPort
        /// The port of the server socket.  Pass 0 or opt-out to indicate no
        /// preference, and a port will be selected automatically.
        /// @throws  NS_ERROR_FAILURE if the server socket has been inited or the
        /// server socket can not be inited.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartService(ushort aPort);
		
		/// <summary>
        /// Request session to designated remote TCP device.
        /// @param   aDeviceInfo
        /// The remtoe device info for establish connection.
        /// @param   aUrl
        /// The URL requested to open by remote device.
        /// @param   aPresentationId
        /// The Id for representing this session.
        /// @returns The control channel for this session.
        /// @throws  NS_ERROR_FAILURE if the Id hasn't been inited.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPresentationControlChannel RequestSession([MarshalAs(UnmanagedType.Interface)] nsITCPDeviceInfo aDeviceInfo, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aUrl, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPresentationId);
		
		/// <summary>
        /// Close server socket and call |listener.onClose(NS_OK)|
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Get the listen port of the TCP socket, valid after |init|. 0 indicates
        /// the server socket is not inited or closed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPortAttribute();
		
		/// <summary>
        /// The id of the TCP presentation server. |requestSession| won't
        /// work until the |id| is set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aId);
		
		/// <summary>
        /// The id of the TCP presentation server. |requestSession| won't
        /// work until the |id| is set.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aId);
		
		/// <summary>
        /// the listener for handling events of this TCP presentation server
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsITCPPresentationServerListener GetListenerAttribute();
		
		/// <summary>
        /// the listener for handling events of this TCP presentation server
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetListenerAttribute([MarshalAs(UnmanagedType.Interface)] nsITCPPresentationServerListener aListener);
	}
}
