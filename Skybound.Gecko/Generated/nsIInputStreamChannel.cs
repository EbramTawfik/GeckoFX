// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIInputStreamChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIInputStreamChannel.idl
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
	
	
	/// <summary>nsIInputStreamChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("274c4d7a-2447-4ceb-a6de-80db1b83f5d2")]
	public interface nsIInputStreamChannel
	{
		
		/// <summary>Member SetURI </summary>
		/// <param name='aURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member GetContentStreamAttribute </summary>
		/// <returns>A nsIInputStream </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream  GetContentStreamAttribute();
		
		/// <summary>Member SetContentStreamAttribute </summary>
		/// <param name='aContentStream'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContentStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aContentStream);
	}
}
