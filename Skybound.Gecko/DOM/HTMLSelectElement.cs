

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
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
			get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
		}

		public int SelectedIndex {
			get { return DOMHTMLElement.GetSelectedIndexAttribute(); }
			set { DOMHTMLElement.SetSelectedIndexAttribute(value); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValueAttribute); }
			set { DOMHTMLElement.SetValueAttribute(new nsAString(value)); }
		}

		public uint Length {
			get { return DOMHTMLElement.GetLengthAttribute(); }
			set { DOMHTMLElement.SetLengthAttribute(value); }
		}

		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
		}

		public GeckoOptionsCollection Options {
			get { return new GeckoOptionsCollection(DOMHTMLElement.GetOptionsAttribute()); }
		}

		public bool Disabled {
			get { return DOMHTMLElement.GetDisabledAttribute(); }
			set { DOMHTMLElement.SetDisabledAttribute(value); }
		}

		public bool Multiple {
			get { return DOMHTMLElement.GetMultipleAttribute(); }
			set { DOMHTMLElement.SetMultipleAttribute(value); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetNameAttribute); }
			set { DOMHTMLElement.SetNameAttribute(new nsAString(value)); }
		}

		public int Size {
			get { return DOMHTMLElement.GetSizeAttribute(); }
			set { DOMHTMLElement.SetSizeAttribute(value); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndexAttribute(); }
			set { DOMHTMLElement.SetTabIndexAttribute(value); }
		}

        public void add(GeckoElement element, GeckoElement before)
		{
            DOMHTMLElement.Add(element.DomObject as nsIDOMHTMLElement, before.DomObject as nsIDOMHTMLElement);
		}

		public void remove(int index)
		{
			DOMHTMLElement.Remove(index);
		}

		public void blur()
		{
			DOMHTMLElement.Blur();
		}

		public void focus()
		{
			DOMHTMLElement.Focus();
		}

	}
}
