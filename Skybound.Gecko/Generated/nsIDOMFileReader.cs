// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMFileReader.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMFileReader.idl
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
	
	
	/// <summary>nsIDOMFileReader </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("71c32f16-ea5d-415e-9303-0db981c17bed")]
	public interface nsIDOMFileReader
	{
		
		/// <summary>Member ReadAsBinaryString </summary>
		/// <param name='filedata'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadAsBinaryString([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob  filedata);
		
		/// <summary>Member ReadAsText </summary>
		/// <param name='filedata'> </param>
		/// <param name='encoding'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadAsText([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob  filedata, [MarshalAs(UnmanagedType.LPStruct)] nsAString encoding);
		
		/// <summary>Member ReadAsDataURL </summary>
		/// <param name='file'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadAsDataURL([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob  file);
		
		/// <summary>Member Abort </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Abort();
		
		/// <summary>Member GetReadyStateAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetReadyStateAttribute();
		
		/// <summary>Member GetResultAttribute </summary>
		/// <param name='aResult'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetResultAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aResult);
		
		/// <summary>Member GetErrorAttribute </summary>
		/// <returns>A nsIDOMFileError </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMFileError  GetErrorAttribute();
		
		/// <summary>Member GetOnloadendAttribute </summary>
		/// <returns>A nsIDOMEventListener </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventListener  GetOnloadendAttribute();
		
		/// <summary>Member SetOnloadendAttribute </summary>
		/// <param name='aOnloadend'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadendAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMEventListener  aOnloadend);
	}
}
