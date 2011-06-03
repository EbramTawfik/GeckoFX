

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoFieldSetElement : GeckoElement
	{
		nsIDOMHTMLFieldSetElement DOMHTMLElement;
		internal GeckoFieldSetElement(nsIDOMHTMLFieldSetElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoFieldSetElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLFieldSetElement;
		}
		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
		}

	}
}

