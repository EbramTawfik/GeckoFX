// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMNamedNodeMap.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMNamedNodeMap.idl
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
	
	
	/// <summary>nsIDOMNamedNodeMap </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf907b-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMNamedNodeMap
	{
		
		/// <summary>Member GetNamedItem </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetNamedItem </summary>
		/// <param name='arg'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItem([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  arg);
		
		/// <summary>Member RemoveNamedItem </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member Item </summary>
		/// <param name='index'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(System.UInt32  index);
		
		/// <summary>Member GetLengthAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetLengthAttribute();
		
		/// <summary>Member GetNamedItemNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member SetNamedItemNS </summary>
		/// <param name='arg'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode SetNamedItemNS([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  arg);
		
		/// <summary>Member RemoveNamedItemNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='localName'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode RemoveNamedItemNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
	}
}