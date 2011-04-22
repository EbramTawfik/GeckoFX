

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf9088-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLLinkElement : nsIDOMHTMLElement
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
		bool GetDisabled();
		void SetDisabled(bool aDisabled);

		void GetCharset(nsAString aCharset);
		void SetCharset(nsAString aCharset);

		void GetHref(nsAString aHref);
		void SetHref(nsAString aHref);

		void GetHreflang(nsAString aHreflang);
		void SetHreflang(nsAString aHreflang);

		void GetMedia(nsAString aMedia);
		void SetMedia(nsAString aMedia);

		void GetRel(nsAString aRel);
		void SetRel(nsAString aRel);

		void GetRev(nsAString aRev);
		void SetRev(nsAString aRev);

		void GetTarget(nsAString aTarget);
		void SetTarget(nsAString aTarget);

		void GetType(nsAString aType);
		void SetType(nsAString aType);

	}
	public class GeckoLinkElement : GeckoElement
	{
		nsIDOMHTMLLinkElement DOMHTMLElement;
		internal GeckoLinkElement(nsIDOMHTMLLinkElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoLinkElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLLinkElement;
		}
		public bool Disabled {
			get { return DOMHTMLElement.GetDisabled(); }
			set { DOMHTMLElement.SetDisabled(value); }
		}

		public string Charset {
			get { return nsString.Get(DOMHTMLElement.GetCharset); }
			set { DOMHTMLElement.SetCharset(new nsAString(value)); }
		}

		public string Href {
			get { return nsString.Get(DOMHTMLElement.GetHref); }
			set { DOMHTMLElement.SetHref(new nsAString(value)); }
		}

		public string Hreflang {
			get { return nsString.Get(DOMHTMLElement.GetHreflang); }
			set { DOMHTMLElement.SetHreflang(new nsAString(value)); }
		}

		public string Media {
			get { return nsString.Get(DOMHTMLElement.GetMedia); }
			set { DOMHTMLElement.SetMedia(new nsAString(value)); }
		}

		public string Rel {
			get { return nsString.Get(DOMHTMLElement.GetRel); }
			set { DOMHTMLElement.SetRel(new nsAString(value)); }
		}

		public string Rev {
			get { return nsString.Get(DOMHTMLElement.GetRev); }
			set { DOMHTMLElement.SetRev(new nsAString(value)); }
		}

		public string Target {
			get { return nsString.Get(DOMHTMLElement.GetTarget); }
			set { DOMHTMLElement.SetTarget(new nsAString(value)); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetType); }
			set { DOMHTMLElement.SetType(new nsAString(value)); }
		}

	}
}

