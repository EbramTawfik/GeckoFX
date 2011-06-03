// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISidebar.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISidebar.idl
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
	
	
	/// <summary>nsISidebar </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("67cf6231-c303-4f7e-b9b1-a0e87772ecfd")]
	public interface nsISidebar
	{
		
		/// <summary>Member AddPanel </summary>
		/// <param name='aTitle'> </param>
		/// <param name='aContentURL'> </param>
		/// <param name='aCustomizeURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPanel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTitle, [MarshalAs(UnmanagedType.LPStr)] System.String  aContentURL, [MarshalAs(UnmanagedType.LPStr)] System.String  aCustomizeURL);
		
		/// <summary>Member AddPersistentPanel </summary>
		/// <param name='aTitle'> </param>
		/// <param name='aContentURL'> </param>
		/// <param name='aCustomizeURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPersistentPanel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aTitle, [MarshalAs(UnmanagedType.LPStr)] System.String  aContentURL, [MarshalAs(UnmanagedType.LPStr)] System.String  aCustomizeURL);
		
		/// <summary>Member AddSearchEngine </summary>
		/// <param name='engineURL'> </param>
		/// <param name='iconURL'> </param>
		/// <param name='suggestedTitle'> </param>
		/// <param name='suggestedCategory'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSearchEngine([MarshalAs(UnmanagedType.LPStr)] System.String  engineURL, [MarshalAs(UnmanagedType.LPStr)] System.String  iconURL, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string suggestedTitle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string suggestedCategory);
		
		/// <summary>Member AddMicrosummaryGenerator </summary>
		/// <param name='generatorURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddMicrosummaryGenerator([MarshalAs(UnmanagedType.LPStr)] System.String  generatorURL);
	}
	
	/// <summary>nsISidebarExternal </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4350fb73-9305-41df-a669-11d26222d420")]
	public interface nsISidebarExternal
	{
		
		/// <summary>Member AddSearchProvider </summary>
		/// <param name='aDescriptionURL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddSearchProvider([MarshalAs(UnmanagedType.LPStr)] System.String  aDescriptionURL);
		
		/// <summary>Member IsSearchProviderInstalled </summary>
		/// <param name='aSearchURL'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint IsSearchProviderInstalled([MarshalAs(UnmanagedType.LPStr)] System.String  aSearchURL);
	}
}
