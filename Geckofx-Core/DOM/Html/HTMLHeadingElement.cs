

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{
    // interface nsIDOMHTMLHeadingElement no longer exists in gecko 45
#if false
	public class GeckoHeadingElement : GeckoHtmlElement
	{
		nsIDOMHTMLHeadingElement DOMHTMLElement;
		internal GeckoHeadingElement(nsIDOMHTMLHeadingElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoHeadingElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLHeadingElement;
		}
		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

	}
#endif
}

