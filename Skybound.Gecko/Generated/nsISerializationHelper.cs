// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISerializationHelper.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISerializationHelper.idl
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
	
	
	/// <summary>nsISerializationHelper </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("31654c0f-35f3-44c6-b31e-37a11516e6bc")]
	public interface nsISerializationHelper
	{
		
		/// <summary>Member SerializeToString </summary>
		/// <param name='serializable'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString SerializeToString([MarshalAs(UnmanagedType.Interface)] nsISerializable  serializable);
		
		/// <summary>Member DeserializeObject </summary>
		/// <param name='input'> </param>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports DeserializeObject([MarshalAs(UnmanagedType.LPStruct)] nsAString  input);
	}
}
