

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
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
			get { return nsString.Get(DOMHTMLElement.GetDefaultValueAttribute); }
			set { DOMHTMLElement.SetDefaultValueAttribute(new nsAString(value)); }
		}

		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
		}

		public string AccessKey {
			get { return nsString.Get(DOMHTMLElement.GetAccessKeyAttribute); }
			set { DOMHTMLElement.SetAccessKeyAttribute(new nsAString(value)); }
		}

		public uint Cols {
			get { return DOMHTMLElement.GetColsAttribute(); }
			set { DOMHTMLElement.SetColsAttribute(value); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabledAttribute(); }
			set { DOMHTMLElement.SetDisabledAttribute(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetNameAttribute); }
			set { DOMHTMLElement.SetNameAttribute(new nsAString(value)); }
		}

		public bool ReadOnly {
			get { return DOMHTMLElement.GetReadOnlyAttribute(); }
			set { DOMHTMLElement.SetReadOnlyAttribute(value); }
		}

		public uint Rows {
			get { return DOMHTMLElement.GetRowsAttribute(); }
			set { DOMHTMLElement.SetRowsAttribute(value); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndexAttribute(); }
			set { DOMHTMLElement.SetTabIndexAttribute(value); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValueAttribute); }
			set { DOMHTMLElement.SetValueAttribute(new nsAString(value)); }
		}

		public void blur()
		{
			DOMHTMLElement.Blur();
		}

		public void focus()
		{
			DOMHTMLElement.Focus();
		}

		public void select()
		{
			DOMHTMLElement.Select();
		}

	}
}

