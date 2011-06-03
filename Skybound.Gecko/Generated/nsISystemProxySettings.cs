// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISystemProxySettings.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISystemProxySettings.idl
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
	
	
	/// <summary>nsISystemProxySettings </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a9f3ae38-b769-4e0b-9317-578388e326c9")]
	public interface nsISystemProxySettings
	{
		
		/// <summary>Member GetPACURIAttribute </summary>
		/// <param name='aPACURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPACURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPACURI);
		
		/// <summary>Member GetProxyForURI </summary>
		/// <param name='aURI'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString GetProxyForURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
	}
}
