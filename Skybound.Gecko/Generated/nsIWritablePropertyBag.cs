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
// Generated by IDLImporter from file nsIWritablePropertyBag.idl
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
    ///nsIVariant based writable Property Bag support. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("96fc4671-eeb4-4823-9421-e50fb70ad353")]
	public interface nsIWritablePropertyBag : nsIPropertyBag
	{
		
		/// <summary>
        /// Get a nsISimpleEnumerator whose elements are nsIProperty objects.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISimpleEnumerator  GetEnumeratorAttribute();
		
		/// <summary>
        /// Get a property value for the given name.
        /// @throws NS_ERROR_FAILURE if a property with that name doesn't
        /// exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Set a property with the given name to the given value.  If
        /// a property already exists with the given name, it is
        /// overwritten.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.Interface)] nsIVariant  value);
		
		/// <summary>
        /// Delete a property with the given name.
        /// @throws NS_ERROR_FAILURE if a property with that name doesn't
        /// exist.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeleteProperty([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
	}
}
