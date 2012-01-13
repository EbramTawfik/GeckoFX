

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoFontElement : GeckoElement
	{
		nsIDOMHTMLFontElement DOMHTMLElement;
		internal GeckoFontElement(nsIDOMHTMLFontElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoFontElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLFontElement;
		}
		public string Color {
			get { return nsString.Get(DOMHTMLElement.GetColorAttribute); }
			set { DOMHTMLElement.SetColorAttribute(new nsAString(value)); }
		}

		public string Face {
			get { return nsString.Get(DOMHTMLElement.GetFaceAttribute); }
			set { DOMHTMLElement.SetFaceAttribute(new nsAString(value)); }
		}

		public string Size {
			get { return nsString.Get(DOMHTMLElement.GetSizeAttribute); }
			set { DOMHTMLElement.SetSizeAttribute(new nsAString(value)); }
		}

	}
}

