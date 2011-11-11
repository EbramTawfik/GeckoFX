

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoTableSectionElement : GeckoElement
	{
		nsIDOMHTMLTableSectionElement DOMHTMLElement;
		internal GeckoTableSectionElement(nsIDOMHTMLTableSectionElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableSectionElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableSectionElement;
		}
		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

		public string Ch {
			get { return nsString.Get(DOMHTMLElement.GetChAttribute); }
			set { DOMHTMLElement.SetChAttribute(new nsAString(value)); }
		}

		public string ChOff {
			get { return nsString.Get(DOMHTMLElement.GetChOffAttribute); }
			set { DOMHTMLElement.SetChOffAttribute(new nsAString(value)); }
		}

		public string VAlign {
			get { return nsString.Get(DOMHTMLElement.GetVAlignAttribute); }
			set { DOMHTMLElement.SetVAlignAttribute(new nsAString(value)); }
		}

		public GeckoHtmlElementCollection Rows {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetRowsAttribute()); }
		}

		public GeckoElement insertRow(int index)
		{
			return new GeckoElement(DOMHTMLElement.InsertRow(index));
		}

		public void deleteRow(int index)
		{
			DOMHTMLElement.DeleteRow(index);
		}

	}
}
