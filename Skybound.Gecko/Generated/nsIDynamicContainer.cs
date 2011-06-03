// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDynamicContainer.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDynamicContainer.idl
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
	
	
	/// <summary>nsIDynamicContainer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7e85d97b-4109-4ea7-afd8-bc2cd3840d70")]
	public interface nsIDynamicContainer
	{
		
		/// <summary>Member OnContainerNodeOpening </summary>
		/// <param name='aContainer'> </param>
		/// <param name='aOptions'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContainerNodeOpening([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode  aContainer, [MarshalAs(UnmanagedType.Interface)] nsINavHistoryQueryOptions  aOptions);
		
		/// <summary>Member OnContainerNodeClosed </summary>
		/// <param name='aContainer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContainerNodeClosed([MarshalAs(UnmanagedType.Interface)] nsINavHistoryContainerResultNode  aContainer);
		
		/// <summary>Member OnContainerRemoving </summary>
		/// <param name='aItemId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContainerRemoving(System.Int32  aItemId);
		
		/// <summary>Member OnContainerMoved </summary>
		/// <param name='aItemId'> </param>
		/// <param name='aNewParent'> </param>
		/// <param name='aNewIndex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnContainerMoved(System.Int32  aItemId, System.Int32  aNewParent, System.Int32  aNewIndex);
	}
}
