

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90b7-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLTableCellElement : nsIDOMHTMLElement
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
		int GetCellIndex();

		void GetAbbr(nsAString aAbbr);
		void SetAbbr(nsAString aAbbr);

		void GetAlign(nsAString aAlign);
		void SetAlign(nsAString aAlign);

		void GetAxis(nsAString aAxis);
		void SetAxis(nsAString aAxis);

		void GetBgColor(nsAString aBgColor);
		void SetBgColor(nsAString aBgColor);

		void GetCh(nsAString aCh);
		void SetCh(nsAString aCh);

		void GetChOff(nsAString aChOff);
		void SetChOff(nsAString aChOff);

		int GetColSpan();
		void SetColSpan(int aColSpan);

		void GetHeaders(nsAString aHeaders);
		void SetHeaders(nsAString aHeaders);

		void GetHeight(nsAString aHeight);
		void SetHeight(nsAString aHeight);

		bool GetNoWrap();
		void SetNoWrap(bool aNoWrap);

		int GetRowSpan();
		void SetRowSpan(int aRowSpan);

		void GetScope(nsAString aScope);
		void SetScope(nsAString aScope);

		void GetVAlign(nsAString aVAlign);
		void SetVAlign(nsAString aVAlign);

		void GetWidth(nsAString aWidth);
		void SetWidth(nsAString aWidth);

	}
	public class GeckoTableCellElement : GeckoElement
	{
		nsIDOMHTMLTableCellElement DOMHTMLElement;
		internal GeckoTableCellElement(nsIDOMHTMLTableCellElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableCellElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableCellElement;
		}
		public int CellIndex {
			get { return DOMHTMLElement.GetCellIndex(); }
		}

		public string Abbr {
			get { return nsString.Get(DOMHTMLElement.GetAbbr); }
			set { DOMHTMLElement.SetAbbr(new nsAString(value)); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlign); }
			set { DOMHTMLElement.SetAlign(new nsAString(value)); }
		}

		public string Axis {
			get { return nsString.Get(DOMHTMLElement.GetAxis); }
			set { DOMHTMLElement.SetAxis(new nsAString(value)); }
		}

		public string BgColor {
			get { return nsString.Get(DOMHTMLElement.GetBgColor); }
			set { DOMHTMLElement.SetBgColor(new nsAString(value)); }
		}

		public string Ch {
			get { return nsString.Get(DOMHTMLElement.GetCh); }
			set { DOMHTMLElement.SetCh(new nsAString(value)); }
		}

		public string ChOff {
			get { return nsString.Get(DOMHTMLElement.GetChOff); }
			set { DOMHTMLElement.SetChOff(new nsAString(value)); }
		}

		public int ColSpan {
			get { return DOMHTMLElement.GetColSpan(); }
			set { DOMHTMLElement.SetColSpan(value); }
		}

		public string Headers {
			get { return nsString.Get(DOMHTMLElement.GetHeaders); }
			set { DOMHTMLElement.SetHeaders(new nsAString(value)); }
		}

		public string Height {
			get { return nsString.Get(DOMHTMLElement.GetHeight); }
			set { DOMHTMLElement.SetHeight(new nsAString(value)); }
		}

		public bool NoWrap {
			get { return DOMHTMLElement.GetNoWrap(); }
			set { DOMHTMLElement.SetNoWrap(value); }
		}

		public int RowSpan {
			get { return DOMHTMLElement.GetRowSpan(); }
			set { DOMHTMLElement.SetRowSpan(value); }
		}

		public string Scope {
			get { return nsString.Get(DOMHTMLElement.GetScope); }
			set { DOMHTMLElement.SetScope(new nsAString(value)); }
		}

		public string VAlign {
			get { return nsString.Get(DOMHTMLElement.GetVAlign); }
			set { DOMHTMLElement.SetVAlign(new nsAString(value)); }
		}

		public string Width {
			get { return nsString.Get(DOMHTMLElement.GetWidth); }
			set { DOMHTMLElement.SetWidth(new nsAString(value)); }
		}

	}
}
