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
// Generated by IDLImporter from file nsIIDBObjectStore.idl
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
	
	
	/// <summary>
    /// nsIIDBObjectStore interface.  See
    /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
    /// for more information.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("6a65dc92-66e3-407a-a370-590a6c54664a")]
	public interface nsIIDBObjectStore
	{
		
		/// <summary>
        /// nsIIDBObjectStore interface.  See
        /// http://dev.w3.org/2006/webapi/WebSimpleDB/#idl-def-nsIIDBObjectStore
        /// for more information.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetKeyPathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aKeyPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetIndexNamesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBTransaction  GetTransactionAttribute();
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == value for key
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Get([MarshalAs(UnmanagedType.Interface)] nsIVariant  key);
		
		/// <summary>
        ///unlimited </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest GetAll([MarshalAs(UnmanagedType.Interface)] nsIIDBKeyRange  key, System.UInt32  limit);
		
		/// <summary>
        ///undefined </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Add(System.IntPtr value, System.IntPtr key);
		
		/// <summary>
        ///undefined </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Put(System.IntPtr value, System.IntPtr key);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Delete(System.IntPtr key);
		
		/// <summary>
        /// Success fires IDBTransactionEvent, result == null
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest Clear();
		
		/// <summary>
        ///NEXT </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBRequest OpenCursor([MarshalAs(UnmanagedType.Interface)] nsIIDBKeyRange  range, ushort direction);
		
		/// <summary>
        ///none </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex CreateIndex([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString keyPath, System.IntPtr options);
		
		/// <summary>
        /// Returns object immediately
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIIDBIndex Index([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteIndex([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
}
