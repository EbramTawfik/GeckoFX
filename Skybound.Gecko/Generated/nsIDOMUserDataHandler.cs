// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMUserDataHandler.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMUserDataHandler.idl
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
	
	
	/// <summary>nsIDOMUserDataHandler </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("91afebdd-a201-4db0-b728-9d59580f0cfd")]
	public interface nsIDOMUserDataHandler
	{
		
		/// <summary>Member Handle </summary>
		/// <param name='operation'> </param>
		/// <param name='key'> </param>
		/// <param name='data'> </param>
		/// <param name='src'> </param>
		/// <param name='dst'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Handle(ushort operation, [MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.Interface)] nsIVariant  data, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  src, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  dst);
	}
}