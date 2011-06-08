// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIEmbeddingSiteWindow.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIEmbeddingSiteWindow.idl
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
	
	
	/// <summary>nsIEmbeddingSiteWindow </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3E5432CD-9568-4bd1-8CBE-D50ABA110743")]
	public interface nsIEmbeddingSiteWindow
	{
		
		/// <summary>Member SetDimensions </summary>
		/// <param name='flags'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='cx'> </param>
		/// <param name='cy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDimensions(System.UInt32  flags, System.Int32  x, System.Int32  y, System.Int32  cx, System.Int32  cy);
		
		/// <summary>Member GetDimensions </summary>
		/// <param name='flags'> </param>
		/// <param name='x'> </param>
		/// <param name='y'> </param>
		/// <param name='cx'> </param>
		/// <param name='cy'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDimensions(System.UInt32  flags, out System.Int32  x, out System.Int32  y, out System.Int32  cx, out System.Int32  cy);
		
		/// <summary>Member SetFocus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFocus();
		
		/// <summary>Member GetVisibilityAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetVisibilityAttribute();
		
		/// <summary>Member SetVisibilityAttribute </summary>
		/// <param name='aVisibility'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVisibilityAttribute(System.Boolean  aVisibility);
		
		/// <summary>Member GetTitleAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTitleAttribute();
		
		/// <summary>Member SetTitleAttribute </summary>
		/// <param name='aTitle'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTitle);
		
		/// <summary>Member GetSiteWindowAttribute </summary>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  GetSiteWindowAttribute();
	}
}