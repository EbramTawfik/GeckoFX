

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
#if DELME
	public class GeckoParamElement : GeckoHtmlElement
	{
		nsIDOMHTMLParamElement DOMHTMLElement;
		internal GeckoParamElement(nsIDOMHTMLParamElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoParamElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLParamElement;
		}
		public string Name {
			get { return nsString.Get(DOMHTMLElement.GetNameAttribute); }
			set { DOMHTMLElement.SetNameAttribute(new nsAString(value)); }
		}

		public string Type {
			get { return nsString.Get(DOMHTMLElement.GetTypeAttribute); }
			set { DOMHTMLElement.SetTypeAttribute(new nsAString(value)); }
		}

		public string Value {
			get { return nsString.Get(DOMHTMLElement.GetValueAttribute); }
			set { DOMHTMLElement.SetValueAttribute(new nsAString(value)); }
		}

		public string ValueType {
			get { return nsString.Get(DOMHTMLElement.GetValueTypeAttribute); }
			set { DOMHTMLElement.SetValueTypeAttribute(new nsAString(value)); }
		}

	}
#endif
}

