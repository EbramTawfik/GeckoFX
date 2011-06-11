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
// Generated by IDLImporter from file nsIJXTestArrayParams.idl
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
	
	
	/// <summary>nsIJXTestArrayParams </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fb520bac-92cf-4a6b-a2f3-eb63313d7d84")]
	public interface nsIJXTestArrayParams
	{
		
		/// <summary>Member MultiplyEachItemInIntegerArray2 </summary>
		/// <param name='val'> </param>
		/// <param name='valueArray'> </param>
		/// <param name='count'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MultiplyEachItemInIntegerArray2(System.Int32  val, ref System.Int32  valueArray, System.UInt32  count);
		
		/// <summary>Member CopyIntArray </summary>
		/// <param name='srcArray'> </param>
		/// <param name='count'> </param>
		/// <param name='dstArray'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyIntArray(System.Int32  srcArray, System.UInt32  count, out System.Int32  dstArray);
		
		/// <summary>Member ReturnIntArray </summary>
		/// <param name='srcArray'> </param>
		/// <param name='count'> </param>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  ReturnIntArray(System.Int32  srcArray, System.UInt32  count);
		
		/// <summary>Member CopyByteArray </summary>
		/// <param name='srcArray'> </param>
		/// <param name='count'> </param>
		/// <param name='dstArray'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyByteArray(System.IntPtr  srcArray, System.UInt32  count, out System.IntPtr  dstArray);
		
		/// <summary>Member ReturnByteArray </summary>
		/// <param name='srcArray'> </param>
		/// <param name='count'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  ReturnByteArray(System.IntPtr  srcArray, System.UInt32  count);
		
		/// <summary>Member CopySizedString </summary>
		/// <param name='srcString'> </param>
		/// <param name='count'> </param>
		/// <param name='dstString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopySizedString([MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] System.String  srcString, System.UInt32  count, [MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] out System.String  dstString);
		
		/// <summary>Member ReturnSizedString </summary>
		/// <param name='srcString'> </param>
		/// <param name='count'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.String  ReturnSizedString([MarshalAs(UnmanagedType.LPStr, SizeParamIndex=1)] System.String  srcString, System.UInt32  count);
		
		/// <summary>Member CopySizedWString </summary>
		/// <param name='srcString'> </param>
		/// <param name='count'> </param>
		/// <param name='dstString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopySizedWString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string srcString, System.UInt32  count, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] out string dstString);
		
		/// <summary>Member ReturnSizedWString </summary>
		/// <param name='srcString'> </param>
		/// <param name='count'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string ReturnSizedWString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string srcString, System.UInt32  count);
	}
}
