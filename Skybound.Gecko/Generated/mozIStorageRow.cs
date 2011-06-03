// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: mozIStorageRow.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file mozIStorageRow.idl
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
	
	
	/// <summary>mozIStorageRow </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("62d1b6bd-cbfe-4f9b-aee1-0ead4af4e6dc")]
	public interface mozIStorageRow : mozIStorageValueArray
	{
		
		/// <summary>Member GetNumEntriesAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetNumEntriesAttribute();
		
		/// <summary>Member GetTypeOfIndex </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetTypeOfIndex(System.UInt32  aIndex);
		
		/// <summary>Member GetInt32 </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetInt32(System.UInt32  aIndex);
		
		/// <summary>Member GetInt64 </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetInt64(System.UInt32  aIndex);
		
		/// <summary>Member GetDouble </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetDouble(System.UInt32  aIndex);
		
		/// <summary>Member GetUTF8String </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetUTF8String(System.UInt32  aIndex);
		
		/// <summary>Member GetString </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetString(System.UInt32  aIndex);
		
		/// <summary>Member GetBlob </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aDataSize'> </param>
		/// <param name='aData'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBlob(System.UInt32  aIndex, out System.UInt32  aDataSize, out System.IntPtr  aData);
		
		/// <summary>Member GetIsNull </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetIsNull(System.UInt32  aIndex);
		
		/// <summary>Member GetSharedUTF8String </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.String </returns>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.String  GetSharedUTF8String(System.UInt32  aIndex, out System.UInt32  aLength);
		
		/// <summary>Member GetSharedString </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetSharedString(System.UInt32  aIndex, out System.UInt32  aLength);
		
		/// <summary>Member GetSharedBlob </summary>
		/// <param name='aIndex'> </param>
		/// <param name='aLength'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr  GetSharedBlob(System.UInt32  aIndex, out System.UInt32  aLength);
		
		/// <summary>Member GetResultByIndex </summary>
		/// <param name='aIndex'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetResultByIndex(System.UInt32  aIndex);
		
		/// <summary>Member GetResultByName </summary>
		/// <param name='aName'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetResultByName([MarshalAs(UnmanagedType.LPStruct)] nsAString  aName);
	}
}
