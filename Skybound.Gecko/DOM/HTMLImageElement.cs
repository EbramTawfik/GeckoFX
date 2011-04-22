

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90ab-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLImageElement : nsIDOMHTMLElement
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
		void GetName(nsAString aName);
		void SetName(nsAString aName);

		void GetAlign(nsAString aAlign);
		void SetAlign(nsAString aAlign);

		void GetAlt(nsAString aAlt);
		void SetAlt(nsAString aAlt);

		void GetBorder(nsAString aBorder);
		void SetBorder(nsAString aBorder);

		int GetHeight();
		void SetHeight(int aHeight);

		int GetHspace();
		void SetHspace(int aHspace);

		bool GetIsMap();
		void SetIsMap(bool aIsMap);

		void GetLongDesc(nsAString aLongDesc);
		void SetLongDesc(nsAString aLongDesc);

		void GetSrc(nsAString aSrc);
		void SetSrc(nsAString aSrc);

		void GetUseMap(nsAString aUseMap);
		void SetUseMap(nsAString aUseMap);

		int GetVspace();
		void SetVspace(int aVspace);

		int GetWidth();
		void SetWidth(int aWidth);

	}
	public class GeckoImageElement : GeckoElement
	{
		nsIDOMHTMLImageElement DOMHTMLElement;
		internal GeckoImageElement(nsIDOMHTMLImageElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoImageElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLImageElement;
		}
		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlign); }
			set { DOMHTMLElement.SetAlign(new nsAString(value)); }
		}

		public string Alt {
			get { return nsString.Get(DOMHTMLElement.GetAlt); }
			set { DOMHTMLElement.SetAlt(new nsAString(value)); }
		}

		public string Border {
			get { return nsString.Get(DOMHTMLElement.GetBorder); }
			set { DOMHTMLElement.SetBorder(new nsAString(value)); }
		}

		public int Height {
			get { return DOMHTMLElement.GetHeight(); }
			set { DOMHTMLElement.SetHeight(value); }
		}

		public int Hspace {
			get { return DOMHTMLElement.GetHspace(); }
			set { DOMHTMLElement.SetHspace(value); }
		}

		public bool IsMap {
			get { return DOMHTMLElement.GetIsMap(); }
			set { DOMHTMLElement.SetIsMap(value); }
		}

		public string LongDesc {
			get { return nsString.Get(DOMHTMLElement.GetLongDesc); }
			set { DOMHTMLElement.SetLongDesc(new nsAString(value)); }
		}

		public string Src {
			get { return nsString.Get(DOMHTMLElement.GetSrc); }
			set { DOMHTMLElement.SetSrc(new nsAString(value)); }
		}

		public string UseMap {
			get { return nsString.Get(DOMHTMLElement.GetUseMap); }
			set { DOMHTMLElement.SetUseMap(new nsAString(value)); }
		}

		public int Vspace {
			get { return DOMHTMLElement.GetVspace(); }
			set { DOMHTMLElement.SetVspace(value); }
		}

		public int Width {
			get { return DOMHTMLElement.GetWidth(); }
			set { DOMHTMLElement.SetWidth(value); }
		}

	}
}

