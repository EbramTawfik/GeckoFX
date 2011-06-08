// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDOMWindow2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMWindow2.idl
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
	
	
	/// <summary>nsIDOMWindow2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("efff0d88-3b94-4375-bdeb-676a847ecd7d")]
	public interface nsIDOMWindow2 : nsIDOMWindow
	{
		
		/// <summary>Member GetDocumentAttribute </summary>
		/// <returns>A nsIDOMDocument </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument  GetDocumentAttribute();
		
		/// <summary>Member GetParentAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow  GetParentAttribute();
		
		/// <summary>Member GetTopAttribute </summary>
		/// <returns>A nsIDOMWindow </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow  GetTopAttribute();
		
		/// <summary>Member GetScrollbarsAttribute </summary>
		/// <returns>A nsIDOMBarProp </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMBarProp  GetScrollbarsAttribute();
		
		/// <summary>Member GetFramesAttribute </summary>
		/// <returns>A nsIDOMWindowCollection </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindowCollection  GetFramesAttribute();
		
		/// <summary>Member GetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member SetNameAttribute </summary>
		/// <param name='aName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		/// <summary>Member GetTextZoomAttribute </summary>
		/// <returns>A System.Double</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new double GetTextZoomAttribute();
		
		/// <summary>Member SetTextZoomAttribute </summary>
		/// <param name='aTextZoom'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextZoomAttribute(double aTextZoom);
		
		/// <summary>Member GetScrollXAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetScrollXAttribute();
		
		/// <summary>Member GetScrollYAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.Int32  GetScrollYAttribute();
		
		/// <summary>Member ScrollTo </summary>
		/// <param name='xScroll'> </param>
		/// <param name='yScroll'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollTo(System.Int32  xScroll, System.Int32  yScroll);
		
		/// <summary>Member ScrollBy </summary>
		/// <param name='xScrollDif'> </param>
		/// <param name='yScrollDif'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollBy(System.Int32  xScrollDif, System.Int32  yScrollDif);
		
		/// <summary>Member GetSelection </summary>
		/// <returns>A nsISelection</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISelection GetSelection();
		
		/// <summary>Member ScrollByLines </summary>
		/// <param name='numLines'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByLines(System.Int32  numLines);
		
		/// <summary>Member ScrollByPages </summary>
		/// <param name='numPages'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ScrollByPages(System.Int32  numPages);
		
		/// <summary>Member SizeToContent </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SizeToContent();
		
		/// <summary>Member GetWindowRootAttribute </summary>
		/// <returns>A nsIDOMEventTarget </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMEventTarget  GetWindowRootAttribute();
		
		/// <summary>Member GetApplicationCacheAttribute </summary>
		/// <returns>A nsIDOMOfflineResourceList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMOfflineResourceList  GetApplicationCacheAttribute();
		
		/// <summary>Member CreateBlobURL </summary>
		/// <param name='blob'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString CreateBlobURL([MarshalAs(UnmanagedType.Interface)] nsIDOMBlob  blob);
		
		/// <summary>Member RevokeBlobURL </summary>
		/// <param name='URL'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RevokeBlobURL([MarshalAs(UnmanagedType.LPStruct)] nsAString URL);
	}
}