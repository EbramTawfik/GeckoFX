

using System;
using System.Collections.Generic;
using System.Text;

namespace Skybound.Gecko.DOM
{

    internal static class DOMSelector
    {

        private static List<GeckoClassDesc> Classes = new List<GeckoClassDesc>();

        private struct GeckoClassDesc
        {
            public string TagName { get; set; }
            public Type InterfaceType { get; set; }
            public Type GeckoElement { get; set; }
        }

        static DOMSelector()
        {
            Classes.Add(new GeckoClassDesc() { TagName = "a", InterfaceType = typeof(nsIDOMHTMLAnchorElement), GeckoElement = typeof(GeckoAnchorElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "applet", InterfaceType = typeof(nsIDOMHTMLAppletElement), GeckoElement = typeof(GeckoAppletElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "area", InterfaceType = typeof(nsIDOMHTMLAreaElement), GeckoElement = typeof(GeckoAreaElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "base", InterfaceType = typeof(nsIDOMHTMLBaseElement), GeckoElement = typeof(GeckoBaseElement) });            
            Classes.Add(new GeckoClassDesc() { TagName = "body", InterfaceType = typeof(nsIDOMHTMLBodyElement), GeckoElement = typeof(GeckoBodyElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "br", InterfaceType = typeof(nsIDOMHTMLBRElement), GeckoElement = typeof(GeckoBRElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "button", InterfaceType = typeof(nsIDOMHTMLButtonElement), GeckoElement = typeof(GeckoButtonElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "canvas", InterfaceType = typeof(nsIDOMHTMLCanvasElement), GeckoElement = typeof(GeckoCanvasElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "dir", InterfaceType = typeof(nsIDOMHTMLDirectoryElement), GeckoElement = typeof(GeckoDirectoryElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "div", InterfaceType = typeof(nsIDOMHTMLDivElement), GeckoElement = typeof(GeckoDivElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "dl", InterfaceType = typeof(nsIDOMHTMLDListElement), GeckoElement = typeof(GeckoDListElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "embed", InterfaceType = typeof(nsIDOMHTMLEmbedElement), GeckoElement = typeof(GeckoEmbedElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "fieldset", InterfaceType = typeof(nsIDOMHTMLFieldSetElement), GeckoElement = typeof(GeckoFieldSetElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "font", InterfaceType = typeof(nsIDOMHTMLFontElement), GeckoElement = typeof(GeckoFontElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "form", InterfaceType = typeof(nsIDOMHTMLFormElement), GeckoElement = typeof(GeckoFormElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "frame", InterfaceType = typeof(nsIDOMHTMLFrameElement), GeckoElement = typeof(GeckoFrameElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "frameset", InterfaceType = typeof(nsIDOMHTMLFrameSetElement), GeckoElement = typeof(GeckoFrameSetElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "head", InterfaceType = typeof(nsIDOMHTMLHeadElement), GeckoElement = typeof(GeckoHeadElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h1", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h2", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h3", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h4", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h5", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "h6", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "hr", InterfaceType = typeof(nsIDOMHTMLHRElement), GeckoElement = typeof(GeckoHRElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "html", InterfaceType = typeof(nsIDOMHTMLHtmlElement), GeckoElement = typeof(GeckoHtmlElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "iframe", InterfaceType = typeof(nsIDOMHTMLIFrameElement), GeckoElement = typeof(GeckoIFrameElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "img", InterfaceType = typeof(nsIDOMHTMLImageElement), GeckoElement = typeof(GeckoImageElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "input", InterfaceType = typeof(nsIDOMHTMLInputElement), GeckoElement = typeof(GeckoInputElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "isindex", InterfaceType = typeof(nsIDOMHTMLIsIndexElement), GeckoElement = typeof(GeckoIsIndexElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "label", InterfaceType = typeof(nsIDOMHTMLLabelElement), GeckoElement = typeof(GeckoLabelElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "legend", InterfaceType = typeof(nsIDOMHTMLLegendElement), GeckoElement = typeof(GeckoLegendElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "li", InterfaceType = typeof(nsIDOMHTMLLIElement), GeckoElement = typeof(GeckoLIElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "link", InterfaceType = typeof(nsIDOMHTMLLinkElement), GeckoElement = typeof(GeckoLinkElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "map", InterfaceType = typeof(nsIDOMHTMLMapElement), GeckoElement = typeof(GeckoMapElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "menu", InterfaceType = typeof(nsIDOMHTMLMenuElement), GeckoElement = typeof(GeckoMenuElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "meta", InterfaceType = typeof(nsIDOMHTMLMetaElement), GeckoElement = typeof(GeckoMetaElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "ins", InterfaceType = typeof(nsIDOMHTMLModElement), GeckoElement = typeof(GeckoModElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "del", InterfaceType = typeof(nsIDOMHTMLModElement), GeckoElement = typeof(GeckoModElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "object", InterfaceType = typeof(nsIDOMHTMLObjectElement), GeckoElement = typeof(GeckoObjectElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "ol", InterfaceType = typeof(nsIDOMHTMLOListElement), GeckoElement = typeof(GeckoOListElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "optgroup", InterfaceType = typeof(nsIDOMHTMLOptGroupElement), GeckoElement = typeof(GeckoOptGroupElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "option", InterfaceType = typeof(nsIDOMHTMLOptionElement), GeckoElement = typeof(GeckoOptionElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "p", InterfaceType = typeof(nsIDOMHTMLParagraphElement), GeckoElement = typeof(GeckoParagraphElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "param", InterfaceType = typeof(nsIDOMHTMLParamElement), GeckoElement = typeof(GeckoParamElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "pre", InterfaceType = typeof(nsIDOMHTMLPreElement), GeckoElement = typeof(GeckoPreElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "q", InterfaceType = typeof(nsIDOMHTMLQuoteElement), GeckoElement = typeof(GeckoQuoteElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "script", InterfaceType = typeof(nsIDOMHTMLScriptElement), GeckoElement = typeof(GeckoScriptElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "select", InterfaceType = typeof(nsIDOMHTMLSelectElement), GeckoElement = typeof(GeckoSelectElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "style", InterfaceType = typeof(nsIDOMHTMLStyleElement), GeckoElement = typeof(GeckoStyleElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "caption", InterfaceType = typeof(nsIDOMHTMLTableCaptionElement), GeckoElement = typeof(GeckoTableCaptionElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "td", InterfaceType = typeof(nsIDOMHTMLTableCellElement), GeckoElement = typeof(GeckoTableCellElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "col", InterfaceType = typeof(nsIDOMHTMLTableColElement), GeckoElement = typeof(GeckoTableColElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "table", InterfaceType = typeof(nsIDOMHTMLTableElement), GeckoElement = typeof(GeckoTableElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "tr", InterfaceType = typeof(nsIDOMHTMLTableRowElement), GeckoElement = typeof(GeckoTableRowElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "thead", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "tbody", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "tfoot", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "textarea", InterfaceType = typeof(nsIDOMHTMLTextAreaElement), GeckoElement = typeof(GeckoTextAreaElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "title", InterfaceType = typeof(nsIDOMHTMLTitleElement), GeckoElement = typeof(GeckoTitleElement) });
            Classes.Add(new GeckoClassDesc() { TagName = "ul", InterfaceType = typeof(nsIDOMHTMLUListElement), GeckoElement = typeof(GeckoUListElement) });

        }

        internal static GeckoElement GetClassFor(nsIDOMHTMLElement element)
        {
			foreach (GeckoClassDesc GeckoClass in Classes)
			{
				if (nsString.Get(element.GetTagNameAttribute).ToLower() == GeckoClass.TagName)
				{  
					object HTMLElement = Xpcom.QueryInterface(element,GeckoClass.InterfaceType.GUID);
					if(HTMLElement != null)
						return Activator.CreateInstance(GeckoClass.GeckoElement, new object[] {HTMLElement}) as GeckoElement;
				}
			}
			return null;            
        }
    }
}

