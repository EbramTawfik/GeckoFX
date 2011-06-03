// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMTransitionEvent.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMTransitionEvent.idl
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
	
	
	/// <summary>nsIDOMTransitionEvent </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3e49ea4c-6f23-4aff-bd8f-e587edf514ec")]
	public interface nsIDOMTransitionEvent : nsIDOMEvent
	{
		
		/// <summary>Member GetTypeAttribute </summary>
		/// <param name='aType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aType);
		
		/// <summary>Member GetTargetAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget  GetTargetAttribute();
		
		/// <summary>Member GetCurrentTargetAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEventTarget  GetCurrentTargetAttribute();
		
		/// <summary>Member GetEventPhaseAttribute </summary>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetEventPhaseAttribute();
		
		/// <summary>Member GetBubblesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetBubblesAttribute();
		
		/// <summary>Member GetCancelableAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Boolean  GetCancelableAttribute();
		
		/// <summary>Member GetTimeStampAttribute </summary>
		/// <returns>A System.Int64 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int64  GetTimeStampAttribute();
		
		/// <summary>Member StopPropagation </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void StopPropagation();
		
		/// <summary>Member PreventDefault </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void PreventDefault();
		
		/// <summary>Member InitEvent </summary>
		/// <param name='eventTypeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void InitEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString eventTypeArg, System.Boolean  canBubbleArg, System.Boolean  cancelableArg);
		
		/// <summary>Member GetPropertyNameAttribute </summary>
		/// <param name='aPropertyName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPropertyNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPropertyName);
		
		/// <summary>Member GetElapsedTimeAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		double GetElapsedTimeAttribute();
		
		/// <summary>Member InitTransitionEvent </summary>
		/// <param name='typeArg'> </param>
		/// <param name='canBubbleArg'> </param>
		/// <param name='cancelableArg'> </param>
		/// <param name='propertyNameArg'> </param>
		/// <param name='elapsedTimeArg'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitTransitionEvent([MarshalAs(UnmanagedType.LPStruct)] nsAString typeArg, System.Boolean  canBubbleArg, System.Boolean  cancelableArg, [MarshalAs(UnmanagedType.LPStruct)] nsAString propertyNameArg, double elapsedTimeArg);
	}
}
