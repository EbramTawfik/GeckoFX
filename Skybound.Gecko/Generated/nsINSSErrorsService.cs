// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsINSSErrorsService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsINSSErrorsService.idl
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
	
	
	/// <summary>nsINSSErrorsService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3a5c7a0f-f5da-4a8b-a748-d7c5a528f33b")]
	public interface nsINSSErrorsService
	{
		
		/// <summary>Member IsNSSErrorCode </summary>
		/// <param name='aNSPRCode'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsNSSErrorCode(System.Int32  aNSPRCode);
		
		/// <summary>Member GetXPCOMFromNSSError </summary>
		/// <param name='aNSPRCode'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetXPCOMFromNSSError(System.Int32  aNSPRCode);
		
		/// <summary>Member GetErrorMessage </summary>
		/// <param name='aXPCOMErrorCode'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetErrorMessage(System.Int32  aXPCOMErrorCode);
		
		/// <summary>Member GetErrorClass </summary>
		/// <param name='aXPCOMErrorCode'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetErrorClass(System.Int32  aXPCOMErrorCode);
	}
}
