

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90b1-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLScriptElement : nsIDOMHTMLElement
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
		void GetText(nsAString aText);
		void SetText(nsAString aText);

		void GetHtmlFor(nsAString aHtmlFor);
		void SetHtmlFor(nsAString aHtmlFor);

		void GetEvent(nsAString aEvent);
		void SetEvent(nsAString aEvent);

		void GetCharset(nsAString aCharset);
		void SetCharset(nsAString aCharset);

		bool GetDefer();
		void SetDefer(bool aDefer);

		void GetSrc(nsAString aSrc);
		void SetSrc(nsAString aSrc);

		void GetType(nsAString aType);
		void SetType(nsAString aType);

	}
	public class GeckoScriptElement : GeckoElement
	{
		nsIDOMHTMLScriptElement DOMHTMLElement;
		internal GeckoScriptElement(nsIDOMHTMLScriptElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoScriptElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLScriptElement;
		}
		public string Text {
			get { return nsString.Get(DOMHTMLElement.GetText); }
			set { DOMHTMLElement.SetText(new nsAString(value)); }
		}

		public string HtmlFor {
			get { return nsString.Get(DOMHTMLElement.GetHtmlFor); }
			set { DOMHTMLElement.SetHtmlFor(new nsAString(value)); }
		}

		public string Event {
			get { return nsString.Get(DOMHTMLElement.GetEvent); }
			set { DOMHTMLElement.SetEvent(new nsAString(value)); }
		}

		public string Charset {
			get { return nsString.Get(DOMHTMLElement.GetCharset); }
			set { DOMHTMLElement.SetCharset(new nsAString(value)); }
		}

		public bool Defer {
			get { return DOMHTMLElement.GetDefer(); }
			set { DOMHTMLElement.SetDefer(value); }
		}

		public string Src {
			get { return nsString.Get(DOMHTMLElement.GetSrc); }
			set { DOMHTMLElement.SetSrc(new nsAString(value)); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetType); }
			set { DOMHTMLElement.SetType(new nsAString(value)); }
		}

	}
}

