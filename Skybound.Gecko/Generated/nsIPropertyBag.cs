// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPropertyBag.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPropertyBag.idl
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
	
	
	/// <summary>nsIPropertyBag </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bfcd37b0-a49f-11d5-910d-0010a4e73d9a")]
	public interface nsIPropertyBag
	{
		
		/// <summary>Member GetEnumeratorAttribute </summary>
		/// <returns>A nsISimpleEnumerator </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator  GetEnumeratorAttribute();
		
		/// <summary>Member GetProperty </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
}
