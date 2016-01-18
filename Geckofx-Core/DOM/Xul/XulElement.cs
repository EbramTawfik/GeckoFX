using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gecko.Interop;

namespace Gecko.DOM.Xul
{
	public class XulElement
		:GeckoElement
	{
		protected XulElement(nsIDOMXULElement xulElement)
			:base(xulElement)
		{
			
		}


		public static XulElement CreateXulElementWrapper(nsIDOMXULElement xulElement)
		{
			return xulElement == null ? null : new XulElement( xulElement );
		}

		/// <summary>
		/// Gets the inline style of the XulElement. 
		/// </summary>
		public GeckoStyle Style
		{
			get
			{
				return GeckoStyle.Create(Xpcom.QueryInterface<nsIDOMElementCSSInlineStyle>(DomObject).GetStyleAttribute());
			}
		}

		/// <summary>
		/// Gets style of the XulElement. 
		/// </summary>
		public GeckoStyle ComputedStyle
		{
			get
			{
				nsIDOMCSSStyleDeclaration style;
				using (var element = new ComPtr<nsIDOMElement>(Xpcom.QueryInterface<nsIDOMElement>(this.DomObject)))
				{									
					var window = new WebIDL.Window(OwnerDocument.DefaultView.DomWindow, (nsISupports)OwnerDocument.DefaultView.DomWindow);
                    style =  window.GetComputedStyle(element.Instance);					
				}
				return GeckoStyle.Create(style);
			}
		}
	}
}
