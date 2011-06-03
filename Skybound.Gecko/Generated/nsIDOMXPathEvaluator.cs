// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMXPathEvaluator.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMXPathEvaluator.idl
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
	
	
	/// <summary>nsIDOMXPathEvaluator </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("75506f8a-b504-11d5-a7f2-ca108ab8b6fc")]
	public interface nsIDOMXPathEvaluator
	{
		
		/// <summary>Member CreateExpression </summary>
		/// <param name='expression'> </param>
		/// <param name='resolver'> </param>
		/// <returns>A nsIDOMXPathExpression</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMXPathExpression CreateExpression([MarshalAs(UnmanagedType.LPStruct)] nsAString expression, [MarshalAs(UnmanagedType.Interface)] nsIDOMXPathNSResolver  resolver);
		
		/// <summary>Member CreateNSResolver </summary>
		/// <param name='nodeResolver'> </param>
		/// <returns>A nsIDOMXPathNSResolver</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMXPathNSResolver CreateNSResolver([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  nodeResolver);
		
		/// <summary>Member Evaluate </summary>
		/// <param name='expression'> </param>
		/// <param name='contextNode'> </param>
		/// <param name='resolver'> </param>
		/// <param name='type'> </param>
		/// <param name='result'> </param>
		/// <returns>A nsISupports</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports Evaluate([MarshalAs(UnmanagedType.LPStruct)] nsAString expression, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  contextNode, [MarshalAs(UnmanagedType.Interface)] nsIDOMXPathNSResolver  resolver, ushort type, [MarshalAs(UnmanagedType.Interface)] nsISupports  result);
	}
}
