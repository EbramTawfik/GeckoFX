

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Skybound.Gecko.DOM
{	
	public class GeckoTableRowElement : GeckoElement
	{
		nsIDOMHTMLTableRowElement DOMHTMLElement;
		internal GeckoTableRowElement(nsIDOMHTMLTableRowElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableRowElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableRowElement;
		}
		public int RowIndex {
			get { return DOMHTMLElement.GetRowIndexAttribute(); }
		}

		public int SectionRowIndex {
			get { return DOMHTMLElement.GetSectionRowIndexAttribute(); }
		}

		public GeckoHtmlElementCollection Cells {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetCellsAttribute()); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

		public string BgColor {
			get { return nsString.Get(DOMHTMLElement.GetBgColorAttribute); }
			set { DOMHTMLElement.SetBgColorAttribute(new nsAString(value)); }
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

		public GeckoElement insertCell(int index)
		{
			return new GeckoElement(DOMHTMLElement.InsertCell(index));
		}

		public void deleteCell(int index)
		{
			DOMHTMLElement.DeleteCell(index);
		}

	}
}
