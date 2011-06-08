// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIPrefService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIPrefService.idl
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
	
	
	/// <summary>nsIPrefService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("decb9cc7-c08f-4ea5-be91-a8fc637ce2d2")]
	public interface nsIPrefService
	{
		
		/// <summary>Member ReadUserPrefs </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadUserPrefs([MarshalAs(UnmanagedType.Interface)] nsIFile  aFile);
		
		/// <summary>Member ResetPrefs </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetPrefs();
		
		/// <summary>Member ResetUserPrefs </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetUserPrefs();
		
		/// <summary>Member SavePrefFile </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SavePrefFile([MarshalAs(UnmanagedType.Interface)] nsIFile  aFile);
		
		/// <summary>Member GetBranch </summary>
		/// <param name='aPrefRoot'> </param>
		/// <returns>A nsIPrefBranch</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrefBranch GetBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefRoot);
		
		/// <summary>Member GetDefaultBranch </summary>
		/// <param name='aPrefRoot'> </param>
		/// <returns>A nsIPrefBranch</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrefBranch GetDefaultBranch([MarshalAs(UnmanagedType.LPStr)] System.String  aPrefRoot);
	}
	
	/// <summary>nsIPrefServiceInternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("08c8cd2f-8345-45ee-938d-37ee6d3661b2")]
	public interface nsIPrefServiceInternal
	{
		
		/// <summary>Member ReadExtensionPrefs </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReadExtensionPrefs([MarshalAs(UnmanagedType.Interface)] nsILocalFile  aFile);
		
		/// <summary>Member MirrorPreferences </summary>
		/// <param name='aArray'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MirrorPreferences(System.IntPtr aArray);
		
		/// <summary>Member MirrorPreference </summary>
		/// <param name='aPrefName'> </param>
		/// <param name='aPref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MirrorPreference([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPrefName, System.IntPtr aPref);
		
		/// <summary>Member PrefHasUserValue </summary>
		/// <param name='aPrefName'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool PrefHasUserValue([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPrefName);
		
		/// <summary>Member SetPreference </summary>
		/// <param name='aPref'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPreference(System.IntPtr aPref);
		
		/// <summary>Member ClearContentPref </summary>
		/// <param name='aPrefName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClearContentPref([MarshalAs(UnmanagedType.LPStruct)] nsAString  aPrefName);
	}
}