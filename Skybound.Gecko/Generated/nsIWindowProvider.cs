// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWindowProvider.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWindowProvider.idl
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
	
	
	/// <summary>nsIWindowProvider </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f607bd66-08e5-4d2e-ad83-9f9f3ca17658")]
	public interface nsIWindowProvider
	{
		
		/// <summary>Member ProvideWindow </summary>
		/// <param name='aParent'> </param>
		/// <param name='aChromeFlags'> </param>
		/// <param name='aCalledFromJS'> </param>
		/// <param name='aPositionSpecified'> </param>
		/// <param name='aSizeSpecified'> </param>
		/// <param name='aURI'> </param>
		/// <param name='aName'> </param>
		/// <param name='aFeatures'> </param>
		/// <param name='aWindowIsNew'> </param>
		/// <returns>A nsIDOMWindow</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow ProvideWindow([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aParent, System.UInt32  aChromeFlags, System.Boolean  aCalledFromJS, System.Boolean  aPositionSpecified, System.Boolean  aSizeSpecified, [MarshalAs(UnmanagedType.Interface)] nsIURI  aURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString aName, [MarshalAs(UnmanagedType.LPStruct)] nsAString  aFeatures, out System.Boolean  aWindowIsNew);
	}
}
