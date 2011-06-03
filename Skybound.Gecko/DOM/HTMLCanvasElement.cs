

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
		public int Width {
			get { return DOMHTMLElement.GetWidthAttribute(); }
			set { DOMHTMLElement.SetWidthAttribute(value); }
		}

		public int Height {
			get { return DOMHTMLElement.GetHeightAttribute(); }
			set { DOMHTMLElement.SetHeightAttribute(value); }
		}

		public nsISupports getContext(string contextId)
		{
			return DOMHTMLElement.GetContext(new nsAString(contextId), IntPtr.Zero);
		}

		public string toDataURL()
		{
			return DOMHTMLElement.ToDataURL(null, null).ToString();			
		}

		public string toDataURLAs(string mimeType, string encoderOptions)
		{            
			return DOMHTMLElement.ToDataURLAs(new nsAString(mimeType), new nsAString(encoderOptions)).ToString();         
		}

	}
}

