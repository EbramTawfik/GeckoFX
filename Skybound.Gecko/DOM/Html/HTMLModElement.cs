

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoModElement : GeckoElement
	{
		nsIDOMHTMLModElement DOMHTMLElement;
		internal GeckoModElement(nsIDOMHTMLModElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoModElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLModElement;
		}
		public string Cite {
			get { return nsString.Get(DOMHTMLElement.GetCiteAttribute); }
			set { DOMHTMLElement.SetCiteAttribute(new nsAString(value)); }
		}

		public string DateTime {
			get { return nsString.Get(DOMHTMLElement.GetDateTimeAttribute); }
			set { DOMHTMLElement.SetDateTimeAttribute(new nsAString(value)); }
		}

	}
}

