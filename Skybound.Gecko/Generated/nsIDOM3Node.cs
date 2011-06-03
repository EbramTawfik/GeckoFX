// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOM3Node.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOM3Node.idl
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
	
	
	/// <summary>nsIDOM3Node </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("29fb2a18-1dd2-11b2-8dd9-a6fd5d5ad12f")]
	public interface nsIDOM3Node
	{
		
		/// <summary>Member GetBaseURIAttribute </summary>
		/// <param name='aBaseURI'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetBaseURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aBaseURI);
		
		/// <summary>Member CompareDocumentPosition </summary>
		/// <param name='other'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint CompareDocumentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  other);
		
		/// <summary>Member GetTextContentAttribute </summary>
		/// <param name='aTextContent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		/// <summary>Member SetTextContentAttribute </summary>
		/// <param name='aTextContent'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTextContent);
		
		/// <summary>Member IsSameNode </summary>
		/// <param name='other'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSameNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  other);
		
		/// <summary>Member LookupPrefix </summary>
		/// <param name='namespaceURI'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI);
		
		/// <summary>Member IsDefaultNamespace </summary>
		/// <param name='namespaceURI'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI);
		
		/// <summary>Member LookupNamespaceURI </summary>
		/// <param name='prefix'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAString prefix);
		
		/// <summary>Member IsEqualNode </summary>
		/// <param name='arg'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEqualNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  arg);
		
		/// <summary>Member GetFeature </summary>
		/// <param name='feature'> </param>
		/// <param name='version'> </param>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetFeature([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>Member SetUserData </summary>
		/// <param name='key'> </param>
		/// <param name='data'> </param>
		/// <param name='handler'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant SetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAString key, [MarshalAs(UnmanagedType.Interface)] nsIVariant  data, [MarshalAs(UnmanagedType.Interface)] nsIDOMUserDataHandler  handler);
		
		/// <summary>Member GetUserData </summary>
		/// <param name='key'> </param>
		/// <returns>A nsIVariant</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant GetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAString key);
	}
}
