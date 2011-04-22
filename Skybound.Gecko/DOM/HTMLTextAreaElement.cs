

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf9094-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLTextAreaElement : nsIDOMHTMLElement
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
		void GetDefaultValue(nsAString aDefaultValue);
		void SetDefaultValue(nsAString aDefaultValue);

		nsIDOMHTMLFormElement GetForm();

		void GetAccessKey(nsAString aAccessKey);
		void SetAccessKey(nsAString aAccessKey);

		int GetCols();
		void SetCols(int aCols);

		bool GetDisabled();
		void SetDisabled(bool aDisabled);

		void GetName(nsAString aName);
		void SetName(nsAString aName);

		bool GetReadOnly();
		void SetReadOnly(bool aReadOnly);

		int GetRows();
		void SetRows(int aRows);

		int GetTabIndex();
		void SetTabIndex(int aTabIndex);

		void GetType(nsAString aType);

		void GetValue(nsAString aValue);
		void SetValue(nsAString aValue);

		void blur();
		void focus();
		void select();
	}
	public class GeckoTextAreaElement : GeckoElement
	{
		nsIDOMHTMLTextAreaElement DOMHTMLElement;
		internal GeckoTextAreaElement(nsIDOMHTMLTextAreaElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTextAreaElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTextAreaElement;
		}
		public string DefaultValue {
			get { return nsString.Get(DOMHTMLElement.GetDefaultValue); }
			set { DOMHTMLElement.SetDefaultValue(new nsAString(value)); }
		}

		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetForm()); }
		}

		public string AccessKey {
			get { return nsString.Get(DOMHTMLElement.GetAccessKey); }
			set { DOMHTMLElement.SetAccessKey(new nsAString(value)); }
		}

		public int Cols {
			get { return DOMHTMLElement.GetCols(); }
			set { DOMHTMLElement.SetCols(value); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabled(); }
			set { DOMHTMLElement.SetDisabled(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public bool ReadOnly {
			get { return DOMHTMLElement.GetReadOnly(); }
			set { DOMHTMLElement.SetReadOnly(value); }
		}

		public int Rows {
			get { return DOMHTMLElement.GetRows(); }
			set { DOMHTMLElement.SetRows(value); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndex(); }
			set { DOMHTMLElement.SetTabIndex(value); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetType); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValue); }
			set { DOMHTMLElement.SetValue(new nsAString(value)); }
		}

		public void blur()
		{
			DOMHTMLElement.blur();
		}

		public void focus()
		{
			DOMHTMLElement.focus();
		}

		public void select()
		{
			DOMHTMLElement.select();
		}

	}
}

