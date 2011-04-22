

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90b2-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLTableElement : nsIDOMHTMLElement
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
		nsIDOMHTMLTableCaptionElement GetCaption();
		void SetCaption(nsIDOMHTMLTableCaptionElement aCaption);

		nsIDOMHTMLTableSectionElement GetTHead();
		void SetTHead(nsIDOMHTMLTableSectionElement aTHead);

		nsIDOMHTMLTableSectionElement GetTFoot();
		void SetTFoot(nsIDOMHTMLTableSectionElement aTFoot);

		nsIDOMHTMLCollection GetRows();

		nsIDOMHTMLCollection GetTBodies();

		void GetAlign(nsAString aAlign);
		void SetAlign(nsAString aAlign);

		void GetBgColor(nsAString aBgColor);
		void SetBgColor(nsAString aBgColor);

		void GetBorder(nsAString aBorder);
		void SetBorder(nsAString aBorder);

		void GetCellPadding(nsAString aCellPadding);
		void SetCellPadding(nsAString aCellPadding);

		void GetCellSpacing(nsAString aCellSpacing);
		void SetCellSpacing(nsAString aCellSpacing);

		void GetFrame(nsAString aFrame);
		void SetFrame(nsAString aFrame);

		void GetRules(nsAString aRules);
		void SetRules(nsAString aRules);

		void GetSummary(nsAString aSummary);
		void SetSummary(nsAString aSummary);

		void GetWidth(nsAString aWidth);
		void SetWidth(nsAString aWidth);

		nsIDOMHTMLElement createTHead();
		void deleteTHead();
		nsIDOMHTMLElement createTFoot();
		void deleteTFoot();
		nsIDOMHTMLElement createCaption();
		void deleteCaption();
		nsIDOMHTMLElement insertRow(int index);
		void deleteRow(int index);
	}
	public class GeckoTableElement : GeckoElement
	{
		nsIDOMHTMLTableElement DOMHTMLElement;
		internal GeckoTableElement(nsIDOMHTMLTableElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableElement;
		}
		public GeckoTableCaptionElement Caption {
			get { return new GeckoTableCaptionElement(DOMHTMLElement.GetCaption()); }
            set { DOMHTMLElement.SetCaption(value.DomObject as nsIDOMHTMLTableCaptionElement); }
		}

		public GeckoTableSectionElement THead {
			get { return new GeckoTableSectionElement(DOMHTMLElement.GetTHead()); }
            set { DOMHTMLElement.SetTHead(value.DomObject as nsIDOMHTMLTableSectionElement); }
		}

		public GeckoTableSectionElement TFoot {
			get { return new GeckoTableSectionElement(DOMHTMLElement.GetTFoot()); }
            set { DOMHTMLElement.SetTFoot(value.DomObject as nsIDOMHTMLTableSectionElement); }
		}

		public GeckoHtmlElementCollection Rows {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetRows()); }
		}

		public GeckoHtmlElementCollection TBodies {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetTBodies()); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlign); }
			set { DOMHTMLElement.SetAlign(new nsAString(value)); }
		}

		public string BgColor {
			get { return nsString.Get(DOMHTMLElement.GetBgColor); }
			set { DOMHTMLElement.SetBgColor(new nsAString(value)); }
		}

		public string Border {
			get { return nsString.Get(DOMHTMLElement.GetBorder); }
			set { DOMHTMLElement.SetBorder(new nsAString(value)); }
		}

		public string CellPadding {
			get { return nsString.Get(DOMHTMLElement.GetCellPadding); }
			set { DOMHTMLElement.SetCellPadding(new nsAString(value)); }
		}

		public string CellSpacing {
			get { return nsString.Get(DOMHTMLElement.GetCellSpacing); }
			set { DOMHTMLElement.SetCellSpacing(new nsAString(value)); }
		}

		public string Frame {
			get { return nsString.Get(DOMHTMLElement.GetFrame); }
			set { DOMHTMLElement.SetFrame(new nsAString(value)); }
		}

		public string Rules {
			get { return nsString.Get(DOMHTMLElement.GetRules); }
			set { DOMHTMLElement.SetRules(new nsAString(value)); }
		}

		public string Summary {
			get { return nsString.Get(DOMHTMLElement.GetSummary); }
			set { DOMHTMLElement.SetSummary(new nsAString(value)); }
		}

		public string Width {
			get { return nsString.Get(DOMHTMLElement.GetWidth); }
			set { DOMHTMLElement.SetWidth(new nsAString(value)); }
		}

		public GeckoElement createTHead()
		{
			return new GeckoElement(DOMHTMLElement.createTHead());
		}

		public void deleteTHead()
		{
			DOMHTMLElement.deleteTHead();
		}

		public GeckoElement createTFoot()
		{
			return new GeckoElement(DOMHTMLElement.createTFoot());
		}

		public void deleteTFoot()
		{
			DOMHTMLElement.deleteTFoot();
		}

		public GeckoElement createCaption()
		{
			return new GeckoElement(DOMHTMLElement.createCaption());
		}

		public void deleteCaption()
		{
			DOMHTMLElement.deleteCaption();
		}

		public GeckoElement insertRow(int index)
		{
			return new GeckoElement(DOMHTMLElement.insertRow(index));
		}

		public void deleteRow(int index)
		{
			DOMHTMLElement.deleteRow(index);
		}

	}
}
