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
// Generated by IDLImporter from file nsISecurityEventSink.idl
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
	
	
	/// <summary>nsISecurityEventSink </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a71aee68-dd38-4736-bd79-035fea1a1ec6")]
	public interface nsISecurityEventSink
	{
		
		/// <summary>
        /// Fired when a security change occurs due to page transitions,
        /// or end document load. This interface should be called by
        /// a security package (eg Netscape Personal Security Manager)
        /// to notify nsIWebProgressListeners that security state has
        /// changed. State flags are in nsIWebProgressListener.idl
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnSecurityChange([MarshalAs(UnmanagedType.Interface)] nsISupports  i_Context, System.UInt32  state);
	}
}
