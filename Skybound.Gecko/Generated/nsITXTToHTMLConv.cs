// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsITXTToHTMLConv.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsITXTToHTMLConv.idl
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
	
	
	/// <summary>nsITXTToHTMLConv </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("933355f6-1dd2-11b2-a9b0-d335b9e35983")]
	public interface nsITXTToHTMLConv : nsIStreamConverter
	{
		
		/// <summary>Member OnStartRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStartRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>Member OnStopRequest </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aStatusCode'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnStopRequest([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, System.Int32  aStatusCode);
		
		/// <summary>Member OnDataAvailable </summary>
		/// <param name='aRequest'> </param>
		/// <param name='aContext'> </param>
		/// <param name='aInputStream'> </param>
		/// <param name='aOffset'> </param>
		/// <param name='aCount'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OnDataAvailable([MarshalAs(UnmanagedType.Interface)] nsIRequest  aRequest, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext, [MarshalAs(UnmanagedType.Interface)] nsIInputStream  aInputStream, System.UInt32  aOffset, System.UInt32  aCount);
		
		/// <summary>Member Convert </summary>
		/// <param name='aFromStream'> </param>
		/// <param name='aFromType'> </param>
		/// <param name='aToType'> </param>
		/// <param name='aCtxt'> </param>
		/// <returns>A nsIInputStream</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aFromStream, [MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aCtxt);
		
		/// <summary>Member AsyncConvertData </summary>
		/// <param name='aFromType'> </param>
		/// <param name='aToType'> </param>
		/// <param name='aListener'> </param>
		/// <param name='aCtxt'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener  aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports  aCtxt);
		
		/// <summary>Member SetTitle </summary>
		/// <param name='text'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTitle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string text);
		
		/// <summary>Member PreFormatHTML </summary>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PreFormatHTML(System.Boolean  value);
	}
}
