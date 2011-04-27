

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	// TODO: review nsIDOMHTMLElement, nsIDOMElement, nsIDOMNode should not be included in this interface?
	[Guid("bce0213c-f70f-488f-b93f-688acca55d63"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLOptionsCollection : nsISupports
	{
		#region Inherited Intefaces
        // nsIDOMNode:
        void GetNodeName(nsAString aNodeName);
		void GetNodeValue(nsAString aNodeValue);
		void SetNodeValue(nsAString aNodeValue);
		ushort GetNodeType();
		nsIDOMNode GetParentNode();
		nsIDOMNodeList GetChildNodes();
		nsIDOMNode GetFirstChild();
		nsIDOMNode GetLastChild();
		nsIDOMNode GetPreviousSibling();
		nsIDOMNode GetNextSibling();
		nsIDOMNamedNodeMap GetAttributes();
		nsIDOMDocument GetOwnerDocument();
		nsIDOMNode InsertBefore(nsIDOMNode newChild, nsIDOMNode refChild);
		nsIDOMNode ReplaceChild(nsIDOMNode newChild, nsIDOMNode oldChild);
		nsIDOMNode RemoveChild(nsIDOMNode oldChild);
		nsIDOMNode AppendChild(nsIDOMNode newChild);
		bool HasChildNodes();
		nsIDOMNode CloneNode(bool deep);
		void Normalize();
		bool IsSupported(nsAString feature, nsAString version);
		void GetNamespaceURI(nsAString aNamespaceURI);
		void GetPrefix(nsAString aPrefix);
		void SetPrefix(nsAString aPrefix);
		void GetLocalName(nsAString aLocalName);
		bool HasAttributes();

        // nsIDOMElement:
        void GetTagName(nsAString aTagName);
        void GetAttribute(nsAString name, nsAString _retval);
        void SetAttribute(nsAString name, nsAString value);
        void RemoveAttribute(nsAString name);
        nsIDOMAttr GetAttributeNode(nsAString name);
        nsIDOMAttr SetAttributeNode(nsIDOMAttr newAttr);
        nsIDOMAttr RemoveAttributeNode(nsIDOMAttr oldAttr);
        nsIDOMNodeList GetElementsByTagName(nsAString name);
        void GetAttributeNS(nsAString namespaceURI, nsAString localName, nsAString _retval);
        void SetAttributeNS(nsAString namespaceURI, nsAString qualifiedName, nsAString value);
        void RemoveAttributeNS(nsAString namespaceURI, nsAString localName);
        nsIDOMAttr GetAttributeNodeNS(nsAString namespaceURI, nsAString localName);
        nsIDOMAttr SetAttributeNodeNS(nsIDOMAttr newAttr);
        nsIDOMNodeList GetElementsByTagNameNS(nsAString namespaceURI, nsAString localName);
        bool HasAttribute(nsAString name);
        bool HasAttributeNS(nsAString namespaceURI, nsAString localName);

        // nsIDOMHTMLElement:
        void GetId(nsAString aId);
        void SetId(nsAString aId);
        void GetTitle(nsAString aTitle);
        void SetTitle(nsAString aTitle);
        void GetLang(nsAString aLang);
        void SetLang(nsAString aLang);
        void GetDir(nsAString aDir);
        void SetDir(nsAString aDir);
        void GetClassName(nsAString aClassName);
        void SetClassName(nsAString aClassName);
        #endregion
		uint GetLength();
		void SetLength(uint aLength);

		nsIDOMNode item(uint index);
		nsIDOMNode namedItem(nsAString name);
	}
	public class GeckoOptionsCollection
	{
		nsIDOMHTMLOptionsCollection DOMHTMLElement;
		internal GeckoOptionsCollection(nsIDOMHTMLOptionsCollection element)
		{
			this.DOMHTMLElement = element;
		}
		public uint Length {
			get { return DOMHTMLElement.GetLength(); }
			set { DOMHTMLElement.SetLength(value); }
		}

		public GeckoNode item(uint index)
		{
			return new GeckoNode(DOMHTMLElement.item(index));
		}

		public GeckoNode namedItem(string name)
		{
			return new GeckoNode(DOMHTMLElement.namedItem(new nsAString(name)));
		}

	}
}

