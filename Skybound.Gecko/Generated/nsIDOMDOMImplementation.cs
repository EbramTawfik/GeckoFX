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
// Generated by IDLImporter from file nsIDOMDOMImplementation.idl
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
    /// The nsIDOMDOMImplementation interface provides a number of methods for
    /// performing operations that are independent of any particular instance
    /// of the document object model.
    ///
    /// For more information on this interface please see
    /// http://www.w3.org/TR/DOM-Level-2-Core/
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("03a6f574-99ec-42f8-9e6c-812a4a9bcbf7")]
	public interface nsIDOMDOMImplementation
	{
		
		/// <summary>
        /// The nsIDOMDOMImplementation interface provides a number of methods for
        /// performing operations that are independent of any particular instance
        /// of the document object model.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HasFeature([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocumentType CreateDocumentType([MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAString publicId, [MarshalAs(UnmanagedType.LPStruct)] nsAString systemId);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument CreateDocument([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName, [MarshalAs(UnmanagedType.Interface)] nsIDOMDocumentType  doctype);
		
		/// <summary>
        /// Returns an HTML document with a basic DOM already constructed and with an
        /// appropriate title element.
        ///
        /// @param title the title of the Document
        /// @see <http://www.whatwg.org/html/#creating-documents>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMDocument CreateHTMLDocument([MarshalAs(UnmanagedType.LPStruct)] nsAString title);
	}
}
