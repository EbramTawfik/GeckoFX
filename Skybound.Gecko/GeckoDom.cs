#region ***** BEGIN LICENSE BLOCK *****
/* Version: MPL 1.1/GPL 2.0/LGPL 2.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Skybound Software code.
 *
 * The Initial Developer of the Original Code is Skybound Software.
 * Portions created by the Initial Developer are Copyright (C) 2008-2009
 * the Initial Developer. All Rights Reserved.
 *
 * Contributor(s):
 *
 * Alternatively, the contents of this file may be used under the terms of
 * either the GNU General Public License Version 2 or later (the "GPL"), or
 * the GNU Lesser General Public License Version 2.1 or later (the "LGPL"),
 * in which case the provisions of the GPL or the LGPL are applicable instead
 * of those above. If you wish to allow use of your version of this file only
 * under the terms of either the GPL or the LGPL, and not to allow others to
 * use your version of this file under the terms of the MPL, indicate your
 * decision by deleting the provisions above and replace them with the notice
 * and other provisions required by the GPL or the LGPL. If you do not delete
 * the provisions above, a recipient may use your version of this file under
 * the terms of any one of the MPL, the GPL or the LGPL.
 */
#endregion END LICENSE BLOCK

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;

namespace Skybound.Gecko
{
	/// <summary>
	/// Provides a base class for DOM nodes.
	/// </summary>
	public class GeckoNode
	{
		internal GeckoNode(nsIDOMNode domObject)
		{
			_DomObject = domObject;
		}
		
		internal static GeckoNode Create(nsIDOMNode domObject)
		{
			if (domObject == null)
				return null;
			
			nsIDOMHTMLElement element = Xpcom.QueryInterface<nsIDOMHTMLElement>(domObject);
			if (element != null)
				return GeckoElement.Create(element);
			
			nsIDOMAttr attr = Xpcom.QueryInterface<nsIDOMAttr>(domObject);
			if (attr != null)
				return GeckoAttribute.Create(attr);
			
			return new GeckoNode(domObject);
		}
		
		/// <summary>
		/// Gets the underlying XPCOM object.
		/// </summary>
		public object DomObject
		{
			get { return _DomObject; }
		}
		nsIDOMNode _DomObject;
		
		public override bool Equals(object obj)
		{
			if (this == obj)
				return true;
			else if (obj is GeckoNode)
				return this.GetHashCode() == (obj as GeckoNode).GetHashCode();
			
			return base.Equals(obj);
		}
		
		public override int GetHashCode()
		{
			IntPtr pUnk = Marshal.GetIUnknownForObject(this._DomObject);
			try
			{
				return pUnk.GetHashCode();
			}
			finally
			{
				if (pUnk != IntPtr.Zero)
						Marshal.Release(pUnk);
			}
		}
		
		/// <summary>
		/// Gets the text contents of the node.
		/// </summary>
		public string TextContent
		{
			get { return nsString.Get(((nsIDOM3Node)_DomObject).GetTextContentAttribute); }
			set { nsString.Set(((nsIDOM3Node)_DomObject).SetTextContentAttribute, value); }
		}
		
		/// <summary>
		/// Gets or sets the value of the node.
		/// </summary>
		public string NodeValue
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetNodeValueAttribute); }
			set { nsString.Set(((nsIDOMNode)_DomObject).SetNodeValueAttribute, value); }
		}
		
		/// <summary>
		/// Gets a collection containing all child nodes of this node.
		/// </summary>
		public GeckoNodeCollection ChildNodes
		{
			get { return new GeckoNodeCollection(_DomObject.GetChildNodesAttribute()); }
		}

		public GeckoNode FirstChild { get { return GeckoNode.Create(_DomObject.GetFirstChildAttribute()); } }
		public GeckoNode LastChild { get { return GeckoNode.Create(_DomObject.GetLastChildAttribute()); } }
		public GeckoNode NextSibling { get { return GeckoNode.Create(_DomObject.GetNextSiblingAttribute()); } }
		public GeckoNode PreviousSibling { get { return GeckoNode.Create(_DomObject.GetPreviousSiblingAttribute()); } }
		public bool HasChildNodes { get { return _DomObject.HasChildNodes(); } }
		public bool HasAttributes { get { return _DomObject.HasAttributes(); } }

		public GeckoDocument OwnerDocument { get { return GeckoDocument.Create(Xpcom.QueryInterface<nsIDOMHTMLDocument>(_DomObject.GetOwnerDocumentAttribute())); } }
		
		public GeckoNode AppendChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");
			
			_DomObject.AppendChild(node._DomObject);
			return node;
		}
		
		public GeckoNode CloneNode(bool deep)
		{
			return GeckoNode.Create(_DomObject.CloneNode(deep));
		}
		
		public GeckoNode InsertBefore(GeckoNode newChild, GeckoNode before)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (before == null)
				throw new ArgumentNullException("before");
			
			_DomObject.InsertBefore(newChild._DomObject, before._DomObject);
			return newChild;
		}
		
		public GeckoNode RemoveChild(GeckoNode node)
		{
			if (node == null)
				throw new ArgumentNullException("node");
			
			_DomObject.RemoveChild(node._DomObject);
			return node;
		}
		
		public GeckoNode ReplaceChild(GeckoNode newChild, GeckoNode oldChild)
		{
			if (newChild == null)
				throw new ArgumentNullException("newChild");
			if (oldChild == null)
				throw new ArgumentNullException("oldChild");
			
			_DomObject.ReplaceChild(newChild._DomObject, oldChild._DomObject);
			return newChild;
		}

		public string NamespaceURI
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetNamespaceURIAttribute); }
		}

		public string Prefix
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetPrefixAttribute); }			
		}

		public string LocalName
		{
			get { return nsString.Get(((nsIDOMNode)_DomObject).GetLocalNameAttribute); }
		}

		public GeckoNamedNodeMap Attributes
		{
			get { return new GeckoNamedNodeMap(_DomObject.GetAttributesAttribute()); }
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoNode> GetNodes(string xpath)
		{
			nsIDOMXPathEvaluator evaluator = Xpcom.CreateInstance<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoNodeEnumerable(result);
		}

		/// <summary>
		/// Get GeckoNodes from give xpath expression.
		/// </summary>
		/// <param name="xpath"></param>
		/// <returns></returns>
		public IEnumerable<GeckoElement> GetElements(string xpath)
		{
			nsIDOMXPathEvaluator evaluator = Xpcom.CreateInstance<nsIDOMXPathEvaluator>("@mozilla.org/dom/xpath-evaluator;1");
			nsIDOMNode node = (nsIDOMNode)this.DomObject;
			nsIDOMXPathNSResolver resolver = evaluator.CreateNSResolver(node);
			nsIDOMXPathResult result = (nsIDOMXPathResult)evaluator.Evaluate(new nsAString(xpath), node, resolver, 0, null);

			return new GeckoElementEnumerable(result);
		}
	}
	
	/// <summary>
	/// Represents a DOM attribute.
	/// </summary>
	public class GeckoAttribute : GeckoNode
	{
		internal GeckoAttribute(nsIDOMAttr attr) : base(attr)
		{
			this.DomAttr = attr;
		}
		nsIDOMAttr DomAttr;
		
		internal static GeckoAttribute Create(nsIDOMAttr attr)
		{
			return (attr == null) ? null : new GeckoAttribute(attr);
		}
		
		/// <summary>
		/// Gets the name of the attribute.
		/// </summary>
		public string Name
		{
			get { return nsString.Get(DomAttr.GetNameAttribute); }
		}
		
		/// <summary>
		/// Gets the <see cref="GeckoElement"/> which contains this attribute.
		/// </summary>
		public GeckoElement OwnerElement
		{
			get { return GeckoElement.Create((nsIDOMHTMLElement)DomAttr.GetOwnerElementAttribute()); }
		}
		
		/// <summary>
		/// Gets a value indicating whether the attribute is specified.
		/// </summary>
		public bool Specified
		{
			get { return DomAttr.GetSpecifiedAttribute(); }
		}

		/// <summary>
		/// Gets the value of the attribute.
		/// </summary>
		public string Value
		{
			get { return nsString.Get(DomAttr.GetValueAttribute); }
			set { nsString.Set(DomAttr.SetValueAttribute, value); }
		}
	}
	
	/// <summary>
	/// Represents a DOM element.
	/// </summary>
	public class GeckoElement : GeckoNode
	{
		internal GeckoElement(nsIDOMHTMLElement element) : base(element)
		{
			this.DomElement = element;			
			this.DomNSElement = (nsIDOMNSElement)element;
			this.DomNSHTMLElement = (nsIDOMNSHTMLElement)element;
			
			if (Xpcom.IsDotNet) // TODO FIXME: ChangeWrapperHandleStrength not implemented in mono
			{
				// since a reference is stored in the base class, we only need weak references here
				Marshal.ChangeWrapperHandleStrength(DomNSElement, true);
				Marshal.ChangeWrapperHandleStrength(DomNSHTMLElement, true);
			}
		}
		
		internal static GeckoElement Create(nsIDOMHTMLElement element)
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor(element);
		}
		
		nsIDOMHTMLElement DomElement;
		nsIDOMNSElement DomNSElement;
		nsIDOMNSHTMLElement DomNSHTMLElement;
		
		/// <summary>
		/// Gets the inline style of the GeckoElement. 
		/// </summary>
		public GeckoStyle Style
		{
			get
			{
				return GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject).GetStyleAttribute());
			}
		}
		
		/// <summary>
		/// Gets the parent element of this one.
		/// </summary>
		public GeckoElement Parent
		{
			get
			{
				// note: the parent node could also be the document
				return GeckoElement.Create(Xpcom.QueryInterface<nsIDOMHTMLElement>(DomElement.GetParentNodeAttribute()));
			}
		}
		
		/// <summary>
		/// Gets the name of the tag.
		/// </summary>
		public string TagName
		{
			get { return nsString.Get(DomElement.GetTagNameAttribute); }
		}
		
		/// <summary>
		/// Gets the value of the id attribute.
		/// </summary>
		public string Id
		{
			get { return nsString.Get(DomElement.GetIdAttribute); }
			set { nsString.Set(DomElement.SetIdAttribute, value); }
		}
		
		/// <summary>
		/// Gets the value of the class attribute.
		/// </summary>
		public string ClassName
		{
			get { return nsString.Get(DomElement.GetClassNameAttribute); }
			set { nsString.Set(DomElement.SetClassNameAttribute, value); }
		}

		/// <summary>
		/// Get the value of the ContentEditable Attribute
		/// </summary>
		public string ContentEditable
		{
			get { return nsString.Get(DomNSHTMLElement.GetContentEditableAttribute); }
			set { nsString.Set(DomNSHTMLElement.GetContentEditableAttribute, value); }
		}
		
		/// <summary>
		/// Returns a collection containing the child elements of this element with a given tag name.
		/// </summary>
		/// <param name="tagName"></param>
		/// <returns></returns>
		public GeckoElementCollection GetElementsByTagName(string tagName)
		{
			if (string.IsNullOrEmpty(tagName))
				return null;
			
			return new GeckoElementCollection(DomElement.GetElementsByTagName(new nsAString(tagName)));
		}
		
		/// <summary>
		/// Gets the value of an attribute on this element with the specified name.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <returns></returns>
		public string GetAttribute(string attributeName)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");

			var retval = new nsAString();
			DomElement.GetAttribute(new nsAString(attributeName), retval);
			return retval.ToString();
		}

		/// <summary>
		/// Check if Element contains specified attribute.
		/// </summary>
		/// <param name="attributeName">The name of the attribute to look for</param>
		/// <returns>true if attribute exists false otherwise</returns>
		public bool HasAttribute(string attributeName)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");

			return DomElement.HasAttribute(new nsAString(attributeName));			
		}
		
		/// <summary>
		/// Gets the value of an attribute on this element with the specified name and namespace.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <returns></returns>
		public string GetAttributeNS(string namespaceUri, string attributeName)
		{
			if (string.IsNullOrEmpty(namespaceUri))
				return GetAttribute(attributeName);
			
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");
			nsAString retval = new nsAString();
			DomElement.GetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), retval);
			return retval.ToString();
		}
		
		/// <summary>
		/// Sets the value of an attribute on this element with the specified name.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <param name="value"></param>
		public void SetAttribute(string attributeName, string value)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");
			
			DomElement.SetAttribute(new nsAString(attributeName), new nsAString(value));
		}
		
		/// <summary>
		/// Sets the value of an attribute on this element with the specified name and namespace.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <param name="value"></param>
		public void SetAttributeNS(string namespaceUri, string attributeName, string value)
		{
			if (string.IsNullOrEmpty(namespaceUri))
			{
				SetAttribute(attributeName, value);
			}
			else
			{
				if (string.IsNullOrEmpty(attributeName))
					throw new ArgumentException("attributeName");
				
				DomElement.SetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), new nsAString(value));
			}
		}
		
		/// <summary>
		/// Removes an attribute from this element.
		/// </summary>
		/// <param name="attributeName"></param>
		public void RemoveAttribute(string attributeName)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");
			
			DomElement.RemoveAttribute(new nsAString(attributeName));
		}


		public int ScrollLeft { get { return DomNSElement.GetScrollLeftAttribute(); } set { DomNSElement.SetScrollLeftAttribute(value); } }
		public int ScrollTop { get { return DomNSElement.GetScrollTopAttribute(); } set { DomNSElement.SetScrollTopAttribute(value); } }
		public int ScrollWidth { get { return DomNSElement.GetScrollWidthAttribute(); } }
		public int ScrollHeight { get { return DomNSElement.GetScrollHeightAttribute(); } }
		public int ClientWidth { get { return DomNSElement.GetClientWidthAttribute(); } }
		public int ClientHeight { get { return DomNSElement.GetClientHeightAttribute(); } }

		public int OffsetLeft { get { return DomNSHTMLElement.GetOffsetLeftAttribute(); } }
		public int OffsetTop { get { return DomNSHTMLElement.GetOffsetTopAttribute(); } }
		public int OffsetWidth { get { return DomNSHTMLElement.GetOffsetWidthAttribute(); } }
		public int OffsetHeight { get { return DomNSHTMLElement.GetOffsetHeightAttribute(); } }
		
		public GeckoElement OffsetParent
		{
			get { return GeckoElement.Create((nsIDOMHTMLElement)DomNSHTMLElement.GetOffsetParentAttribute()); }
		}
		
		public void ScrollIntoView(bool top)
		{
			DomNSHTMLElement.ScrollIntoView(top);
		}
		
		public string InnerHtml
		{
			get { return nsString.Get(DomNSHTMLElement.GetInnerHTMLAttribute); }
			set { nsString.Set(DomNSHTMLElement.SetInnerHTMLAttribute, value); }
		}

		public virtual string OuterHtml
		{
			get {
				string contenteditableAttribute = String.Empty;
				string contentEdiableValue = ContentEditable;

				if (contentEdiableValue.ToLowerInvariant() != "inherit")
					contenteditableAttribute = String.Format(" ContentEditable={0}", contentEdiableValue);				

				string idAttribute = String.Empty;
				string id = Id;
				if (!String.IsNullOrEmpty(id))
					idAttribute = String.Format(" id={0}", id);

				string classAttribute = String.Empty;
				string className = ClassName;
				if (!String.IsNullOrEmpty(className))
					classAttribute = String.Format(" class={0}", className);

				return String.Format("<{0}{2}{3}{4}>{1}</{0}>", TagName, InnerHtml, idAttribute, classAttribute, contenteditableAttribute);
			}
		}
		
		public int TabIndex
		{
			get { return DomNSHTMLElement.GetTabIndexAttribute(); }
			set { DomNSHTMLElement.SetTabIndexAttribute(value); }
		}

	}
	
	/// <summary>
	/// Represents a DOM document.
	/// </summary>
	public class GeckoDocument : GeckoNode
	{
		internal GeckoDocument(nsIDOMHTMLDocument document) : base(document)
		{
			this.DomDocument = document;
		}
		
		internal static GeckoDocument Create(nsIDOMHTMLDocument document)
		{
			return (document == null) ? null : new GeckoDocument(document);
		}
		
		nsIDOMHTMLDocument DomDocument;
		
		/// <summary>
		/// Gets the document title.
		/// </summary>
		public string Title
		{
			get { return nsString.Get(DomDocument.GetTitleAttribute); }
			set { nsString.Set(DomDocument.SetTitleAttribute, value); }
		}
		
		/// <summary>
		/// Gets the HTML body element.
		/// </summary>
		public GeckoElement Body
		{
			get { return GeckoElement.Create(DomDocument.GetBodyAttribute()); }
		}
		
		/// <summary>
		/// Gets the top-level document element (for HTML documents, this is the html tag).
		/// </summary>
		public GeckoElement DocumentElement
		{
			get { return GeckoElement.Create((nsIDOMHTMLElement)DomDocument.GetDocumentElementAttribute()); }
		}
		
		/// <summary>
		/// Searches for and returns the element in the document with the given id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public GeckoElement GetElementById(string id)
		{
			if (string.IsNullOrEmpty(id))
				return null;
			
			return GeckoElement.Create((nsIDOMHTMLElement)DomDocument.GetElementById(new nsAString(id)));
		}
		
		/// <summary>
		/// Represents a collection of style sheets in a <see cref="GeckoDocument"/>.
		/// </summary>
		public class StyleSheetCollection : IEnumerable<GeckoStyleSheet>
		{
			internal StyleSheetCollection(GeckoDocument document)
			{
				this.List = ((nsIDOMDocumentStyle)document.DomDocument).GetStyleSheetsAttribute();
			}
			nsIDOMStyleSheetList List;
			
			/// <summary>
			/// Gets the number of items in the collection.
			/// </summary>
			public int Count
			{
				get { return (List == null) ? 0 : (int)List.GetLengthAttribute(); }
			}
			
			/// <summary>
			/// Gets the item at the specified index in the collection.
			/// </summary>
			/// <param name="index"></param>
			/// <returns></returns>
			public GeckoStyleSheet this[int index]
			{
				get
				{
					if (index < 0 || index >= Count)
						throw new ArgumentOutOfRangeException("index");

					return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet)List.Item((uint)index));
				}
			}
			
			#region IEnumerable<GeckoStyleSheet> Members
			
			/// <summary>
			/// Returns an <see cref="IEnumerator{GeckoStyleSheet}"/> which can enumerate through the collection.
			/// </summary>
			/// <returns></returns>
			public IEnumerator<GeckoStyleSheet> GetEnumerator()
			{
				int length = Count;
				for (int i = 0; i < length; i++)
				{
					yield return GeckoStyleSheet.Create((nsIDOMCSSStyleSheet)List.Item((uint)i));
				}
			}
			
			System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				foreach (GeckoStyleSheet element in this)
					yield return element;
			}

			#endregion
		}
		
		/// <summary>
		/// Gets the collection of style sheets in the <see cref="GeckoDocument"/>.
		/// </summary>
		public StyleSheetCollection StyleSheets
		{
			get { return (_StyleSheets == null) ? ( _StyleSheets = new StyleSheetCollection(this)) : _StyleSheets; }
		}
		StyleSheetCollection _StyleSheets;
		
		/// <summary>
		/// Gets the URL of the document.
		/// </summary>
		public Uri Url
		{
			get { return new Uri(nsString.Get(DomDocument.GetURLAttribute)); }
		}
		
		public GeckoElementCollection Frames
		{
			get { return new GeckoHtmlElementCollection(DomDocument.GetFormsAttribute()); }
		}
		
		public GeckoElementCollection Images
		{
			get { return new GeckoHtmlElementCollection(DomDocument.GetImagesAttribute()); }
		}
		
		public GeckoElementCollection Anchors
		{
			get { return new GeckoHtmlElementCollection(DomDocument.GetAnchorsAttribute()); }
		}
		
		public GeckoElementCollection Applets
		{
			get { return new GeckoHtmlElementCollection(DomDocument.GetAppletsAttribute()); }
		}
		
		public GeckoElementCollection Links
		{
			get { return new GeckoHtmlElementCollection(DomDocument.GetLinksAttribute()); }
		}
		
		public string Cookie
		{
			get { return nsString.Get(DomDocument.GetCookieAttribute); }
			set { nsString.Set(DomDocument.SetCookieAttribute, value); }
		}
		
		public string Domain
		{
			get { return nsString.Get(DomDocument.GetDomainAttribute); }
		}
		
		/// <summary>
		/// Returns a collection containing all elements in the document with a given tag name.
		/// </summary>
		/// <param name="tagName"></param>
		/// <returns></returns>
		public GeckoElementCollection GetElementsByTagName(string tagName)
		{
			if (string.IsNullOrEmpty(tagName))
				return null;
			
			return new GeckoElementCollection(DomDocument.GetElementsByTagName(new nsAString(tagName)));
		}
		
		/// <summary>
		/// Returns a collection containing all elements in the document with a given name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public GeckoElementCollection GetElementsByName(string name)
		{
			if (string.IsNullOrEmpty(name))
				return null;
			
			return new GeckoElementCollection(DomDocument.GetElementsByName(new nsAString(name)));
		}
		
		public GeckoElement CreateElement(string tagName)
		{
			if (string.IsNullOrEmpty(tagName))
				throw new ArgumentException("tagName");
			
			return GeckoElement.Create((nsIDOMHTMLElement)DomDocument.CreateElement(new nsAString(tagName)));
		}
		
		public GeckoElement CreateElement(string tagName, string qualifiedName)
		{
			if (string.IsNullOrEmpty(tagName))
				throw new ArgumentException("tagName");
			if (string.IsNullOrEmpty(qualifiedName))
				throw new ArgumentException("qualifiedName");
			
			return GeckoElement.Create((nsIDOMHTMLElement)DomDocument.CreateElementNS(new nsAString(tagName), new nsAString(qualifiedName)));
		}
		
		public GeckoAttribute CreateAttribute(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException("name");
			
			return GeckoAttribute.Create(DomDocument.CreateAttribute(new nsAString(name)));
		}
		
		public GeckoAttribute CreateAttribute(string namespaceUri, string qualifiedName)
		{
			if (string.IsNullOrEmpty(namespaceUri))
				throw new ArgumentException("namespaceUri");
			if (string.IsNullOrEmpty(qualifiedName))
				throw new ArgumentException("qualifiedName");
			
			return GeckoAttribute.Create(DomDocument.CreateAttributeNS(new nsAString(namespaceUri), new nsAString(qualifiedName)));
		}
		
		public GeckoNode ImportNode(GeckoNode node, bool deep)
		{
			if (node == null)
				throw new ArgumentNullException("node");
			
			return GeckoNode.Create(DomDocument.ImportNode((nsIDOMNode)node.DomObject, deep));
		}
		
		public bool IsSupported(string feature, string version)
		{
			if (string.IsNullOrEmpty(feature))
				throw new ArgumentException("feature");
			if (string.IsNullOrEmpty(version))
				throw new ArgumentException("version");
			
			return DomDocument.IsSupported(new nsAString(feature), new nsAString(version));
		}
				
		/// <summary>
		/// Gets the currently focused element.
		/// </summary>
		public GeckoElement ActiveElement
		{
			get { return (GeckoElement)GeckoElement.Create(((nsIDOMNSDocument)DomDocument).GetActiveElementAttribute()); }
		}
		
		/// <summary>
		/// Returns a set of elements with the given class name. When called on the document object, the complete document is searched, including the root node.
		/// </summary>
		/// <param name="classes"></param>
		/// <returns></returns>
		public GeckoNodeCollection GetElementsByClassName(string classes)
		{
			using (nsAString str = new nsAString(classes))
				return new GeckoNodeCollection(((nsIDOMNSDocument)DomDocument).GetElementsByClassName(str));
		}
		
		/// <summary>
		/// Returns the element visible at the given point, relative to the upper-left-most visible point in the document.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public GeckoElement ElementFromPoint(int x, int y)
		{
			return GeckoElement.Create((nsIDOMHTMLElement)((nsIDOMNSDocument)DomDocument).ElementFromPoint(x, y));
		}
		
		public GeckoRange CreateRange()
		{
			return new GeckoRange(((nsIDOMDocumentRange)DomDocument).CreateRange());
		}
	}
	
	public class GeckoNamedNodeMap : IEnumerable<GeckoNode>
	{
		internal GeckoNamedNodeMap(nsIDOMNamedNodeMap map)
		{
			this.Map = map;
		}
		
		nsIDOMNamedNodeMap Map;
		
		/// <summary>
		/// Gets the number of items in the map.
		/// </summary>
		public int Count
		{
			get { return (Map == null) ? 0 : (int)Map.GetLengthAttribute(); }
		}
		
		public GeckoNode this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoNode.Create(Map.Item((uint)index));
			}
		}
		
		public GeckoNode this[string name]
		{
			get
			{
				return GeckoNode.Create(Map.GetNamedItem(new nsAString(name)));
			}
		}
		
		public GeckoNode this[string namespaceUri, string localName]
		{
			get
			{
				return GeckoNode.Create(Map.GetNamedItemNS(new nsAString(namespaceUri), new nsAString(localName)));
			}
		}

		#region IEnumerable<GeckoNode> Members

		public IEnumerator<GeckoNode> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoNode.Create(Map.Item((uint)i));
			}
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (GeckoNode node in this)
				yield return node;
		}

		#endregion
	}
	
	/// <summary>
	/// Represents a DOM window.
	/// </summary>
	public class GeckoWindow
	{
		private GeckoWindow(nsIDOMWindow window)
		{
			_DomWindow = window;
		}
		
		/// <summary>
		/// Gets the underlying unmanaged DOM object.
		/// </summary>
		public object DomWindow
		{
			get { return _DomWindow; }
		}
		nsIDOMWindow _DomWindow;
		
		internal static GeckoWindow Create(nsIDOMWindow window)
		{
			return (window == null) ? null : new GeckoWindow(window);
		}
		
		/// <summary>
		/// Gets the document displayed in the window.
		/// </summary>
		public GeckoDocument Document
		{
			get { return GeckoDocument.Create((nsIDOMHTMLDocument)_DomWindow.GetDocumentAttribute()); }
		}
		
		/// <summary>
		/// Gets the parent window of this one.
		/// </summary>
		public GeckoWindow Parent
		{
			get { return GeckoWindow.Create((nsIDOMWindow)_DomWindow.GetParentAttribute()); }
		}

		public int ScrollX
		{
			get { return _DomWindow.GetScrollXAttribute(); }
		}
		
		public int ScrollY
		{
			get { return _DomWindow.GetScrollYAttribute(); }
		}

		public float TextZoom
		{
			get { return (float)_DomWindow.GetTextZoomAttribute(); }
			set { _DomWindow.SetTextZoomAttribute((double)value); }
		}
		
		public GeckoWindow Top
		{
			get { return GeckoWindow.Create((nsIDOMWindow)_DomWindow.GetTopAttribute()); }
		}
		
		public string Name
		{
			get { return nsString.Get(_DomWindow.GetNameAttribute); }
			set { nsString.Set(_DomWindow.SetNameAttribute, value); }
		}
		
		public void Print()
		{
			nsIWebBrowserPrint print = Xpcom.QueryInterface<nsIWebBrowserPrint>(this.DomWindow);
			
			print.Print(null, null);
		}
		
		public GeckoSelection Selection
		{
			get 
			{				
				return new GeckoSelection(this._DomWindow.GetSelection());
			}
		}
	}
	
	/// <summary>
	/// Represents a collection of <see cref="GeckoElement"/> objects.
	/// </summary>
	public class GeckoElementCollection : IEnumerable<GeckoElement>
	{
		internal GeckoElementCollection(nsIDOMNodeList list)
		{
			this.List = list;
		}
		nsIDOMNodeList List;

		public virtual int Count
		{
			get { return (List == null) ? 0 : (int)List.GetLengthAttribute(); }
		}
		
		public virtual GeckoElement this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoElement.Create((nsIDOMHTMLElement)List.Item((uint)index));
			}
		}
		
		#region IEnumerable<GeckoElement> Members

		public virtual IEnumerator<GeckoElement> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoElement.Create((nsIDOMHTMLElement)List.Item((uint)i));
			}
		}
		
		#endregion
		
		#region IEnumerable Members
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (GeckoElement element in this)
				yield return element;
		}

		#endregion
	}
	
	/// <summary>
	/// Represents a collection of <see cref="GeckoElement"/> objects.
	/// </summary>
	public class GeckoNodeCollection : IEnumerable<GeckoNode>
	{
		internal GeckoNodeCollection(nsIDOMNodeList list)
		{
			this.List = list;
		}
		nsIDOMNodeList List;

		public virtual int Count
		{
			get { return (List == null) ? 0 : (int)List.GetLengthAttribute(); }
		}
		
		public virtual GeckoNode this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoNode.Create(List.Item((uint)index));
			}
		}
		
		#region IEnumerable<GeckoNode> Members

		public virtual IEnumerator<GeckoNode> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoNode.Create(List.Item((uint)i));
			}
		}
		
		#endregion
		
		#region IEnumerable Members
		
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			foreach (GeckoNode element in this)
				yield return element;
		}

		#endregion
	}
	
	public class GeckoHtmlElementCollection : GeckoElementCollection
	{
		internal GeckoHtmlElementCollection(nsIDOMHTMLCollection col) : base(null)
		{
			this.Collection = col;
		}
		nsIDOMHTMLCollection Collection;

		public override int Count
		{
			get { return (Collection == null) ? 0 : (int)Collection.GetLengthAttribute(); }
		}

		public override GeckoElement this[int index]
		{
			get
			{
				if (index < 0 || index >= Count)
					throw new ArgumentOutOfRangeException("index");

				return GeckoElement.Create((nsIDOMHTMLElement)Collection.Item((uint)index));
			}
		}

		public override IEnumerator<GeckoElement> GetEnumerator()
		{
			int length = Count;
			for (int i = 0; i < length; i++)
			{
				yield return GeckoElement.Create((nsIDOMHTMLElement)Collection.Item((uint)i));
			}
		}
	}

	/// <summary>
	/// Represents a collection of GeckoNode's
	/// </summary>
	internal class GeckoNodeEnumerable : IEnumerable<GeckoNode>
	{
		private nsIDOMXPathResult xpathResult = null;

		internal GeckoNodeEnumerable(nsIDOMXPathResult xpathResult)
		{
			this.xpathResult = xpathResult;
		}

		#region IEnumerable<GeckoNode> Members

		public IEnumerator<GeckoNode> GetEnumerator()
		{
			nsIDOMNode node;
			while ((node = xpathResult.IterateNext()) != null)
				yield return GeckoNode.Create(node);
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			nsIDOMNode node;
			while ((node = xpathResult.IterateNext()) != null)
				yield return GeckoNode.Create(node);
		}

		#endregion
	}

	/// <summary>
	/// Represents a collection of GeckoNode's
	/// </summary>
	internal class GeckoElementEnumerable : IEnumerable<GeckoElement>
	{
		private nsIDOMXPathResult xpathResult = null;

		internal GeckoElementEnumerable(nsIDOMXPathResult xpathResult)
		{
			this.xpathResult = xpathResult;
		}

		#region IEnumerable<GeckoNode> Members

		// TODO: This current implementation only also GetEnumerator to be called once!
		// refactor so that Enumerator is inplemented in seperate class and GetEnumerator can
		// be called multiple times.
		public IEnumerator<GeckoElement> GetEnumerator()
		{
			nsIDOMNode node;
			while ((node = xpathResult.IterateNext()) != null)
				if (node is nsIDOMHTMLElement)
					yield return GeckoElement.Create((nsIDOMHTMLElement)node);
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			nsIDOMNode node;
			while ((node = xpathResult.IterateNext()) != null)
				yield return GeckoNode.Create(node);
		}

		#endregion
	}

}
