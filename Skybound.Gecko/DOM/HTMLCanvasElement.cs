

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoCanvasElement : GeckoElement
	{
		nsIDOMHTMLCanvasElement DOMHTMLElement;
		internal GeckoCanvasElement(nsIDOMHTMLCanvasElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoCanvasElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLCanvasElement;
		}
		public uint Width {
			get { return DOMHTMLElement.GetWidthAttribute(); }
			set { DOMHTMLElement.SetWidthAttribute(value); }
		}

		public uint Height {
			get { return DOMHTMLElement.GetHeightAttribute(); }
			set { DOMHTMLElement.SetHeightAttribute(value); }
		}

		public nsISupports getContext(string contextId)
		{
			return DOMHTMLElement.GetContext(new nsAString(contextId), IntPtr.Zero);
		}

		public string toDataURL(string type)
		{
			using (nsAString retval = new nsAString(), param = new nsAString(type))
			{
				DOMHTMLElement.ToDataURL(param, null, 2, retval);
				return retval.ToString();
			}
		}
	}
}

