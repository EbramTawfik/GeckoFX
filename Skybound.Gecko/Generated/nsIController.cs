// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIController.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIController.idl
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
	
	
	/// <summary>nsIController </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("D5B61B82-1DA4-11d3-BF87-00105A1B0627")]
	public interface nsIController
	{
		
		/// <summary>Member IsCommandEnabled </summary>
		/// <param name='command'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandEnabled([MarshalAs(UnmanagedType.LPStr)] System.String  command);
		
		/// <summary>Member SupportsCommand </summary>
		/// <param name='command'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool SupportsCommand([MarshalAs(UnmanagedType.LPStr)] System.String  command);
		
		/// <summary>Member DoCommand </summary>
		/// <param name='command'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand([MarshalAs(UnmanagedType.LPStr)] System.String  command);
		
		/// <summary>Member OnEvent </summary>
		/// <param name='eventName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnEvent([MarshalAs(UnmanagedType.LPStr)] System.String  eventName);
	}
	
	/// <summary>nsICommandController </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("EBE55080-C8A9-11D5-A73C-DD620D6E04BC")]
	public interface nsICommandController
	{
		
		/// <summary>Member GetCommandStateWithParams </summary>
		/// <param name='command'> </param>
		/// <param name='aCommandParams'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCommandStateWithParams([MarshalAs(UnmanagedType.LPStr)] System.String  command, [MarshalAs(UnmanagedType.Interface)] nsICommandParams  aCommandParams);
		
		/// <summary>Member DoCommandWithParams </summary>
		/// <param name='command'> </param>
		/// <param name='aCommandParams'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommandWithParams([MarshalAs(UnmanagedType.LPStr)] System.String  command, [MarshalAs(UnmanagedType.Interface)] nsICommandParams  aCommandParams);
	}
	
	/// <summary>nsIControllerCommandGroup </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9F82C404-1C7B-11D5-A73C-ECA43CA836FC")]
	public interface nsIControllerCommandGroup
	{
		
		/// <summary>Member AddCommandToGroup </summary>
		/// <param name='aCommand'> </param>
		/// <param name='aGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddCommandToGroup([MarshalAs(UnmanagedType.LPStr)] System.String  aCommand, [MarshalAs(UnmanagedType.LPStr)] System.String  aGroup);
		
		/// <summary>Member RemoveCommandFromGroup </summary>
		/// <param name='aCommand'> </param>
		/// <param name='aGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveCommandFromGroup([MarshalAs(UnmanagedType.LPStr)] System.String  aCommand, [MarshalAs(UnmanagedType.LPStr)] System.String  aGroup);
		
		/// <summary>Member IsCommandInGroup </summary>
		/// <param name='aCommand'> </param>
		/// <param name='aGroup'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsCommandInGroup([MarshalAs(UnmanagedType.LPStr)] System.String  aCommand, [MarshalAs(UnmanagedType.LPStr)] System.String  aGroup);
		
		/// <summary>Member GetGroupsEnumerator </summary>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetGroupsEnumerator();
		
		/// <summary>Member GetEnumeratorForGroup </summary>
		/// <param name='aGroup'> </param>
		/// <returns>A nsISimpleEnumerator</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetEnumeratorForGroup([MarshalAs(UnmanagedType.LPStr)] System.String  aGroup);
	}
}
