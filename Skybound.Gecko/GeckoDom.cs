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
using Gecko.DOM;

namespace Gecko
{
	/// <summary>
	/// Represents a DOM attribute.
	/// </summary>
	public class GeckoAttribute : GeckoNode
	{
		internal GeckoAttribute(nsIDOMAttr attr) : base(attr)
		{
			this.DomAttr = attr;
		}
		internal nsIDOMAttr DomAttr;
		
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

#warning rename GeckoDomElement->GeckoElement & GeckoElement ->GeckoHtmlElement
	public class GeckoDomElement
		:GeckoNode
	{
		private nsIDOMElement _domElement;

		private string m_cachedTagName;

		internal GeckoDomElement(nsIDOMElement domElement)
			:base(domElement)
		{
			_domElement = domElement;
		}

		

		/// <summary>
		/// Gets the name of the tag.
		/// </summary>
		public string TagName
		{
			get
			{
				if (m_cachedTagName != null)
					return m_cachedTagName;

				return m_cachedTagName = nsString.Get(_domElement.GetTagNameAttribute);
			}
		}

		#region Attribute
		/// <summary>
		/// Gets the value of an attribute on this element with the specified name.
		/// </summary>
		/// <param name="attributeName"></param>
		/// <returns></returns>
		public string GetAttribute(string attributeName)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");

			return nsString.Get(_domElement.GetAttribute, attributeName);
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

			return nsString.Pass( _domElement.HasAttribute, attributeName );
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

			nsString.Set( _domElement.SetAttribute, attributeName, value );
		}

		/// <summary>
		/// Removes an attribute from this element.
		/// </summary>
		/// <param name="attributeName"></param>
		public void RemoveAttribute(string attributeName)
		{
			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");


			nsString.Set(_domElement.RemoveAttribute,attributeName);
		}
		#endregion

		#region Attribute Nodes
		public GeckoAttribute GetAttributeNode(string name)
		{
			var ret = nsString.Pass(_domElement.GetAttributeNode, name);
			return (ret == null) ? null : new GeckoAttribute(ret);
		}

		public GeckoAttribute SetAttributeNode(GeckoAttribute newAttr)
		{
			var ret = _domElement.SetAttributeNode(newAttr.DomAttr);
			return ret == null ? null : new GeckoAttribute(ret);
		}

		public GeckoAttribute RemoveAttributeNode(GeckoAttribute newAttr)
		{
			var ret = _domElement.RemoveAttributeNode(newAttr.DomAttr);
			return ret == null ? null : new GeckoAttribute(ret);
		}
		#endregion



		#region Attribute NS
		public bool HasAttributeNS(string namespaceUri, string attributeName)
		{
			if (string.IsNullOrEmpty(namespaceUri))
				return HasAttribute(attributeName);

			if (string.IsNullOrEmpty(attributeName))
				throw new ArgumentException("attributeName");

			return nsString.Pass( _domElement.HasAttributeNS, namespaceUri, attributeName );
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
			_domElement.GetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), retval);
			return retval.ToString();
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

				_domElement.SetAttributeNS(new nsAString(namespaceUri), new nsAString(attributeName), new nsAString(value));
			}
		}
		#endregion

		#region Attribute Node NS
		
		public GeckoAttribute GetAttributeNodeNS(string namespaceUri, string localName)
		{
			if (string.IsNullOrEmpty(namespaceUri))
				return GetAttributeNode(localName);

			var ret = nsString.Pass(_domElement.GetAttributeNodeNS, namespaceUri,localName);
			return (ret == null) ? null : new GeckoAttribute(ret);
		}

		public GeckoAttribute SetAttributeNodeNS(GeckoAttribute attribute)
		{
			var ret = _domElement.SetAttributeNodeNS( attribute.DomAttr );
			return (ret == null) ? null : new GeckoAttribute(ret);
		}
		#endregion

		/// <summary>
		/// Returns a collection containing the child elements of this element with a given tag name.
		/// </summary>
		/// <param name="tagName"></param>
		/// <returns></returns>
		public GeckoElementCollection GetElementsByTagName(string tagName)
		{
			if (string.IsNullOrEmpty(tagName))
				return null;

			return new GeckoElementCollection(_domElement.GetElementsByTagName(new nsAString(tagName)));
		}

		public GeckoElementCollection GetElementsByTagNameNS(string namespaceURI, string localName)
		{
			if ( string.IsNullOrEmpty( namespaceURI ) ) return GetElementsByTagName( localName );

			if ( string.IsNullOrEmpty( localName ) )
				return null;

			var ret = nsString.Pass( _domElement.GetElementsByTagNameNS, namespaceURI, localName );
			return ret == null ? null : new GeckoElementCollection( ret );
		}







	}

	/// <summary>
	/// Represents a DOM element.
	/// </summary>
	public class GeckoElement
		: GeckoDomElement
	{
		internal GeckoElement(nsIDOMHTMLElement element)
			: base(element)
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

		internal static T Create<T>(nsIDOMHTMLElement element) where T : GeckoElement 
		{
			return (element == null) ? null : DOM.DOMSelector.GetClassFor<T>(element);
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
		/// Gets the value of the id attribute.
		/// </summary>
		public string Id
		{
			get { return nsString.Get(DomElement.GetIdAttribute); }
			set 
			{				
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("id");
				else
					nsString.Set(DomElement.SetIdAttribute, value); 
			}
		}
		
		/// <summary>
		/// Gets the value of the class attribute.
		/// </summary>
		public string ClassName
		{
			get { return nsString.Get(DomElement.GetClassNameAttribute); }
			set 
			{
				if (string.IsNullOrEmpty(value))
					this.RemoveAttribute("class");
				else
					nsString.Set(DomElement.SetClassNameAttribute, value); 
			}
		}

		public void Blur()
		{
			DomElement.Blur();
		}

		public void Focus()
		{
			DomElement.Focus();
		}

		public void Click()
		{
			DomElement.Click();
		}
	
		/// <summary>
		/// Get the value of the ContentEditable Attribute
		/// </summary>
		public string ContentEditable
		{
			get { return nsString.Get(DomNSHTMLElement.GetContentEditableAttribute); }
			set { nsString.Set(DomNSHTMLElement.GetContentEditableAttribute, value); }
		}
		

		
		public System.Drawing.Rectangle BoundingClientRect
		{
			get
			{
				nsIDOMClientRect domRect = DomNSElement.GetBoundingClientRect();
				var r = new Rectangle((int)domRect.GetLeftAttribute(), (int)domRect.GetTopAttribute(), (int)domRect.GetWidthAttribute(), (int)domRect.GetHeightAttribute());
				return r;				
			}
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
			DomNSHTMLElement.ScrollIntoView(top, 1);
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

				string nameAttribute = String.Empty;
				string name = this.GetAttribute("name");
				if (!String.IsNullOrEmpty(name))
					nameAttribute = String.Format(" name=\"{0}\"", name);

				string idAttribute = String.Empty;
				string id = Id;
				if (!String.IsNullOrEmpty(id))
					idAttribute = String.Format(" id=\"{0}\"", id);

				string classAttribute = String.Empty;
				string className = ClassName;
				if (!String.IsNullOrEmpty(className))
					classAttribute = String.Format(" class=\"{0}\"", className);
				
				return String.Format("<{0}{1}{2}{3}{4}>{5}</{0}>", TagName, nameAttribute, idAttribute, classAttribute, contenteditableAttribute, InnerHtml);
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
		public GeckoBodyElement Body
		{
			get { return GeckoElement.Create<GeckoBodyElement>(DomDocument.GetBodyAttribute()); }
		}
		
		/// <summary>
		/// Gets the top-level document element (for HTML documents, this is the html tag).
		/// </summary>
		public GeckoElement DocumentElement
		{
			get
			{
				nsIDOMElement domElement = DomDocument.GetDocumentElementAttribute();
				
				return GeckoElement.Create(
				(nsIDOMHTMLElement)domElement);
			}
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
				this.List = document.DomDocument.GetStyleSheetsAttribute();
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
		/// <param name="name">This is NOT the tagname but the name attribute.</param>
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

		public GeckoNode CreateTextNode(string data)
		{
			return GeckoNode.Create(DomDocument.CreateTextNode(new nsAString(data)));
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
			get { return (GeckoElement)GeckoElement.Create(((nsIDOMDocument)DomDocument).GetActiveElementAttribute()); }
		}
		
		/// <summary>
		/// Returns a set of elements with the given class name. When called on the document object, the complete document is searched, including the root node.
		/// </summary>
		/// <param name="classes"></param>
		/// <returns></returns>
		public GeckoNodeCollection GetElementsByClassName(string classes)
		{
			using (nsAString str = new nsAString(classes))
				return new GeckoNodeCollection(((nsIDOMDocument)DomDocument).GetElementsByClassName(str));
		}
		
		/// <summary>
		/// Returns the element visible at the given point, relative to the upper-left-most visible point in the document.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		public GeckoElement ElementFromPoint(int x, int y)
		{
			return GeckoElement.Create((nsIDOMHTMLElement)((nsIDOMDocument)DomDocument).ElementFromPoint(x, y));
		}
		
		public GeckoRange CreateRange()
		{
			return new GeckoRange(DomDocument.CreateRange());
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
		public nsIDOMWindow DomWindow
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

		public void ScrollTo(int xScroll, int yScroll)
		{
			_DomWindow.ScrollTo(xScroll, yScroll);
		}

		public void ScrollBy(int xScrollDif, int yScrollDif)
		{
			_DomWindow.ScrollBy(xScrollDif, yScrollDif);
		}

		public void ScrollByLines(int numLines)
		{
			_DomWindow.ScrollByLines(numLines);
		}

		public void ScrollByPages(int numPages)
		{
			_DomWindow.ScrollByPages(numPages);
		}

		public void SizeToContent()
		{
			_DomWindow.SizeToContent();
		}

		public float TextZoom
		{
			get { return _DomWindow.GetTextZoomAttribute(); }
			set { _DomWindow.SetTextZoomAttribute(value); }
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
				if (_DomWindow.GetSelection() == null)
					return null;

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
