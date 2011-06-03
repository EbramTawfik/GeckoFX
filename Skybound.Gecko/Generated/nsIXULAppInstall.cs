// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXULAppInstall.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXULAppInstall.idl
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
	
	
	/// <summary>nsIXULAppInstall </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("800ace15-6b38-48c4-b057-7928378f6cd2")]
	public interface nsIXULAppInstall
	{
		
		/// <summary>Member InstallApplication </summary>
		/// <param name='aAppFile'> </param>
		/// <param name='aDirectory'> </param>
		/// <param name='aLeafName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InstallApplication([MarshalAs(UnmanagedType.Interface)] nsIFile  aAppFile, [MarshalAs(UnmanagedType.Interface)] nsIFile  aDirectory, [MarshalAs(UnmanagedType.LPStruct)] nsAString aLeafName);
	}
}
