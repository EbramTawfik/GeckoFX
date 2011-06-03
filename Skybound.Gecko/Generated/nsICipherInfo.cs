// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICipherInfo.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICipherInfo.idl
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
	
	
	/// <summary>nsICipherInfo </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("028e2b2a-1f0b-43a4-a1a7-365d2d7f35d0")]
	public interface nsICipherInfo
	{
		
		/// <summary>Member GetLongNameAttribute </summary>
		/// <param name='aLongName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLongNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aLongName);
		
		/// <summary>Member GetIsSSL2Attribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsSSL2Attribute();
		
		/// <summary>Member GetIsFIPSAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsFIPSAttribute();
		
		/// <summary>Member GetIsExportableAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsExportableAttribute();
		
		/// <summary>Member GetNonStandardAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetNonStandardAttribute();
		
		/// <summary>Member GetSymCipherNameAttribute </summary>
		/// <param name='aSymCipherName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetSymCipherNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aSymCipherName);
		
		/// <summary>Member GetAuthAlgorithmNameAttribute </summary>
		/// <param name='aAuthAlgorithmName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAuthAlgorithmNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aAuthAlgorithmName);
		
		/// <summary>Member GetKeaTypeNameAttribute </summary>
		/// <param name='aKeaTypeName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeaTypeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aKeaTypeName);
		
		/// <summary>Member GetMacAlgorithmNameAttribute </summary>
		/// <param name='aMacAlgorithmName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMacAlgorithmNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aMacAlgorithmName);
		
		/// <summary>Member GetEffectiveKeyBitsAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetEffectiveKeyBitsAttribute();
	}
	
	/// <summary>nsICipherInfoService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("766d47cb-6d8c-4e71-b6b7-336917629a69")]
	public interface nsICipherInfoService
	{
		
		/// <summary>Member GetCipherInfoByPrefString </summary>
		/// <param name='aPrefString'> </param>
		/// <returns>A nsICipherInfo</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICipherInfo GetCipherInfoByPrefString([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPrefString);
	}
}
