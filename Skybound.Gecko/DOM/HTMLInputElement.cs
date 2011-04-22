

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{
	[Guid("a6cf9093-15b3-11d2-932e-00805f8add32"), ComImport, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	interface nsIDOMHTMLInputElement : nsIDOMHTMLElement
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

		bool GetDefaultChecked();
		void SetDefaultChecked(bool aDefaultChecked);

		nsIDOMHTMLFormElement GetForm();

		void GetAccept(nsAString aAccept);
		void SetAccept(nsAString aAccept);

		void GetAccessKey(nsAString aAccessKey);
		void SetAccessKey(nsAString aAccessKey);

		void GetAlign(nsAString aAlign);
		void SetAlign(nsAString aAlign);

		void GetAlt(nsAString aAlt);
		void SetAlt(nsAString aAlt);

		bool GetChecked();
		void SetChecked(bool aChecked);

		bool GetDisabled();
		void SetDisabled(bool aDisabled);

		int GetMaxLength();
		void SetMaxLength(int aMaxLength);

		void GetName(nsAString aName);
		void SetName(nsAString aName);

		bool GetReadOnly();
		void SetReadOnly(bool aReadOnly);

		uint GetSize();
		void SetSize(uint aSize);

		void GetSrc(nsAString aSrc);
		void SetSrc(nsAString aSrc);

		int GetTabIndex();
		void SetTabIndex(int aTabIndex);

		void GetType(nsAString aType);
		void SetType(nsAString aType);

		void GetUseMap(nsAString aUseMap);
		void SetUseMap(nsAString aUseMap);

		void GetValue(nsAString aValue);
		void SetValue(nsAString aValue);

		void blur();
		void focus();
		void select();
		void click();
	}
	public class GeckoInputElement : GeckoElement
	{
		nsIDOMHTMLInputElement DOMHTMLElement;
		internal GeckoInputElement(nsIDOMHTMLInputElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoInputElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLInputElement;
		}
		public string DefaultValue {
			get { return nsString.Get(DOMHTMLElement.GetDefaultValue); }
			set { DOMHTMLElement.SetDefaultValue(new nsAString(value)); }
		}

		public bool DefaultChecked {
			get { return DOMHTMLElement.GetDefaultChecked(); }
			set { DOMHTMLElement.SetDefaultChecked(value); }
		}

		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetForm()); }
		}

		public string Accept {
			get { return nsString.Get(DOMHTMLElement.GetAccept); }
			set { DOMHTMLElement.SetAccept(new nsAString(value)); }
		}

		public string AccessKey {
			get { return nsString.Get(DOMHTMLElement.GetAccessKey); }
			set { DOMHTMLElement.SetAccessKey(new nsAString(value)); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlign); }
			set { DOMHTMLElement.SetAlign(new nsAString(value)); }
		}

		public string Alt {
			get { return nsString.Get(DOMHTMLElement.GetAlt); }
			set { DOMHTMLElement.SetAlt(new nsAString(value)); }
		}

		public bool Checked {
			get { return DOMHTMLElement.GetChecked(); }
			set { DOMHTMLElement.SetChecked(value); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabled(); }
			set { DOMHTMLElement.SetDisabled(value); }
		}

		public int MaxLength {
			get { return DOMHTMLElement.GetMaxLength(); }
			set { DOMHTMLElement.SetMaxLength(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetName); }
			set { DOMHTMLElement.SetName(new nsAString(value)); }
		}

		public bool ReadOnly {
			get { return DOMHTMLElement.GetReadOnly(); }
			set { DOMHTMLElement.SetReadOnly(value); }
		}

		public uint Size {
			get { return DOMHTMLElement.GetSize(); }
			set { DOMHTMLElement.SetSize(value); }
		}

		public string Src {
			get { return nsString.Get(DOMHTMLElement.GetSrc); }
			set { DOMHTMLElement.SetSrc(new nsAString(value)); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndex(); }
			set { DOMHTMLElement.SetTabIndex(value); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetType); }
			set { DOMHTMLElement.SetType(new nsAString(value)); }
		}

		public string UseMap {
			get { return nsString.Get(DOMHTMLElement.GetUseMap); }
			set { DOMHTMLElement.SetUseMap(new nsAString(value)); }
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

		public void click()
		{
			DOMHTMLElement.click();
		}
        //#region GeckoWindowScrolled Event Handler
        //public delegate void GeckoWindowScrolledEventHandler(object sender, GeckoWindowScrolledEventArgs e);
        //public event GeckoWindowScrolledEventHandler WindowScrolled
        //{
        //    add { this.Events.AddHandler(WindowScrolledEvent, value); }
        //    remove { this.Events.RemoveHandler(WindowScrolledEvent, value); }
        //}
        //private static object WindowScrolledEvent = new object();
        //protected virtual void OnWindowScrolled(GeckoWindowScrolledEventArgs e)
        //{
        //    if (((GeckoWindowScrolledEventHandler)this.Events[WindowScrolledEvent]) != null)
        //        ((GeckoWindowScrolledEventHandler)this.Events[WindowScrolledEvent])(this, e);
        //}
        //public class GeckoWindowScrolledEventArgs : System.EventArgs
        //{
        //    public GeckoWindowScrolledEventArgs()
        //    {

        //    }
        //}
        //#endregion
	}
}

