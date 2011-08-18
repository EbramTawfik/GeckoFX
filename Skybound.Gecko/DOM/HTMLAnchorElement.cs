

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoAnchorElement : GeckoElement
	{
		nsIDOMHTMLAnchorElement DOMHTMLElement;
		internal GeckoAnchorElement(nsIDOMHTMLAnchorElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoAnchorElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLAnchorElement;
		}
		public string AccessKey {
			get { return nsString.Get(DOMHTMLElement.GetAccessKeyAttribute); }
			set { DOMHTMLElement.SetAccessKeyAttribute(new nsAString(value)); }
		}

		public string Charset {
			get { return nsString.Get(DOMHTMLElement.GetCharsetAttribute); }
			set { DOMHTMLElement.SetCharsetAttribute(new nsAString(value)); }
		}

		public string Coords {
			get { return nsString.Get(DOMHTMLElement.GetCoordsAttribute); }
			set { DOMHTMLElement.SetCoordsAttribute(new nsAString(value)); }
		}

		public string Href {
			get { return nsString.Get(DOMHTMLElement.GetHrefAttribute); }
			set { DOMHTMLElement.SetHrefAttribute(new nsAString(value)); }
		}

		public string Hreflang {
			get { return nsString.Get(DOMHTMLElement.GetHreflangAttribute); }
			set { DOMHTMLElement.SetHreflangAttribute(new nsAString(value)); }
		}

		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetNameAttribute); }
			set { DOMHTMLElement.SetNameAttribute(new nsAString(value)); }
		}

		public string Rel {
			get { return nsString.Get(DOMHTMLElement.GetRelAttribute); }
			set { DOMHTMLElement.SetRelAttribute(new nsAString(value)); }
		}

		public string Rev {
			get { return nsString.Get(DOMHTMLElement.GetRevAttribute); }
			set { DOMHTMLElement.SetRevAttribute(new nsAString(value)); }
		}

		public string Shape {
			get { return nsString.Get(DOMHTMLElement.GetShapeAttribute); }
			set { DOMHTMLElement.SetShapeAttribute(new nsAString(value)); }
		}

		public new int TabIndex {
			get { return DOMHTMLElement.GetTabIndexAttribute(); }
			set { DOMHTMLElement.SetTabIndexAttribute(value); }
		}

		public string Target {
			get { return nsString.Get(DOMHTMLElement.GetTargetAttribute); }
			set { DOMHTMLElement.SetTargetAttribute(new nsAString(value)); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
			set { DOMHTMLElement.SetTypeAttribute(new nsAString(value)); }
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

