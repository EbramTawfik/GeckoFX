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
// Generated by IDLImporter from file nsIDOMXULElement.idl
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
	
	
	/// <summary>nsIDOMXULElement </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("30a4a815-b42a-4f0b-9c10-1e7f727cd135")]
	public interface nsIDOMXULElement : nsIDOMElement
	{
		
		/// <summary>
        /// The nsIDOMNode interface is the primary datatype for the entire
        /// Document Object Model.
        /// It represents a single node in the document tree.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeName);
		
		/// <summary>Member GetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>Member SetNodeValueAttribute </summary>
		/// <param name='aNodeValue'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetNodeValueAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNodeValue);
		
		/// <summary>
        /// raises(DOMException) on retrieval
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new ushort GetNodeTypeAttribute();
		
		/// <summary>Member GetParentNodeAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetParentNodeAttribute();
		
		/// <summary>Member GetChildNodesAttribute </summary>
		/// <returns>A nsIDOMNodeList </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList  GetChildNodesAttribute();
		
		/// <summary>Member GetFirstChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetFirstChildAttribute();
		
		/// <summary>Member GetLastChildAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetLastChildAttribute();
		
		/// <summary>Member GetPreviousSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetPreviousSiblingAttribute();
		
		/// <summary>Member GetNextSiblingAttribute </summary>
		/// <returns>A nsIDOMNode </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode  GetNextSiblingAttribute();
		
		/// <summary>Member GetAttributesAttribute </summary>
		/// <returns>A nsIDOMNamedNodeMap </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNamedNodeMap  GetAttributesAttribute();
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMDocument  GetOwnerDocumentAttribute();
		
		/// <summary>Member InsertBefore </summary>
		/// <param name='newChild'> </param>
		/// <param name='refChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode InsertBefore([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  refChild);
		
		/// <summary>Member ReplaceChild </summary>
		/// <param name='newChild'> </param>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode ReplaceChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild, [MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member RemoveChild </summary>
		/// <param name='oldChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode RemoveChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  oldChild);
		
		/// <summary>Member AppendChild </summary>
		/// <param name='newChild'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode AppendChild([MarshalAs(UnmanagedType.Interface)] nsIDOMNode  newChild);
		
		/// <summary>Member HasChildNodes </summary>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasChildNodes();
		
		/// <summary>Member CloneNode </summary>
		/// <param name='deep'> </param>
		/// <returns>A nsIDOMNode</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNode CloneNode(System.Boolean  deep);
		
		/// <summary>
        /// Modified in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Normalize();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsSupported([MarshalAs(UnmanagedType.LPStruct)] nsAString feature, [MarshalAs(UnmanagedType.LPStruct)] nsAString version);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetNamespaceURIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aNamespaceURI);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetPrefixAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPrefix);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetLocalNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLocalName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributes();
		
		/// <summary>
        /// The nsIDOMElement interface represents an element in an HTML or
        /// XML document.
        ///
        /// For more information on this interface please see
        /// http://www.w3.org/TR/DOM-Level-2-Core/
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTagNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTagName);
		
		/// <summary>Member GetAttribute </summary>
		/// <param name='name'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member RemoveAttribute </summary>
		/// <param name='name'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member GetAttributeNode </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNode([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>Member SetAttributeNode </summary>
		/// <param name='newAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  newAttr);
		
		/// <summary>Member RemoveAttributeNode </summary>
		/// <param name='oldAttr'> </param>
		/// <returns>A nsIDOMAttr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr RemoveAttributeNode([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  oldAttr);
		
		/// <summary>Member GetElementsByTagName </summary>
		/// <param name='name'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagName([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsAString GetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString qualifiedName, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void RemoveAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr GetAttributeNodeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMAttr SetAttributeNodeNS([MarshalAs(UnmanagedType.Interface)] nsIDOMAttr  newAttr);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIDOMNodeList GetElementsByTagNameNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool HasAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString localName);
		
		/// <summary>Member GetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>Member SetIdAttribute </summary>
		/// <param name='aId'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetIdAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aId);
		
		/// <summary>Member GetClassNameAttribute </summary>
		/// <param name='aClassName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		/// <summary>Member SetClassNameAttribute </summary>
		/// <param name='aClassName'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetClassNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aClassName);
		
		/// <summary>
        /// Layout properties
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlign);
		
		/// <summary>
        /// Layout properties
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAlignAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aAlign);
		
		/// <summary>Member GetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member SetDirAttribute </summary>
		/// <param name='aDir'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDirAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDir);
		
		/// <summary>Member GetFlexAttribute </summary>
		/// <param name='aFlex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFlexAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlex);
		
		/// <summary>Member SetFlexAttribute </summary>
		/// <param name='aFlex'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFlexAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlex);
		
		/// <summary>Member GetFlexGroupAttribute </summary>
		/// <param name='aFlexGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetFlexGroupAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlexGroup);
		
		/// <summary>Member SetFlexGroupAttribute </summary>
		/// <param name='aFlexGroup'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFlexGroupAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aFlexGroup);
		
		/// <summary>Member GetOrdinalAttribute </summary>
		/// <param name='aOrdinal'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrdinalAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrdinal);
		
		/// <summary>Member SetOrdinalAttribute </summary>
		/// <param name='aOrdinal'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrdinalAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrdinal);
		
		/// <summary>Member GetOrientAttribute </summary>
		/// <param name='aOrient'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetOrientAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrient);
		
		/// <summary>Member SetOrientAttribute </summary>
		/// <param name='aOrient'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOrientAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aOrient);
		
		/// <summary>Member GetPackAttribute </summary>
		/// <param name='aPack'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPackAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPack);
		
		/// <summary>Member SetPackAttribute </summary>
		/// <param name='aPack'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPackAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPack);
		
		/// <summary>
        /// Properties for hiding elements.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetHiddenAttribute();
		
		/// <summary>
        /// Properties for hiding elements.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHiddenAttribute(System.Boolean  aHidden);
		
		/// <summary>Member GetCollapsedAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetCollapsedAttribute();
		
		/// <summary>Member SetCollapsedAttribute </summary>
		/// <param name='aCollapsed'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCollapsedAttribute(System.Boolean  aCollapsed);
		
		/// <summary>
        /// Property for hooking up to broadcasters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetObservesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aObserves);
		
		/// <summary>
        /// Property for hooking up to broadcasters
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObservesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aObserves);
		
		/// <summary>
        /// Properties for hooking up to popups
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMenu);
		
		/// <summary>
        /// Properties for hooking up to popups
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMenu);
		
		/// <summary>Member GetContextMenuAttribute </summary>
		/// <param name='aContextMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetContextMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContextMenu);
		
		/// <summary>Member SetContextMenuAttribute </summary>
		/// <param name='aContextMenu'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContextMenuAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aContextMenu);
		
		/// <summary>Member GetTooltipAttribute </summary>
		/// <param name='aTooltip'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>Member SetTooltipAttribute </summary>
		/// <param name='aTooltip'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTooltipAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltip);
		
		/// <summary>
        /// Width/height properties
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aWidth);
		
		/// <summary>
        /// Width/height properties
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aWidth);
		
		/// <summary>Member GetHeightAttribute </summary>
		/// <param name='aHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeight);
		
		/// <summary>Member SetHeightAttribute </summary>
		/// <param name='aHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aHeight);
		
		/// <summary>Member GetMinWidthAttribute </summary>
		/// <param name='aMinWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMinWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinWidth);
		
		/// <summary>Member SetMinWidthAttribute </summary>
		/// <param name='aMinWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinWidth);
		
		/// <summary>Member GetMinHeightAttribute </summary>
		/// <param name='aMinHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMinHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinHeight);
		
		/// <summary>Member SetMinHeightAttribute </summary>
		/// <param name='aMinHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMinHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMinHeight);
		
		/// <summary>Member GetMaxWidthAttribute </summary>
		/// <param name='aMaxWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMaxWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxWidth);
		
		/// <summary>Member SetMaxWidthAttribute </summary>
		/// <param name='aMaxWidth'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxWidthAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxWidth);
		
		/// <summary>Member GetMaxHeightAttribute </summary>
		/// <param name='aMaxHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMaxHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxHeight);
		
		/// <summary>Member SetMaxHeightAttribute </summary>
		/// <param name='aMaxHeight'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMaxHeightAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aMaxHeight);
		
		/// <summary>
        /// Persistence
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPersist);
		
		/// <summary>
        /// Persistence
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aPersist);
		
		/// <summary>
        /// other elements - these are client coordinates relative to parent stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLeftAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeft);
		
		/// <summary>
        /// other elements - these are client coordinates relative to parent stack.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLeftAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aLeft);
		
		/// <summary>Member GetTopAttribute </summary>
		/// <param name='aTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTopAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTop);
		
		/// <summary>Member SetTopAttribute </summary>
		/// <param name='aTop'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTopAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTop);
		
		/// <summary>
        /// XUL Template Builder
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetDatasourcesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDatasources);
		
		/// <summary>
        /// XUL Template Builder
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDatasourcesAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aDatasources);
		
		/// <summary>Member GetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRef);
		
		/// <summary>Member SetRefAttribute </summary>
		/// <param name='aRef'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRefAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aRef);
		
		/// <summary>
        /// Tooltip and status info
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTooltipTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltipText);
		
		/// <summary>
        /// Tooltip and status info
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTooltipTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aTooltipText);
		
		/// <summary>Member GetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member SetStatusTextAttribute </summary>
		/// <param name='aStatusText'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStatusTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString aStatusText);
		
		/// <summary>Member GetAllowEventsAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetAllowEventsAttribute();
		
		/// <summary>Member SetAllowEventsAttribute </summary>
		/// <param name='aAllowEvents'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAllowEventsAttribute(System.Boolean  aAllowEvents);
		
		/// <summary>Member GetDatabaseAttribute </summary>
		/// <returns>A nsIRDFCompositeDataSource </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFCompositeDataSource  GetDatabaseAttribute();
		
		/// <summary>Member GetBuilderAttribute </summary>
		/// <returns>A nsIXULTemplateBuilder </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIXULTemplateBuilder  GetBuilderAttribute();
		
		/// <summary>Member GetResourceAttribute </summary>
		/// <returns>A nsIRDFResource </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRDFResource  GetResourceAttribute();
		
		/// <summary>Member GetControllersAttribute </summary>
		/// <returns>A nsIControllers </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIControllers  GetControllersAttribute();
		
		/// <summary>Member GetBoxObjectAttribute </summary>
		/// <returns>A nsIBoxObject </returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIBoxObject  GetBoxObjectAttribute();
		
		/// <summary>Member Focus </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Focus();
		
		/// <summary>Member Blur </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Blur();
		
		/// <summary>Member Click </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Click();
		
		/// <summary>Member DoCommand </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DoCommand();
		
		/// <summary>Member GetElementsByAttribute </summary>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
		
		/// <summary>Member GetElementsByAttributeNS </summary>
		/// <param name='namespaceURI'> </param>
		/// <param name='name'> </param>
		/// <param name='value'> </param>
		/// <returns>A nsIDOMNodeList</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNodeList GetElementsByAttributeNS([MarshalAs(UnmanagedType.LPStruct)] nsAString namespaceURI, [MarshalAs(UnmanagedType.LPStruct)] nsAString name, [MarshalAs(UnmanagedType.LPStruct)] nsAString value);
	}
}
