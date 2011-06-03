// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIWebBrowserFind.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIWebBrowserFind.idl
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
	
	
	/// <summary>nsIWebBrowserFind </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2f977d44-5485-11d4-87e2-0010a4e75ef2")]
	public interface nsIWebBrowserFind
	{
		
		/// <summary>Member FindNext </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool FindNext();
		
		/// <summary>Member GetSearchStringAttribute </summary>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetSearchStringAttribute();
		
		/// <summary>Member SetSearchStringAttribute </summary>
		/// <param name='aSearchString'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchStringAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler")] string aSearchString);
		
		/// <summary>Member GetFindBackwardsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetFindBackwardsAttribute();
		
		/// <summary>Member SetFindBackwardsAttribute </summary>
		/// <param name='aFindBackwards'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFindBackwardsAttribute(System.Boolean  aFindBackwards);
		
		/// <summary>Member GetWrapFindAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetWrapFindAttribute();
		
		/// <summary>Member SetWrapFindAttribute </summary>
		/// <param name='aWrapFind'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapFindAttribute(System.Boolean  aWrapFind);
		
		/// <summary>Member GetEntireWordAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetEntireWordAttribute();
		
		/// <summary>Member SetEntireWordAttribute </summary>
		/// <param name='aEntireWord'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEntireWordAttribute(System.Boolean  aEntireWord);
		
		/// <summary>Member GetMatchCaseAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetMatchCaseAttribute();
		
		/// <summary>Member SetMatchCaseAttribute </summary>
		/// <param name='aMatchCase'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMatchCaseAttribute(System.Boolean  aMatchCase);
		
		/// <summary>Member GetSearchFramesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSearchFramesAttribute();
		
		/// <summary>Member SetSearchFramesAttribute </summary>
		/// <param name='aSearchFrames'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchFramesAttribute(System.Boolean  aSearchFrames);
	}
	
	/// <summary>nsIWebBrowserFindInFrames </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("e0f5d182-34bc-11d5-be5b-b760676c6ebc")]
	public interface nsIWebBrowserFindInFrames
	{
		
		/// <summary>Member GetCurrentSearchFrameAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetCurrentSearchFrameAttribute();
		
		/// <summary>Member SetCurrentSearchFrameAttribute </summary>
		/// <param name='aCurrentSearchFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCurrentSearchFrameAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aCurrentSearchFrame);
		
		/// <summary>Member GetRootSearchFrameAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMWindow  GetRootSearchFrameAttribute();
		
		/// <summary>Member SetRootSearchFrameAttribute </summary>
		/// <param name='aRootSearchFrame'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRootSearchFrameAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  aRootSearchFrame);
		
		/// <summary>Member GetSearchSubframesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSearchSubframesAttribute();
		
		/// <summary>Member SetSearchSubframesAttribute </summary>
		/// <param name='aSearchSubframes'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchSubframesAttribute(System.Boolean  aSearchSubframes);
		
		/// <summary>Member GetSearchParentFramesAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetSearchParentFramesAttribute();
		
		/// <summary>Member SetSearchParentFramesAttribute </summary>
		/// <param name='aSearchParentFrames'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSearchParentFramesAttribute(System.Boolean  aSearchParentFrames);
	}
}
