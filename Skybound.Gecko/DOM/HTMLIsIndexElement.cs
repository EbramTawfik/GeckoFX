

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoIsIndexElement : GeckoElement
	{
		nsIDOMHTMLIsIndexElement DOMHTMLElement;
		internal GeckoIsIndexElement(nsIDOMHTMLIsIndexElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoIsIndexElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLIsIndexElement;
		}
		public GeckoFormElement Form {
			get { return new GeckoFormElement(DOMHTMLElement.GetFormAttribute()); }
		}

		public string Prompt {
			get { return nsString.Get(DOMHTMLElement.GetPromptAttribute); }
			set { DOMHTMLElement.SetPromptAttribute(new nsAString(value)); }
		}

	}
}

