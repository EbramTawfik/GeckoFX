// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsICollation.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsICollation.idl
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
	
	
	/// <summary>nsICollationFactory </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("04971e14-d6b3-4ada-8cbb-c3a13842b349")]
	public interface nsICollationFactory
	{
		
		/// <summary>Member CreateCollation </summary>
		/// <param name='locale'> </param>
		/// <returns>A nsICollation</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsICollation CreateCollation([MarshalAs(UnmanagedType.Interface)] nsILocale  locale);
	}
	
	/// <summary>nsICollation </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b0132cc0-3786-4557-9874-910d7def5f93")]
	public interface nsICollation
	{
		
		/// <summary>Member Initialize </summary>
		/// <param name='locale'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.Interface)] nsILocale  locale);
		
		/// <summary>Member CompareString </summary>
		/// <param name='strength'> </param>
		/// <param name='string1'> </param>
		/// <param name='string2'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CompareString(System.Int32  strength, [MarshalAs(UnmanagedType.LPStruct)] nsAString string1, [MarshalAs(UnmanagedType.LPStruct)] nsAString string2);
		
		/// <summary>Member AllocateRawSortKey </summary>
		/// <param name='strength'> </param>
		/// <param name='stringIn'> </param>
		/// <param name='key'> </param>
		/// <param name='outLen'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AllocateRawSortKey(System.Int32  strength, [MarshalAs(UnmanagedType.LPStruct)] nsAString stringIn, out System.IntPtr  key, out System.UInt32  outLen);
		
		/// <summary>Member CompareRawSortKey </summary>
		/// <param name='key1'> </param>
		/// <param name='len1'> </param>
		/// <param name='key2'> </param>
		/// <param name='len2'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int CompareRawSortKey(System.IntPtr  key1, System.UInt32  len1, System.IntPtr  key2, System.UInt32  len2);
	}
}
