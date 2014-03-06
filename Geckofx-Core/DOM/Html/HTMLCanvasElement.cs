

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoCanvasElement : GeckoHtmlElement
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

		public string toDataURL(string type)
		{
			using (nsAString retval = new nsAString(), param = new nsAString(type))
			{
				var instance = Xpcom.CreateInstance<nsIVariant>(Contracts.Variant);
#if PORT
				DOMHTMLElement.ToDataURL(param, instance, 2, retval);
#else
				throw new NotImplementedException("ToDataURL api changed");
#endif
				Marshal.ReleaseComObject(instance);
				return retval.ToString();
			}
		}
	}
}

