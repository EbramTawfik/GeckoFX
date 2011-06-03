

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoBRElement : GeckoElement
	{
		nsIDOMHTMLBRElement DOMHTMLElement;
		internal GeckoBRElement(nsIDOMHTMLBRElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoBRElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLBRElement;
		}
		public string Clear {
			get { return nsString.Get(DOMHTMLElement.GetClearAttribute); }
			set { DOMHTMLElement.SetClearAttribute(new nsAString(value)); }
		}

	}
}

