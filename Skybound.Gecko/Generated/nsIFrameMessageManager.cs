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
// Generated by IDLImporter from file nsIFrameMessageManager.idl
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
	
	
	/// <summary>nsIFrameMessageListener </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("938fcb95-3d63-46be-aa72-94d08fd3b418")]
	public interface nsIFrameMessageListener
	{
		
		/// <summary>
        /// This is for JS only.
        /// receiveMessage is called with one parameter, which has the following
        /// properties:
        /// {
        /// name:    %message name%,
        /// sync:    %true or false%.
        /// json:    %json object or null%,
        /// objects: %array of handles or null, always null if sync is false%
        /// }
        /// @note objects property isn't implemented yet.
        ///
        /// if the message is synchronous, possible return value is sent back
        /// as JSON.
        ///
        /// When the listener is called, 'this' value is the target of the message.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReceiveMessage();
	}
	
	/// <summary>nsIFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6b736edb-863d-40bd-bca2-62f44da803c0")]
	public interface nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendAsyncMessage();
	}
	
	/// <summary>nsISyncMessageSender </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cdb1a40b-9862-426c-ae8a-f5ab84e20e32")]
	public interface nsISyncMessageSender : nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage();
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendSyncMessage();
	}
	
	/// <summary>nsIContentFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c56e85b8-6736-4ae2-ae90-66bcef952a82")]
	public interface nsIContentFrameMessageManager : nsISyncMessageSender
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage();
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendSyncMessage();
		
		/// <summary>
        /// The current top level window in the frame or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetContentAttribute();
		
		/// <summary>
        /// The top level docshell or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDocShell  GetDocShellAttribute();
		
		/// <summary>
        /// Print a string to stdout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Dump([MarshalAs(UnmanagedType.LPStruct)] nsAString aStr);
		
		/// <summary>
        /// If leak detection is enabled, print a note to the leak log that this
        /// process will intentionally crash.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrivateNoteIntentionalCrash();
	}
	
	/// <summary>nsIInProcessContentFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c48d557-92fe-4edb-95fc-bfe97e77bdc3")]
	public interface nsIInProcessContentFrameMessageManager : nsIContentFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage();
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendSyncMessage();
		
		/// <summary>
        /// The current top level window in the frame or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow  GetContentAttribute();
		
		/// <summary>
        /// The top level docshell or null.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDocShell  GetDocShellAttribute();
		
		/// <summary>
        /// Print a string to stdout.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Dump([MarshalAs(UnmanagedType.LPStruct)] nsAString aStr);
		
		/// <summary>
        /// If leak detection is enabled, print a note to the leak log that this
        /// process will intentionally crash.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PrivateNoteIntentionalCrash();
		
		/// <summary>Member GetOwnerContent </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetOwnerContent();
	}
	
	/// <summary>nsIChromeFrameMessageManager </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ed6522fd-ffb6-4920-b50d-cf629309616b")]
	public interface nsIChromeFrameMessageManager : nsIFrameMessageManager
	{
		
		/// <summary>Member AddMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AddMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>Member RemoveMessageListener </summary>
		/// <param name='aMessage'> </param>
		/// <param name='aListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveMessageListener([MarshalAs(UnmanagedType.LPStruct)] nsAString aMessage, System.IntPtr aListener);
		
		/// <summary>
        ///in messageName, in JSON </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SendAsyncMessage();
		
		/// <summary>
        /// Load a script in the (remote) frame. aURL must be the absolute URL.
        /// data: URLs are also supported. For example data:,dump("foo\n");
        /// If aAllowDelayedLoad is true, script will be loaded when the
        /// remote frame becomes available. Otherwise the script will be loaded
        /// only if the frame is already available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadFrameScript([MarshalAs(UnmanagedType.LPStruct)] nsAString aURL, System.Boolean  aAllowDelayedLoad);
	}
}
