

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoLegendElement : GeckoElement
	{
		nsIDOMHTMLLegendElement DOMHTMLElement;
		internal GeckoLegendElement(nsIDOMHTMLLegendElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoLegendElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLLegendElement;
		}
		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
		}

		public string AccessKey {
			get { return nsString.Get(DOMHTMLElement.GetAccessKeyAttribute); }
			set { DOMHTMLElement.SetAccessKeyAttribute(new nsAString(value)); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

	}
}

