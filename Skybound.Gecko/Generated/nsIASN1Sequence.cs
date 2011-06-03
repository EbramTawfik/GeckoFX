// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIASN1Sequence.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIASN1Sequence.idl
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
	
	
	/// <summary>nsIASN1Sequence </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b6b957e6-1dd1-11b2-89d7-e30624f50b00")]
	public interface nsIASN1Sequence : nsIASN1Object
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetTypeAttribute();
		
		/// <summary>Member SetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTypeAttribute(System.UInt32  aType);
		
		/// <summary>Member GetTagAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.UInt32  GetTagAttribute();
		
		/// <summary>Member SetTagAttribute </summary>
		/// <param name='aTag'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTagAttribute(System.UInt32  aTag);
		
		/// <summary>Member GetDisplayNameAttribute </summary>
		/// <param name='aDisplayName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayName);
		
		/// <summary>Member SetDisplayNameAttribute </summary>
		/// <param name='aDisplayName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisplayNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayName);
		
		/// <summary>Member GetDisplayValueAttribute </summary>
		/// <param name='aDisplayValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayValue);
		
		/// <summary>Member SetDisplayValueAttribute </summary>
		/// <param name='aDisplayValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDisplayValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDisplayValue);
		
		/// <summary>Member GetASN1ObjectsAttribute </summary>
		/// <returns>A nsIMutableArray </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMutableArray  GetASN1ObjectsAttribute();
		
		/// <summary>Member SetASN1ObjectsAttribute </summary>
		/// <param name='aASN1Objects'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetASN1ObjectsAttribute([MarshalAs(UnmanagedType.Interface)] nsIMutableArray  aASN1Objects);
		
		/// <summary>Member GetIsValidContainerAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsValidContainerAttribute();
		
		/// <summary>Member SetIsValidContainerAttribute </summary>
		/// <param name='aIsValidContainer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsValidContainerAttribute(System.Boolean  aIsValidContainer);
		
		/// <summary>Member GetIsExpandedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsExpandedAttribute();
		
		/// <summary>Member SetIsExpandedAttribute </summary>
		/// <param name='aIsExpanded'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIsExpandedAttribute(System.Boolean  aIsExpanded);
	}
}
