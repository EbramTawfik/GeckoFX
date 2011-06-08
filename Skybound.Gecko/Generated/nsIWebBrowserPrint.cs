// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWebBrowserPrint.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWebBrowserPrint.idl
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
	
	
	/// <summary>nsIWebBrowserPrint </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9A7CA4B0-FBBA-11d4-A869-00105A183419")]
	public interface nsIWebBrowserPrint
	{
		
		/// <summary>Member GetGlobalPrintSettingsAttribute </summary>
		/// <returns>A nsIPrintSettings </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings  GetGlobalPrintSettingsAttribute();
		
		/// <summary>Member GetCurrentPrintSettingsAttribute </summary>
		/// <returns>A nsIPrintSettings </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIPrintSettings  GetCurrentPrintSettingsAttribute();
		
		/// <summary>Member GetCurrentChildDOMWindowAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetCurrentChildDOMWindowAttribute();
		
		/// <summary>Member GetDoingPrintAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDoingPrintAttribute();
		
		/// <summary>Member GetDoingPrintPreviewAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetDoingPrintPreviewAttribute();
		
		/// <summary>Member GetIsFramesetDocumentAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsFramesetDocumentAttribute();
		
		/// <summary>Member GetIsFramesetFrameSelectedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsFramesetFrameSelectedAttribute();
		
		/// <summary>Member GetIsIFrameSelectedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsIFrameSelectedAttribute();
		
		/// <summary>Member GetIsRangeSelectionAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsRangeSelectionAttribute();
		
		/// <summary>Member GetPrintPreviewNumPagesAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetPrintPreviewNumPagesAttribute();
		
		/// <summary>Member Print </summary>
		/// <param name='aThePrintSettings'> </param>
		/// <param name='aWPListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Print([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener  aWPListener);
		
		/// <summary>Member PrintPreview </summary>
		/// <param name='aThePrintSettings'> </param>
		/// <param name='aChildDOMWin'> </param>
		/// <param name='aWPListener'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreview([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings  aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aChildDOMWin, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener  aWPListener);
		
		/// <summary>Member PrintPreviewNavigate </summary>
		/// <param name='aNavType'> </param>
		/// <param name='aPageNum'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PrintPreviewNavigate(short aNavType, System.Int32  aPageNum);
		
		/// <summary>Member Cancel </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Cancel();
		
		/// <summary>Member EnumerateDocumentNames </summary>
		/// <param name='aCount'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string EnumerateDocumentNames(out System.UInt32  aCount);
		
		/// <summary>Member ExitPrintPreview </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ExitPrintPreview();
	}
}