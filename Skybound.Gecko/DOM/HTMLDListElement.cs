

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoDListElement : GeckoElement
	{
		nsIDOMHTMLDListElement DOMHTMLElement;
		internal GeckoDListElement(nsIDOMHTMLDListElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoDListElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLDListElement;
		}
		public bool Compact {
			get { return DOMHTMLElement.GetCompactAttribute(); }
			set { DOMHTMLElement.SetCompactAttribute(value); }
		}

	}
}

