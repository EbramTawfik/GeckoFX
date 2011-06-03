

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoBodyElement : GeckoElement
	{
		nsIDOMHTMLBodyElement DOMHTMLElement;
		internal GeckoBodyElement(nsIDOMHTMLBodyElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoBodyElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLBodyElement;
		}
		public string ALink {
			get { return nsString.Get(DOMHTMLElement.GetALinkAttribute); }
			set { DOMHTMLElement.SetALinkAttribute(new nsAString(value)); }
		}

		public string Background {
			get { return nsString.Get(DOMHTMLElement.GetBackgroundAttribute); }
			set { DOMHTMLElement.SetBackgroundAttribute(new nsAString(value)); }
		}

		public string BgColor {
			get { return nsString.Get(DOMHTMLElement.GetBgColorAttribute); }
			set { DOMHTMLElement.SetBgColorAttribute(new nsAString(value)); }
		}

		public string Link {
			get { return nsString.Get(DOMHTMLElement.GetLinkAttribute); }
			set { DOMHTMLElement.SetLinkAttribute(new nsAString(value)); }
		}

		public string Text {
			get { return nsString.Get(DOMHTMLElement.GetTextAttribute); }
			set { DOMHTMLElement.SetTextAttribute(new nsAString(value)); }
		}

		public string VLink {
			get { return nsString.Get(DOMHTMLElement.GetVLinkAttribute); }
			set { DOMHTMLElement.SetVLinkAttribute(new nsAString(value)); }
		}

	}
}

