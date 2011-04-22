

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf90ae-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLAppletElement : nsIDOMHTMLElement
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
		void GetAlign(nsAString aAlign);
		void SetAlign(nsAString aAlign);

		void GetAlt(nsAString aAlt);
		void SetAlt(nsAString aAlt);

		void GetArchive(nsAString aArchive);
		void SetArchive(nsAString aArchive);

		void GetCode(nsAString aCode);
		void SetCode(nsAString aCode);

		void GetCodeBase(nsAString aCodeBase);
		void SetCodeBase(nsAString aCodeBase);

		void GetHeight(nsAString aHeight);
		void SetHeight(nsAString aHeight);

		int GetHspace();
		void SetHspace(int aHspace);

		void GetName(nsAString aName);
		void SetName(nsAString aName);

		void GetObject(nsAString aObject);
		void SetObject(nsAString aObject);

		int GetVspace();
		void SetVspace(int aVspace);

		void GetWidth(nsAString aWidth);
		void SetWidth(nsAString aWidth);

	}
	public class GeckoAppletElement : GeckoElement
	{
		nsIDOMHTMLAppletElement DOMHTMLElement;
		internal GeckoAppletElement(nsIDOMHTMLAppletElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoAppletElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLAppletElement;
		}
		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlign); }
			set { DOMHTMLElement.SetAlign(new nsAString(value)); }
		}

		public string Alt {
			get { return nsString.Get(DOMHTMLElement.GetAlt); }
			set { DOMHTMLElement.SetAlt(new nsAString(value)); }
		}

		public string Archive {
			get { return nsString.Get(DOMHTMLElement.GetArchive); }
			set { DOMHTMLElement.SetArchive(new nsAString(value)); }
		}

		public string Code {
			get { return nsString.Get(DOMHTMLElement.GetCode); }
			set { DOMHTMLElement.SetCode(new nsAString(value)); }
		}

		public string CodeBase {
			get { return nsString.Get(DOMHTMLElement.GetCodeBase); }
			set { DOMHTMLElement.SetCodeBase(new nsAString(value)); }
		}

		public string Height {
			get { return nsString.Get(DOMHTMLElement.GetHeight); }
			set { DOMHTMLElement.SetHeight(new nsAString(value)); }
		}

		public int Hspace {
			get { return DOMHTMLElement.GetHspace(); }
			set { DOMHTMLElement.SetHspace(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public string Object {
			get { return nsString.Get(DOMHTMLElement.GetObject); }
			set { DOMHTMLElement.SetObject(new nsAString(value)); }
		}

		public int Vspace {
			get { return DOMHTMLElement.GetVspace(); }
			set { DOMHTMLElement.SetVspace(value); }
		}

		public string Width {
			get { return nsString.Get(DOMHTMLElement.GetWidth); }
			set { DOMHTMLElement.SetWidth(new nsAString(value)); }
		}

	}
}

