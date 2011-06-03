// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWindowCreator2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWindowCreator2.idl
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
	
	
	/// <summary>nsIWindowCreator2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f673ec81-a4b0-11d6-964b-eb5a2bf216fc")]
	public interface nsIWindowCreator2 : nsIWindowCreator
	{
		
		/// <summary>Member CreateChromeWindow </summary>
		/// <param name='parent'> </param>
		/// <param name='chromeFlags'> </param>
		/// <returns>A nsIWebBrowserChrome</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIWebBrowserChrome CreateChromeWindow([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome  parent, System.UInt32  chromeFlags);
		
		/// <summary>Member CreateChromeWindow2 </summary>
		/// <param name='parent'> </param>
		/// <param name='chromeFlags'> </param>
		/// <param name='contextFlags'> </param>
		/// <param name='uri'> </param>
		/// <param name='cancel'> </param>
		/// <returns>A nsIWebBrowserChrome</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIWebBrowserChrome CreateChromeWindow2([MarshalAs(UnmanagedType.Interface)] nsIWebBrowserChrome  parent, System.UInt32  chromeFlags, System.UInt32  contextFlags, [MarshalAs(UnmanagedType.Interface)] nsIURI  uri, out System.Boolean  cancel);
	}
}
