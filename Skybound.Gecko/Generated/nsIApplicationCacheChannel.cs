// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIApplicationCacheChannel.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIApplicationCacheChannel.idl
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
	
	
	/// <summary>nsIApplicationCacheChannel </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8d9024e6-ab01-442d-8119-2f55d55d91b0")]
	public interface nsIApplicationCacheChannel : nsIApplicationCacheContainer
	{
		
		/// <summary>Member GetApplicationCacheAttribute </summary>
		/// <returns>A nsIApplicationCache </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIApplicationCache  GetApplicationCacheAttribute();
		
		/// <summary>Member SetApplicationCacheAttribute </summary>
		/// <param name='aApplicationCache'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetApplicationCacheAttribute([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache  aApplicationCache);
		
		/// <summary>Member GetLoadedFromApplicationCacheAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetLoadedFromApplicationCacheAttribute();
		
		/// <summary>Member GetInheritApplicationCacheAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetInheritApplicationCacheAttribute();
		
		/// <summary>Member SetInheritApplicationCacheAttribute </summary>
		/// <param name='aInheritApplicationCache'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInheritApplicationCacheAttribute(System.Boolean  aInheritApplicationCache);
		
		/// <summary>Member GetChooseApplicationCacheAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetChooseApplicationCacheAttribute();
		
		/// <summary>Member SetChooseApplicationCacheAttribute </summary>
		/// <param name='aChooseApplicationCache'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetChooseApplicationCacheAttribute(System.Boolean  aChooseApplicationCache);
		
		/// <summary>Member MarkOfflineCacheEntryAsForeign </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MarkOfflineCacheEntryAsForeign();
	}
}
