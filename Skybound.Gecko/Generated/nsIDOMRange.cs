// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIDOMRange.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>
    /// The nsIDOMRange interface is an interface to a DOM range object.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Traversal-Range/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a6cf90ce-15b3-11d2-932e-00805f8add32")]
	public interface nsIDOMRange
	{
		
		/// <summary>
        /// The nsIDOMRange interface is an interface to a DOM range object.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Traversal-Range/
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetStartContainerAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetStartOffsetAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetEndContainerAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetEndOffsetAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCollapsedAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode GetCommonAncestorContainerAttribute();
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStart([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEnd([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode, int offset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStartAfter([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetEndAfter([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Collapse([MarshalAs(UnmanagedType.U1)] bool toStart);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectNodeContents([MarshalAs(UnmanagedType.Interface)] nsIDOMNode refNode);
		
		/// <summary>
        /// CompareHow
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short CompareBoundaryPoints(ushort how, [MarshalAs(UnmanagedType.Interface)] nsIDOMRange sourceRange);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment ExtractContents();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentFragment CloneContents();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InsertNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newNode);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SurroundContents([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newParent);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMRange CloneRange();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Detach();
	}
}
