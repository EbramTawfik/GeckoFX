

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90b9-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLFrameElement : nsIDOMHTMLElement
	{
		#region Inherited Intefaces
        // nsIDOMNode:
        new void GetNodeName(nsAString aNodeName);
        new void GetNodeValue(nsAString aNodeValue);
        new void SetNodeValue(nsAString aNodeValue);
        new ushort GetNodeType();
        new nsIDOMNode GetParentNode();
        new nsIDOMNodeList GetChildNodes();
        new nsIDOMNode GetFirstChild();
        new nsIDOMNode GetLastChild();
        new nsIDOMNode GetPreviousSibling();
        new nsIDOMNode GetNextSibling();
        new nsIDOMNamedNodeMap GetAttributes();
        new nsIDOMDocument GetOwnerDocument();
        new nsIDOMNode InsertBefore(nsIDOMNode newChild, nsIDOMNode refChild);
        new nsIDOMNode ReplaceChild(nsIDOMNode newChild, nsIDOMNode oldChild);
        new nsIDOMNode RemoveChild(nsIDOMNode oldChild);
        new nsIDOMNode AppendChild(nsIDOMNode newChild);
        new bool HasChildNodes();
        new nsIDOMNode CloneNode(bool deep);
        new void Normalize();
        new bool IsSupported(nsAString feature, nsAString version);
        new void GetNamespaceURI(nsAString aNamespaceURI);
        new void GetPrefix(nsAString aPrefix);
        new void SetPrefix(nsAString aPrefix);
        new void GetLocalName(nsAString aLocalName);
        new bool HasAttributes();

        // nsIDOMElement:
        new void GetTagName(nsAString aTagName);
        new void GetAttribute(nsAString name, nsAString _retval);
        new void SetAttribute(nsAString name, nsAString value);
        new void RemoveAttribute(nsAString name);
        new nsIDOMAttr GetAttributeNode(nsAString name);
        new nsIDOMAttr SetAttributeNode(nsIDOMAttr newAttr);
        new nsIDOMAttr RemoveAttributeNode(nsIDOMAttr oldAttr);
        new nsIDOMNodeList GetElementsByTagName(nsAString name);
        new void GetAttributeNS(nsAString namespaceURI, nsAString localName, nsAString _retval);
        new void SetAttributeNS(nsAString namespaceURI, nsAString qualifiedName, nsAString value);
        new void RemoveAttributeNS(nsAString namespaceURI, nsAString localName);
        new nsIDOMAttr GetAttributeNodeNS(nsAString namespaceURI, nsAString localName);
        new nsIDOMAttr SetAttributeNodeNS(nsIDOMAttr newAttr);
        new nsIDOMNodeList GetElementsByTagNameNS(nsAString namespaceURI, nsAString localName);
        new bool HasAttribute(nsAString name);
        new bool HasAttributeNS(nsAString namespaceURI, nsAString localName);

        // nsIDOMHTMLElement:
        new void GetId(nsAString aId);
        new void SetId(nsAString aId);
        new void GetTitle(nsAString aTitle);
        new void SetTitle(nsAString aTitle);
        new void GetLang(nsAString aLang);
        new void SetLang(nsAString aLang);
        new void GetDir(nsAString aDir);
        new void SetDir(nsAString aDir);
        new void GetClassName(nsAString aClassName);
        new void SetClassName(nsAString aClassName);
        #endregion
		void GetFrameBorder(nsAString aFrameBorder);
		void SetFrameBorder(nsAString aFrameBorder);

		void GetLongDesc(nsAString aLongDesc);
		void SetLongDesc(nsAString aLongDesc);

		void GetMarginHeight(nsAString aMarginHeight);
		void SetMarginHeight(nsAString aMarginHeight);

		void GetMarginWidth(nsAString aMarginWidth);
		void SetMarginWidth(nsAString aMarginWidth);

		void GetName(nsAString aName);
		void SetName(nsAString aName);

		bool GetNoResize();
		void SetNoResize(bool aNoResize);

		void GetScrolling(nsAString aScrolling);
		void SetScrolling(nsAString aScrolling);

		void GetSrc(nsAString aSrc);
		void SetSrc(nsAString aSrc);

		nsIDOMDocument GetContentDocument();

	}
	public class GeckoFrameElement : GeckoElement
	{
		nsIDOMHTMLFrameElement DOMHTMLElement;
		internal GeckoFrameElement(nsIDOMHTMLFrameElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoFrameElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLFrameElement;
		}
		public string FrameBorder {
			get { return nsString.Get(DOMHTMLElement.GetFrameBorder); }
			set { DOMHTMLElement.SetFrameBorder(new nsAString(value)); }
		}

		public string LongDesc {
			get { return nsString.Get(DOMHTMLElement.GetLongDesc); }
			set { DOMHTMLElement.SetLongDesc(new nsAString(value)); }
		}

		public string MarginHeight {
			get { return nsString.Get(DOMHTMLElement.GetMarginHeight); }
			set { DOMHTMLElement.SetMarginHeight(new nsAString(value)); }
		}

		public string MarginWidth {
			get { return nsString.Get(DOMHTMLElement.GetMarginWidth); }
			set { DOMHTMLElement.SetMarginWidth(new nsAString(value)); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public bool NoResize {
			get { return DOMHTMLElement.GetNoResize(); }
			set { DOMHTMLElement.SetNoResize(value); }
		}

		public string Scrolling {
			get { return nsString.Get(DOMHTMLElement.GetScrolling); }
			set { DOMHTMLElement.SetScrolling(new nsAString(value)); }
		}

		public string Src {
			get { return nsString.Get(DOMHTMLElement.GetSrc); }
			set { DOMHTMLElement.SetSrc(new nsAString(value)); }
		}

		public GeckoDocument ContentDocument {
			get { return new GeckoDocument(DOMHTMLElement.GetContentDocument() as nsIDOMHTMLDocument); }
		}

	}
}

