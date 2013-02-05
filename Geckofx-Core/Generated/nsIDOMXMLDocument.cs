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
// Generated by IDLImporter from file nsIDOMXMLDocument.idl
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
	
	
	/// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("18C55EFC-560B-4BDD-9776-A8D239EF7052")]
	public interface nsIDOMXMLDocument : nsIDOMDocument
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetParentNodeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetParentElementAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetChildNodesAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetFirstChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetLastChildAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetPreviousSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode GetNextSiblingAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument GetOwnerDocumentAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode refChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode oldChild);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode newChild);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>
        /// Modified in DOM Level 4:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode([MarshalAs(UnmanagedType.U1)] bool deep, int argc);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase feature, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNamespaceURI);
		
		/// <summary>
        /// Modified in DOM Core
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// nsINode::GetBaseURI
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetBaseURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aBaseURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint CompareDocumentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMNode other);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTextContentAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTextContent);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDefaultNamespace([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void LookupNamespaceURI([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase prefix, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsEqualNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode arg);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant SetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key, [MarshalAs(UnmanagedType.Interface)] nsIVariant data, [MarshalAs(UnmanagedType.Interface)] nsIDOMUserDataHandler handler);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIVariant GetUserData([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase key);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool Contains([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aOther);
		
		/// <summary>
        /// The nsIDOMDocument interface represents the entire HTML or XML document.
        /// Conceptually, it is the root of the document tree, and provides the
        /// primary access to the document's data.
        /// Since elements, text nodes, comments, processing instructions, etc.
        /// cannot exist outside the context of a Document, the nsIDOMDocument
        /// interface also contains the factory methods needed to create these
        /// objects.
        ///
        /// For more information on this interface please see
        /// http://dvcs.w3.org/hg/domcore/raw-file/tip/Overview.html
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentType GetDoctypeAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDOMImplementation GetImplementationAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetDocumentElementAttribute();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElement([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase tagName);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocumentFragment CreateDocumentFragment();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMText CreateTextNode([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMComment CreateComment([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMCDATASection CreateCDATASection([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMProcessingInstruction CreateProcessingInstruction([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase target, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase data);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase tagname);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ImportNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode importedNode, [MarshalAs(UnmanagedType.U1)] bool deep, int argc);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement CreateElementNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr CreateAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase qualifiedName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetElementById([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase elementId);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetInputEncodingAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInputEncoding);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDocumentURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDocumentURI);
		
		/// <summary>
        /// Introduced in DOM Level 3:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AdoptNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode source);
		
		/// <summary>
        /// Create a range
        ///
        /// @see http://html5.org/specs/dom-range.html#dom-document-createrange
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMRange CreateRange();
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeIterator CreateNodeIterator([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, int argc);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMTreeWalker CreateTreeWalker([MarshalAs(UnmanagedType.Interface)] nsIDOMNode root, uint whatToShow, [MarshalAs(UnmanagedType.Interface)] nsIDOMNodeFilter filter, int argc);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMEvent CreateEvent([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase eventType);
		
		/// <summary>
        /// The window associated with this document.
        ///
        /// @see <http://www.whatwg.org/html/#dom-document-defaultview>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMWindow GetDefaultViewAttribute();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-characterset>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetCharacterSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aCharacterSet);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-dir>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDir);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-dir>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aDir);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-location>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMLocation GetLocationAttribute();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#document.title>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#document.title>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetTitleAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aTitle);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-readystate>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetReadyStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReadyState);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-lastmodified>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLastModifiedAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLastModified);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-referrer>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetReferrerAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aReferrer);
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-hasfocus>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasFocus();
		
		/// <summary>
        /// @see <http://www.whatwg.org/html/#dom-document-activeelement>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetActiveElementAttribute();
		
		/// <summary>
        /// Retrieve elements matching all classes listed in a
        /// space-separated string.
        ///
        /// @see <http://www.whatwg.org/html/#dom-document-getelementsbyclassname>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByClassName([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase classes);
		
		/// <summary>
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-stylesheets>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMStyleSheetList GetStyleSheetsAttribute();
		
		/// <summary>
        /// This attribute must return the preferred style sheet set as set by the
        /// author. It is determined from the order of style sheet declarations and
        /// the Default-Style HTTP headers, as eventually defined elsewhere in the Web
        /// Apps 1.0 specification. If there is no preferred style sheet set, this
        /// attribute must return the empty string. The case of this attribute must
        /// exactly match the case given by the author where the preferred style sheet
        /// is specified or implied. This attribute must never return null.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-preferredStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPreferredStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPreferredStyleSheetSet);
		
		/// <summary>
        /// This attribute indicates which style sheet set is in use. This attribute
        /// is live; changing the disabled attribute on style sheets directly will
        /// change the value of this attribute.
        ///
        /// If all the sheets that are enabled and have a title have the same title
        /// (by case-sensitive comparisons) then the value of this attribute must be
        /// exactly equal to the title of the first enabled style sheet with a title
        /// in the styleSheets list. Otherwise, if style sheets from different sets
        /// are enabled, then the return value must be null (there is no way to
        /// determine what the currently selected style sheet set is in those
        /// conditions). Otherwise, either all style sheets that have a title are
        /// disabled, or there are no alternate style sheets, and
        /// selectedStyleSheetSet must return the empty string.
        ///
        /// Setting this attribute to the null value must have no effect.
        ///
        /// Setting this attribute to a non-null value must call
        /// enableStyleSheetsForSet() with that value as the function's argument, and
        /// set lastStyleSheetSet to that value.
        ///
        /// From the DOM's perspective, all views have the same
        /// selectedStyleSheetSet. If a UA supports multiple views with different
        /// selected alternate style sheets, then this attribute (and the StyleSheet
        /// interface's disabled attribute) must return and set the value for the
        /// default view.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetSelectedStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSelectedStyleSheetSet);
		
		/// <summary>
        /// This attribute indicates which style sheet set is in use. This attribute
        /// is live; changing the disabled attribute on style sheets directly will
        /// change the value of this attribute.
        ///
        /// If all the sheets that are enabled and have a title have the same title
        /// (by case-sensitive comparisons) then the value of this attribute must be
        /// exactly equal to the title of the first enabled style sheet with a title
        /// in the styleSheets list. Otherwise, if style sheets from different sets
        /// are enabled, then the return value must be null (there is no way to
        /// determine what the currently selected style sheet set is in those
        /// conditions). Otherwise, either all style sheets that have a title are
        /// disabled, or there are no alternate style sheets, and
        /// selectedStyleSheetSet must return the empty string.
        ///
        /// Setting this attribute to the null value must have no effect.
        ///
        /// Setting this attribute to a non-null value must call
        /// enableStyleSheetsForSet() with that value as the function's argument, and
        /// set lastStyleSheetSet to that value.
        ///
        /// From the DOM's perspective, all views have the same
        /// selectedStyleSheetSet. If a UA supports multiple views with different
        /// selected alternate style sheets, then this attribute (and the StyleSheet
        /// interface's disabled attribute) must return and set the value for the
        /// default view.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-selectedStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetSelectedStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aSelectedStyleSheetSet);
		
		/// <summary>
        /// This property must initially have the value null. Its value changes when
        /// the selectedStyleSheetSet attribute is set.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-lastStyleSheetSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLastStyleSheetSetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aLastStyleSheetSet);
		
		/// <summary>
        /// This must return the live list of the currently available style sheet
        /// sets. This list is constructed by enumerating all the style sheets for
        /// this document available to the implementation, in the order they are
        /// listed in the styleSheets attribute, adding the title of each style sheet
        /// with a title to the list, avoiding duplicates by dropping titles that
        /// match (case-sensitively) titles that have already been added to the
        /// list.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-styleSheetSets>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new System.IntPtr GetStyleSheetSetsAttribute();
		
		/// <summary>
        /// Calling this method must change the disabled attribute on each StyleSheet
        /// object with a title attribute with a length greater than 0 in the
        /// styleSheets attribute, so that all those whose title matches the name
        /// argument are enabled, and all others are disabled. Title matches must be
        /// case-sensitive. Calling this method with the empty string disables all
        /// alternate and preferred style sheets (but does not change the state of
        /// persistent style sheets, that is those with no title attribute).
        ///
        /// Calling this method with a null value must have no effect.
        ///
        /// Style sheets that do not have a title are never affected by this
        /// method. This method does not change the values of the lastStyleSheetSet or
        /// preferredStyleSheetSet attributes.
        ///
        /// @see <http://dev.w3.org/csswg/cssom/#dom-document-enableStyleSheetsForSet>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void EnableStyleSheetsForSet([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase name);
		
		/// <summary>
        /// Returns the element from the caller's document at the given point,
        /// relative to the upper-left-most point in the (possibly scrolled)
        /// window or frame.
        ///
        /// If the element at the given point belongs to another document (such as
        /// an iframe's subdocument), the element in the calling document's DOM
        /// (e.g. the iframe) is returned. If the element at the given point is
        /// anonymous or XBL generated content, such as a textbox's scrollbars, then
        /// the first non-anonymous parent element (that is, the textbox) is returned.
        ///
        /// This method returns null if either coordinate is negative, or if the
        /// specified point lies outside the visible bounds of the document.
        ///
        /// Callers from XUL documents should wait until the onload event has fired
        /// before calling this method.
        ///
        /// @see <http://dev.w3.org/csswg/cssom-view/#dom-document-elementfrompoint>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement ElementFromPoint(float x, float y);
		
		/// <summary>
        /// @see <https://developer.mozilla.org/en/DOM/document.contentType>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetContentTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aContentType);
		
		/// <summary>
        /// True if this document is synthetic : stand alone image, video, audio file,
        /// etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozSyntheticDocumentAttribute();
		
		/// <summary>
        /// Returns the script element whose script is currently being processed.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.currentScript>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetCurrentScriptAttribute();
		
		/// <summary>
        /// Release the current mouse capture if it is on an element within this
        /// document.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.releaseCapture>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ReleaseCapture();
		
		/// <summary>
        /// Use the given DOM element as the source image of target |-moz-element()|.
        ///
        /// This function introduces a new special ID (called "image element ID"),
        /// which is only used by |-moz-element()|, and associates it with the given
        /// DOM element.  Image elements ID's have the higher precedence than general
        /// HTML id's, so if |document.mozSetImageElement(<id>, <element>)| is called,
        /// |-moz-element(#<id>)| uses |<element>| as the source image even if there
        /// is another element with id attribute = |<id>|.  To unregister an image
        /// element ID |<id>|, call |document.mozSetImageElement(<id>, null)|.
        ///
        /// Example:
        /// <script>
        /// canvas = document.createElement("canvas");
        /// canvas.setAttribute("width", 100);
        /// canvas.setAttribute("height", 100);
        /// // draw to canvas
        /// document.mozSetImageElement("canvasbg", canvas);
        /// </script>
        /// <div style="background-image: -moz-element(#canvasbg);"></div>
        ///
        /// @param aImageElementId an image element ID to associate with
        /// |aImageElement|
        /// @param aImageElement a DOM element to be used as the source image of
        /// |-moz-element(#aImageElementId)|. If this is null, the function will
        /// unregister the image element ID |aImageElementId|.
        ///
        /// @see <https://developer.mozilla.org/en/DOM/document.mozSetImageElement>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozSetImageElement([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aImageElementId, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aImageElement);
		
		/// <summary>
        /// Element which is currently the full-screen element as per the DOM
        /// full-screen api.
        ///
        /// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetMozFullScreenElementAttribute();
		
		/// <summary>
        /// Causes the document to leave DOM full-screen mode, if it's in
        /// full-screen mode, as per the DOM full-screen api.
        ///
        /// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozCancelFullScreen();
		
		/// <summary>
        /// Denotes whether this document is in DOM full-screen mode, as per the DOM
        /// full-screen api.
        ///
        /// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozFullScreenAttribute();
		
		/// <summary>
        /// Denotes whether the full-screen-api.enabled is true, no windowed
        /// plugins are present, and all ancestor documents have the
        /// allowfullscreen attribute set.
        ///
        /// @see <https://wiki.mozilla.org/index.php?title=Gecko:FullScreenAPI>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozFullScreenEnabledAttribute();
		
		/// <summary>
        /// The element to which the mouse pointer is locked, if any, as per the
        /// DOM pointer lock api.
        ///
        /// @see <http://dvcs.w3.org/hg/pointerlock/raw-file/default/index.html>
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMElement GetMozPointerLockElementAttribute();
		
		/// <summary>
        /// Exit pointer is lock if locked, as per the DOM pointer lock api.
        ///
        /// @see <http://dvcs.w3.org/hg/pointerlock/raw-file/default/index.html>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void MozExitPointerLock();
		
		/// <summary>
        /// Inline event handler for readystatechange events.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnreadystatechangeAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// Inline event handler for readystatechange events.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnreadystatechangeAttribute(Gecko.JsVal aOnreadystatechange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseenterAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseenterAttribute(Gecko.JsVal aOnmouseenter, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new Gecko.JsVal GetOnmouseleaveAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetOnmouseleaveAttribute(Gecko.JsVal aOnmouseleave, System.IntPtr jsContext);
		
		/// <summary>
        /// Visibility API implementation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetHiddenAttribute();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetMozHiddenAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetVisibilityStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVisibilityState);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetMozVisibilityStateAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMozVisibilityState);
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetAsyncAttribute();
		
		/// <summary>
        /// Whether to load synchronously or asynchronously.
        /// The default is async==true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAsyncAttribute([MarshalAs(UnmanagedType.U1)] bool aAsync);
		
		/// <summary>
        /// Load an XML document.
        ///
        /// @param  url URL to an XML document.
        /// @return     True if load successfull.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Load([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase url);
	}
}
