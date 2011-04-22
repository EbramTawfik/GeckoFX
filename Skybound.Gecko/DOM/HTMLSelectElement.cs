

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf9090-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLSelectElement : nsIDOMHTMLElement
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
		void GetType(nsAString aType);

		int GetSelectedIndex();
		void SetSelectedIndex(int aSelectedIndex);

		void GetValue(nsAString aValue);
		void SetValue(nsAString aValue);

		uint GetLength();
		void SetLength(uint aLength);

		nsIDOMHTMLFormElement GetForm();

		nsIDOMHTMLOptionsCollection GetOptions();

		bool GetDisabled();
		void SetDisabled(bool aDisabled);

		bool GetMultiple();
		void SetMultiple(bool aMultiple);

		void GetName(nsAString aName);
		void SetName(nsAString aName);

		int GetSize();
		void SetSize(int aSize);

		int GetTabIndex();
		void SetTabIndex(int aTabIndex);

        void add(nsIDOMHTMLElement element, nsIDOMHTMLElement before);
		void remove(int index);
		void blur();
		void focus();
	}
	public class GeckoSelectElement : GeckoElement
	{
		nsIDOMHTMLSelectElement DOMHTMLElement;
		internal GeckoSelectElement(nsIDOMHTMLSelectElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoSelectElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLSelectElement;
		}
		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetType); }
		}

		public int SelectedIndex {
			get { return DOMHTMLElement.GetSelectedIndex(); }
			set { DOMHTMLElement.SetSelectedIndex(value); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValue); }
			set { DOMHTMLElement.SetValue(new nsAString(value)); }
		}

		public uint Length {
			get { return DOMHTMLElement.GetLength(); }
			set { DOMHTMLElement.SetLength(value); }
		}

		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetForm()); }
		}

		public GeckoOptionsCollection Options {
			get { return new GeckoOptionsCollection(DOMHTMLElement.GetOptions()); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabled(); }
			set { DOMHTMLElement.SetDisabled(value); }
		}

		public bool Multiple {
			get { return DOMHTMLElement.GetMultiple(); }
			set { DOMHTMLElement.SetMultiple(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public int Size {
			get { return DOMHTMLElement.GetSize(); }
			set { DOMHTMLElement.SetSize(value); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndex(); }
			set { DOMHTMLElement.SetTabIndex(value); }
		}

        public void add(GeckoElement element, GeckoElement before)
		{
            DOMHTMLElement.add(element.DomObject as nsIDOMHTMLElement, before.DomObject as nsIDOMHTMLElement);
		}

		public void remove(int index)
		{
			DOMHTMLElement.remove(index);
		}

		public void blur()
		{
			DOMHTMLElement.blur();
		}

		public void focus()
		{
			DOMHTMLElement.focus();
		}

	}
}
