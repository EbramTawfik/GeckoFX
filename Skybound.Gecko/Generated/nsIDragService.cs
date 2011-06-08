// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDragService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDragService.idl
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
	
	
	/// <summary>nsIDragService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("82B58ADA-F490-4C3D-B737-1057C4F1D052")]
	public interface nsIDragService
	{
		
		/// <summary>Member InvokeDragSession </summary>
		/// <param name='aDOMNode'> </param>
		/// <param name='aTransferables'> </param>
		/// <param name='aRegion'> </param>
		/// <param name='aActionType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSession([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray  aTransferables, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion  aRegion, System.UInt32  aActionType);
		
		/// <summary>Member InvokeDragSessionWithImage </summary>
		/// <param name='aDOMNode'> </param>
		/// <param name='aTransferableArray'> </param>
		/// <param name='aRegion'> </param>
		/// <param name='aActionType'> </param>
		/// <param name='aImage'> </param>
		/// <param name='aImageX'> </param>
		/// <param name='aImageY'> </param>
		/// <param name='aDragEvent'> </param>
		/// <param name='aDataTransfer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSessionWithImage([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aDOMNode, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray  aTransferableArray, [MarshalAs(UnmanagedType.Interface)] nsIScriptableRegion  aRegion, System.UInt32  aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  aImage, System.Int32  aImageX, System.Int32  aImageY, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent  aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer  aDataTransfer);
		
		/// <summary>Member InvokeDragSessionWithSelection </summary>
		/// <param name='aSelection'> </param>
		/// <param name='aTransferableArray'> </param>
		/// <param name='aActionType'> </param>
		/// <param name='aDragEvent'> </param>
		/// <param name='aDataTransfer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InvokeDragSessionWithSelection([MarshalAs(UnmanagedType.Interface)] nsISelection  aSelection, [MarshalAs(UnmanagedType.Interface)] nsISupportsArray  aTransferableArray, System.UInt32  aActionType, [MarshalAs(UnmanagedType.Interface)] nsIDOMDragEvent  aDragEvent, [MarshalAs(UnmanagedType.Interface)] nsIDOMDataTransfer  aDataTransfer);
		
		/// <summary>Member GetCurrentSession </summary>
		/// <returns>A nsIDragSession</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDragSession GetCurrentSession();
		
		/// <summary>Member StartDragSession </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StartDragSession();
		
		/// <summary>Member EndDragSession </summary>
		/// <param name='aDoneDrag'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EndDragSession(System.Boolean  aDoneDrag);
		
		/// <summary>Member FireDragEventAtSource </summary>
		/// <param name='aMsg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FireDragEventAtSource(System.UInt32  aMsg);
		
		/// <summary>Member Suppress </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Suppress();
		
		/// <summary>Member Unsuppress </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Unsuppress();
	}
}