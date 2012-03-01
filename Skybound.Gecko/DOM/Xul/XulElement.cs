using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gecko.DOM.Xul
{
	public class XulElement
		:GeckoDomElement
	{
		protected XulElement(nsIDOMXULElement xulElement)
			:base(xulElement)
		{
			
		}


		public static XulElement CreateXulElementWrapper(nsIDOMXULElement xulElement)
		{
			return xulElement == null ? null : new XulElement( xulElement );
		}
	}
}
