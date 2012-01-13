

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoTableColElement : GeckoElement
	{
		nsIDOMHTMLTableColElement DOMHTMLElement;
		internal GeckoTableColElement(nsIDOMHTMLTableColElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableColElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableColElement;
		}
		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

		public string Ch {
			get { return nsString.Get(DOMHTMLElement.GetChAttribute); }
			set { DOMHTMLElement.SetChAttribute(new nsAString(value)); }
		}

		public string ChOff {
			get { return nsString.Get(DOMHTMLElement.GetChOffAttribute); }
			set { DOMHTMLElement.SetChOffAttribute(new nsAString(value)); }
		}

		public int Span {
			get { return DOMHTMLElement.GetSpanAttribute(); }
			set { DOMHTMLElement.SetSpanAttribute(value); }
		}

		public string VAlign {
			get { return nsString.Get(DOMHTMLElement.GetVAlignAttribute); }
			set { DOMHTMLElement.SetVAlignAttribute(new nsAString(value)); }
		}

		public string Width {
			get { return nsString.Get(DOMHTMLElement.GetWidthAttribute); }
			set { DOMHTMLElement.SetWidthAttribute(new nsAString(value)); }
		}

	}
}
