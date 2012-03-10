

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Gecko.DOM
{	
	public class GeckoTableElement : GeckoElement
	{
		nsIDOMHTMLTableElement DOMHTMLElement;
		internal GeckoTableElement(nsIDOMHTMLTableElement element) : base(element)
		{
			this.DOMHTMLElement = element;
		}
		public GeckoTableElement(object element) : base(element as nsIDOMHTMLElement)
		{
			this.DOMHTMLElement = element as nsIDOMHTMLTableElement;
		}
		public GeckoTableCaptionElement Caption {
			get { return new GeckoTableCaptionElement(DOMHTMLElement.GetCaptionAttribute()); }
			set { DOMHTMLElement.SetCaptionAttribute(value.DomObject as nsIDOMHTMLTableCaptionElement); }
		}

		public GeckoTableSectionElement THead {
			get { return new GeckoTableSectionElement(DOMHTMLElement.GetTHeadAttribute()); }
			set { DOMHTMLElement.SetTHeadAttribute(value.DomObject as nsIDOMHTMLTableSectionElement); }
		}

		public GeckoTableSectionElement TFoot {
			get { return new GeckoTableSectionElement(DOMHTMLElement.GetTFootAttribute()); }
			set { DOMHTMLElement.SetTFootAttribute(value.DomObject as nsIDOMHTMLTableSectionElement); }
		}

		public GeckoHtmlElementCollection Rows {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetRowsAttribute()); }
		}

		public GeckoHtmlElementCollection TBodies {
			get { return new GeckoHtmlElementCollection(DOMHTMLElement.GetTBodiesAttribute()); }
		}

		public string Align {
			get { return nsString.Get(DOMHTMLElement.GetAlignAttribute); }
			set { DOMHTMLElement.SetAlignAttribute(new nsAString(value)); }
		}

		public string BgColor {
			get { return nsString.Get(DOMHTMLElement.GetBgColorAttribute); }
			set { DOMHTMLElement.SetBgColorAttribute(new nsAString(value)); }
		}

		public string Border {
			get { return nsString.Get(DOMHTMLElement.GetBorderAttribute); }
			set { DOMHTMLElement.SetBorderAttribute(new nsAString(value)); }
		}

		public string CellPadding {
			get { return nsString.Get(DOMHTMLElement.GetCellPaddingAttribute); }
			set { DOMHTMLElement.SetCellPaddingAttribute(new nsAString(value)); }
		}

		public string CellSpacing {
			get { return nsString.Get(DOMHTMLElement.GetCellSpacingAttribute); }
			set { DOMHTMLElement.SetCellSpacingAttribute(new nsAString(value)); }
		}

		public string Frame {
			get { return nsString.Get(DOMHTMLElement.GetFrameAttribute); }
			set { DOMHTMLElement.SetFrameAttribute(new nsAString(value)); }
		}

		public string Rules {
			get { return nsString.Get(DOMHTMLElement.GetRulesAttribute); }
			set { DOMHTMLElement.SetRulesAttribute(new nsAString(value)); }
		}

		public string Summary {
			get { return nsString.Get(DOMHTMLElement.GetSummaryAttribute); }
			set { DOMHTMLElement.SetSummaryAttribute(new nsAString(value)); }
		}

		public string Width {
			get { return nsString.Get(DOMHTMLElement.GetWidthAttribute); }
			set { DOMHTMLElement.SetWidthAttribute(new nsAString(value)); }
		}

		public GeckoElement createTHead()
		{
			return new GeckoElement(DOMHTMLElement.CreateTHead());
		}

		public void deleteTHead()
		{
			DOMHTMLElement.DeleteTHead();
		}

		public GeckoElement createTFoot()
		{
			return new GeckoElement(DOMHTMLElement.CreateTFoot());
		}

		public void deleteTFoot()
		{
			DOMHTMLElement.DeleteTFoot();
		}

		public GeckoElement createCaption()
		{
			return new GeckoElement(DOMHTMLElement.CreateCaption());
		}

		public void deleteCaption()
		{
			DOMHTMLElement.DeleteCaption();
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
