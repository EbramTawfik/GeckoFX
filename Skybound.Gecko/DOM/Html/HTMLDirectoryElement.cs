

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoDirectoryElement : GeckoElement
	{
		nsIDOMHTMLDirectoryElement DOMHTMLElement;
		internal GeckoDirectoryElement(nsIDOMHTMLDirectoryElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoDirectoryElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLDirectoryElement;
		}
		public bool Compact {
			get { return DOMHTMLElement.GetCompactAttribute(); }
			set { DOMHTMLElement.SetCompactAttribute(value); }
		}

	}
}

