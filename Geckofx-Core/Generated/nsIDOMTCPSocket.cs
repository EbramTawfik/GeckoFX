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
// Generated by IDLImporter from file nsIDOMTCPSocket.idl
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
    /// Bug 797561 - Expose a server tcp socket API to web applications
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("65f6d2c8-4be6-4695-958d-0735e8935289")]
	public interface nsIDOMTCPSocket
	{
		
		/// <summary>
        /// Create and return a socket object which will attempt to connect to
        /// the given host and port.
        ///
        /// @param host The hostname of the server to connect to.
        /// @param port The port to connect to.
        /// @param options An object specifying one or more parameters which
        /// determine the details of the socket.
        ///
        /// useSecureTransport: true to create an SSL socket. Defaults to false.
        ///
        /// binaryType: "arraybuffer" to use ArrayBuffer
        /// instances in the ondata callback and as the argument
        /// to send. Defaults to "string", to use JavaScript strings.
        ///
        /// @return The new TCPSocket instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket Open([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase host, ushort port, Gecko.JsVal options);
		
		/// <summary>
        /// Listen on a port
        ///
        /// @param localPort The port of the server socket. Pass -1 to indicate no preference,
        /// and a port will be selected automatically.
        /// @param options An object specifying one or more parameters which
        /// determine the details of the socket.
        ///
        /// binaryType: "arraybuffer" to use ArrayBuffer
        /// instances in the ondata callback and as the argument
        /// to send. Defaults to "string", to use JavaScript strings.
        /// @param backlog The maximum length the queue of pending connections may grow to.
        /// This parameter may be silently limited by the operating system.
        /// Pass -1 to use the default value.
        ///
        /// @return The new TCPServerSocket instance.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPServerSocket Listen(ushort localPort, Gecko.JsVal options, ushort backlog);
		
		/// <summary>
        /// Enable secure on channel.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpgradeToSecure();
		
		/// <summary>
        /// The host of this socket object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aHost);
		
		/// <summary>
        /// The port of this socket object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPortAttribute();
		
		/// <summary>
        /// True if this socket object is an SSL socket.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSslAttribute();
		
		/// <summary>
        /// The number of bytes which have previously been buffered by calls to
        /// send on this socket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetBufferedAmountAttribute();
		
		/// <summary>
        /// Pause reading incoming data and invocations of the ondata handler until
        /// resume is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suspend();
		
		/// <summary>
        /// Resume reading incoming data and invoking ondata as usual.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Resume();
		
		/// <summary>
        /// Close the socket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Close();
		
		/// <summary>
        /// Write data to the socket.
        ///
        /// @param data The data to write to the socket. If
        /// binaryType: "arraybuffer" was passed in the options
        /// object, then this object should be an ArrayBuffer instance.
        /// If binaryType: "string" was passed, or if no binaryType
        /// option was specified, then this object should be an
        /// ordinary JavaScript string.
        /// @param byteOffset The offset within the data from which to begin writing.
        /// Has no effect on non-ArrayBuffer data.
        /// @param byteLength The number of bytes to write. Has no effect on
        /// non-ArrayBuffer data.
        ///
        /// @return Send returns true or false as a hint to the caller that
        /// they may either continue sending more data immediately, or
        /// may want to wait until the other side has read some of the
        /// data which has already been written to the socket before
        /// buffering more. If send returns true, then less than 64k
        /// has been buffered and it's safe to immediately write more.
        /// If send returns false, then more than 64k has been buffered,
        /// and the caller may wish to wait until the ondrain event
        /// handler has been called before buffering more data by more
        /// calls to send.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Send(Gecko.JsVal data, uint byteOffset, uint byteLength);
		
		/// <summary>
        /// The readyState attribute indicates which state the socket is currently
        /// in. The state will be either "connecting", "open", "closing", or "closed".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetReadyStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReadyState);
		
		/// <summary>
        /// The binaryType attribute indicates which mode this socket uses for
        /// sending and receiving data. If the binaryType: "arraybuffer" option
        /// was passed to the open method that created this socket, binaryType
        /// will be "arraybuffer". Otherwise, it will be "string".
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBinaryTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBinaryType);
		
		/// <summary>
        /// The onopen event handler is called when the connection to the server
        /// has been established. If the connection is refused, onerror will be
        /// called, instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnopenAttribute();
		
		/// <summary>
        /// The onopen event handler is called when the connection to the server
        /// has been established. If the connection is refused, onerror will be
        /// called, instead.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnopenAttribute(Gecko.JsVal aOnopen);
		
		/// <summary>
        /// After send has buffered more than 64k of data, it returns false to
        /// indicate that the client should pause before sending more data, to
        /// avoid accumulating large buffers. This is only advisory, and the client
        /// is free to ignore it and buffer as much data as desired, but if reducing
        /// the size of buffers is important (especially for a streaming application)
        /// ondrain will be called once the previously-buffered data has been written
        /// to the network, at which point the client can resume calling send again.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndrainAttribute();
		
		/// <summary>
        /// After send has buffered more than 64k of data, it returns false to
        /// indicate that the client should pause before sending more data, to
        /// avoid accumulating large buffers. This is only advisory, and the client
        /// is free to ignore it and buffer as much data as desired, but if reducing
        /// the size of buffers is important (especially for a streaming application)
        /// ondrain will be called once the previously-buffered data has been written
        /// to the network, at which point the client can resume calling send again.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndrainAttribute(Gecko.JsVal aOndrain);
		
		/// <summary>
        /// The ondata handler will be called repeatedly and asynchronously after
        /// onopen has been called, every time some data was available from the server
        /// and was read. If binaryType: "arraybuffer" was passed to open, the data
        /// attribute of the event object will be an ArrayBuffer. If not, it will be a
        /// normal JavaScript string.
        ///
        /// At any time, the client may choose to pause reading and receiving ondata
        /// callbacks, by calling the socket's suspend() method. Further invocations
        /// of ondata will be paused until resume() is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndataAttribute();
		
		/// <summary>
        /// The ondata handler will be called repeatedly and asynchronously after
        /// onopen has been called, every time some data was available from the server
        /// and was read. If binaryType: "arraybuffer" was passed to open, the data
        /// attribute of the event object will be an ArrayBuffer. If not, it will be a
        /// normal JavaScript string.
        ///
        /// At any time, the client may choose to pause reading and receiving ondata
        /// callbacks, by calling the socket's suspend() method. Further invocations
        /// of ondata will be paused until resume() is called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndataAttribute(Gecko.JsVal aOndata);
		
		/// <summary>
        /// The onerror handler will be called when there is an error. The data
        /// attribute of the event passed to the onerror handler will have a
        /// description of the kind of error.
        ///
        /// If onerror is called before onopen, the error was connection refused,
        /// and onclose will not be called. If onerror is called after onopen,
        /// the connection was lost, and onclose will be called after onerror.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnerrorAttribute();
		
		/// <summary>
        /// The onerror handler will be called when there is an error. The data
        /// attribute of the event passed to the onerror handler will have a
        /// description of the kind of error.
        ///
        /// If onerror is called before onopen, the error was connection refused,
        /// and onclose will not be called. If onerror is called after onopen,
        /// the connection was lost, and onclose will be called after onerror.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute(Gecko.JsVal aOnerror);
		
		/// <summary>
        /// The onclose handler is called once the underlying network socket
        /// has been closed, either by the server, or by the client calling
        /// close.
        ///
        /// If onerror was not called before onclose, then either side cleanly
        /// closed the connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncloseAttribute();
		
		/// <summary>
        /// The onclose handler is called once the underlying network socket
        /// has been closed, either by the server, or by the client calling
        /// close.
        ///
        /// If onerror was not called before onclose, then either side cleanly
        /// closed the connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncloseAttribute(Gecko.JsVal aOnclose);
	}
	
	/// <summary>
    /// This interface is implemented in TCPSocket.js as an internal interfaces
    /// for use in cross-process socket implementation.
    /// Needed to account for multiple possible types that can be provided to
    /// the socket callbacks as arguments.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("017f130f-2477-4215-8783-57eada957699")]
	public interface nsITCPSocketInternal
	{
		
		/// <summary>
        /// Trigger the callback for |type| and provide a DOMError() object with the given data
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallListenerError([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Trigger the callback for |type| and provide a string argument
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallListenerData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		/// <summary>
        /// Trigger the callback for |type| and provide an ArrayBuffer argument
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallListenerArrayBuffer([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type, Gecko.JsVal data);
		
		/// <summary>
        /// Trigger the callback for |type| with no argument
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CallListenerVoid([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase type);
		
		/// <summary>
        ///        new ready state to be set to TCPSocket.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateReadyState([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase readyState);
		
		/// <summary>
        ///        from child are sent to parent.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateBufferedAmount(uint bufferedAmount, uint trackingNumber);
		
		/// <summary>
        ///        in the ondata callback and as the argument to send.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket CreateAcceptedParent([MarshalAs(UnmanagedType.Interface)] nsISocketTransport transport, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase binaryType);
		
		/// <summary>
        ///        An object to create ArrayBuffer for this window. See Bug 831107.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket CreateAcceptedChild([MarshalAs(UnmanagedType.Interface)] nsITCPSocketChild socketChild, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase binaryType, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow window);
		
		/// <summary>
        /// Set App ID.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppId(uint appId);
		
		/// <summary>
        /// socket parent wants to notify that its bufferedAmount is updated.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnUpdateBufferedAmountHandler(Gecko.JsVal handler);
		
		/// <summary>
        ///        lastest send() invocation from child.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnRecvSendFromChild(Gecko.JsVal data, uint byteOffset, uint byteLength, uint trackingNumber);
	}
	
	/// <summary>
    /// nsITCPSocketEvent is the event object which is passed as the
    /// first argument to all the event handler callbacks. It contains
    /// the socket that was associated with the event, the type of event,
    /// and the data associated with the event (if any).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0f2abcca-b483-4539-a3e8-345707f75c44")]
	public interface nsITCPSocketEvent
	{
		
		/// <summary>
        /// The socket object which produced this event.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMTCPSocket GetTargetAttribute();
		
		/// <summary>
        /// The type of this event. One of:
        ///
        /// open
        /// error
        /// data
        /// drain
        /// close
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aType);
		
		/// <summary>
        /// The data related to this event, if any. In the ondata callback,
        /// data will be the bytes read from the network; if the binaryType
        /// of the socket was "arraybuffer", this value will be of type ArrayBuffer;
        /// otherwise, it will be a normal JavaScript string.
        ///
        /// In the onerror callback, data will be a string with a description
        /// of the error.
        ///
        /// In the other callbacks, data will be an empty string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetDataAttribute();
	}
}
