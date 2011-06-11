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
// Generated by IDLImporter from file nsITokenDialogs.idl
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
	
	
	/// <summary>nsITokenDialogs </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a1cbc159-468c-495d-8068-61dd538cbcca")]
	public interface nsITokenDialogs
	{
		
		/// <summary>Member ChooseToken </summary>
		/// <param name='ctx'> </param>
		/// <param name='tokenNameList'> </param>
		/// <param name='count'> </param>
		/// <param name='tokenName'> </param>
		/// <param name='canceled'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ChooseToken([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  ctx, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] string tokenNameList, System.UInt32  count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] out string tokenName, out System.Boolean  canceled);
		
		/// <summary>
        /// displayProtectedAuth - displays notification dialog to the user
        /// that he is expected to authenticate to the token using its
        /// "protected authentication path" feature
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DisplayProtectedAuth([MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor  ctx, [MarshalAs(UnmanagedType.Interface)] nsIProtectedAuthThread  runnable);
	}
}
