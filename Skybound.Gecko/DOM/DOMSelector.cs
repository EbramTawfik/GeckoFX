

using System;
using System.Collections.Generic;
using System.Text;

namespace Skybound.Gecko.DOM
{
    internal static class DOMSelector
    {
    	private static readonly Dictionary<string, GeckoClassDesc> _dictionary =
    		new Dictionary<string, GeckoClassDesc>();

        private struct GeckoClassDesc
        {
            public string TagName { get; set; }
            public Type InterfaceType { get; set; }
            public Type GeckoElement { get; set; }
        }

		private static void Add(GeckoClassDesc classDesc)
		{
			_dictionary.Add( classDesc.TagName.ToLower(), classDesc );
		}

        static DOMSelector()
        {
            Add(new GeckoClassDesc() { TagName = "a", InterfaceType = typeof(nsIDOMHTMLAnchorElement), GeckoElement = typeof(GeckoAnchorElement) });
            Add(new GeckoClassDesc() { TagName = "applet", InterfaceType = typeof(nsIDOMHTMLAppletElement), GeckoElement = typeof(GeckoAppletElement) });
            Add(new GeckoClassDesc() { TagName = "area", InterfaceType = typeof(nsIDOMHTMLAreaElement), GeckoElement = typeof(GeckoAreaElement) });
            Add(new GeckoClassDesc() { TagName = "base", InterfaceType = typeof(nsIDOMHTMLBaseElement), GeckoElement = typeof(GeckoBaseElement) });            
            Add(new GeckoClassDesc() { TagName = "body", InterfaceType = typeof(nsIDOMHTMLBodyElement), GeckoElement = typeof(GeckoBodyElement) });
            Add(new GeckoClassDesc() { TagName = "br", InterfaceType = typeof(nsIDOMHTMLBRElement), GeckoElement = typeof(GeckoBRElement) });
            Add(new GeckoClassDesc() { TagName = "button", InterfaceType = typeof(nsIDOMHTMLButtonElement), GeckoElement = typeof(GeckoButtonElement) });
            Add(new GeckoClassDesc() { TagName = "canvas", InterfaceType = typeof(nsIDOMHTMLCanvasElement), GeckoElement = typeof(GeckoCanvasElement) });
            Add(new GeckoClassDesc() { TagName = "dir", InterfaceType = typeof(nsIDOMHTMLDirectoryElement), GeckoElement = typeof(GeckoDirectoryElement) });
            Add(new GeckoClassDesc() { TagName = "div", InterfaceType = typeof(nsIDOMHTMLDivElement), GeckoElement = typeof(GeckoDivElement) });
            Add(new GeckoClassDesc() { TagName = "dl", InterfaceType = typeof(nsIDOMHTMLDListElement), GeckoElement = typeof(GeckoDListElement) });
            Add(new GeckoClassDesc() { TagName = "embed", InterfaceType = typeof(nsIDOMHTMLEmbedElement), GeckoElement = typeof(GeckoEmbedElement) });
            Add(new GeckoClassDesc() { TagName = "fieldset", InterfaceType = typeof(nsIDOMHTMLFieldSetElement), GeckoElement = typeof(GeckoFieldSetElement) });
            Add(new GeckoClassDesc() { TagName = "font", InterfaceType = typeof(nsIDOMHTMLFontElement), GeckoElement = typeof(GeckoFontElement) });
            Add(new GeckoClassDesc() { TagName = "form", InterfaceType = typeof(nsIDOMHTMLFormElement), GeckoElement = typeof(GeckoFormElement) });
            Add(new GeckoClassDesc() { TagName = "frame", InterfaceType = typeof(nsIDOMHTMLFrameElement), GeckoElement = typeof(GeckoFrameElement) });
            Add(new GeckoClassDesc() { TagName = "frameset", InterfaceType = typeof(nsIDOMHTMLFrameSetElement), GeckoElement = typeof(GeckoFrameSetElement) });
            Add(new GeckoClassDesc() { TagName = "head", InterfaceType = typeof(nsIDOMHTMLHeadElement), GeckoElement = typeof(GeckoHeadElement) });
            Add(new GeckoClassDesc() { TagName = "h1", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "h2", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "h3", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "h4", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "h5", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "h6", InterfaceType = typeof(nsIDOMHTMLHeadingElement), GeckoElement = typeof(GeckoHeadingElement) });
            Add(new GeckoClassDesc() { TagName = "hr", InterfaceType = typeof(nsIDOMHTMLHRElement), GeckoElement = typeof(GeckoHRElement) });
            Add(new GeckoClassDesc() { TagName = "html", InterfaceType = typeof(nsIDOMHTMLHtmlElement), GeckoElement = typeof(GeckoHtmlElement) });
            Add(new GeckoClassDesc() { TagName = "iframe", InterfaceType = typeof(nsIDOMHTMLIFrameElement), GeckoElement = typeof(GeckoIFrameElement) });
            Add(new GeckoClassDesc() { TagName = "img", InterfaceType = typeof(nsIDOMHTMLImageElement), GeckoElement = typeof(GeckoImageElement) });
            Add(new GeckoClassDesc() { TagName = "input", InterfaceType = typeof(nsIDOMHTMLInputElement), GeckoElement = typeof(GeckoInputElement) });
            Add(new GeckoClassDesc() { TagName = "isindex", InterfaceType = typeof(nsIDOMHTMLIsIndexElement), GeckoElement = typeof(GeckoIsIndexElement) });
            Add(new GeckoClassDesc() { TagName = "label", InterfaceType = typeof(nsIDOMHTMLLabelElement), GeckoElement = typeof(GeckoLabelElement) });
            Add(new GeckoClassDesc() { TagName = "legend", InterfaceType = typeof(nsIDOMHTMLLegendElement), GeckoElement = typeof(GeckoLegendElement) });
            Add(new GeckoClassDesc() { TagName = "li", InterfaceType = typeof(nsIDOMHTMLLIElement), GeckoElement = typeof(GeckoLIElement) });
            Add(new GeckoClassDesc() { TagName = "link", InterfaceType = typeof(nsIDOMHTMLLinkElement), GeckoElement = typeof(GeckoLinkElement) });
            Add(new GeckoClassDesc() { TagName = "map", InterfaceType = typeof(nsIDOMHTMLMapElement), GeckoElement = typeof(GeckoMapElement) });
            Add(new GeckoClassDesc() { TagName = "menu", InterfaceType = typeof(nsIDOMHTMLMenuElement), GeckoElement = typeof(GeckoMenuElement) });
            Add(new GeckoClassDesc() { TagName = "meta", InterfaceType = typeof(nsIDOMHTMLMetaElement), GeckoElement = typeof(GeckoMetaElement) });
            Add(new GeckoClassDesc() { TagName = "ins", InterfaceType = typeof(nsIDOMHTMLModElement), GeckoElement = typeof(GeckoModElement) });
            Add(new GeckoClassDesc() { TagName = "del", InterfaceType = typeof(nsIDOMHTMLModElement), GeckoElement = typeof(GeckoModElement) });
            Add(new GeckoClassDesc() { TagName = "object", InterfaceType = typeof(nsIDOMHTMLObjectElement), GeckoElement = typeof(GeckoObjectElement) });
            Add(new GeckoClassDesc() { TagName = "ol", InterfaceType = typeof(nsIDOMHTMLOListElement), GeckoElement = typeof(GeckoOListElement) });
            Add(new GeckoClassDesc() { TagName = "optgroup", InterfaceType = typeof(nsIDOMHTMLOptGroupElement), GeckoElement = typeof(GeckoOptGroupElement) });
            Add(new GeckoClassDesc() { TagName = "option", InterfaceType = typeof(nsIDOMHTMLOptionElement), GeckoElement = typeof(GeckoOptionElement) });
            Add(new GeckoClassDesc() { TagName = "p", InterfaceType = typeof(nsIDOMHTMLParagraphElement), GeckoElement = typeof(GeckoParagraphElement) });
            Add(new GeckoClassDesc() { TagName = "param", InterfaceType = typeof(nsIDOMHTMLParamElement), GeckoElement = typeof(GeckoParamElement) });
            Add(new GeckoClassDesc() { TagName = "pre", InterfaceType = typeof(nsIDOMHTMLPreElement), GeckoElement = typeof(GeckoPreElement) });
            Add(new GeckoClassDesc() { TagName = "q", InterfaceType = typeof(nsIDOMHTMLQuoteElement), GeckoElement = typeof(GeckoQuoteElement) });
            Add(new GeckoClassDesc() { TagName = "script", InterfaceType = typeof(nsIDOMHTMLScriptElement), GeckoElement = typeof(GeckoScriptElement) });
            Add(new GeckoClassDesc() { TagName = "select", InterfaceType = typeof(nsIDOMHTMLSelectElement), GeckoElement = typeof(GeckoSelectElement) });
            Add(new GeckoClassDesc() { TagName = "style", InterfaceType = typeof(nsIDOMHTMLStyleElement), GeckoElement = typeof(GeckoStyleElement) });
            Add(new GeckoClassDesc() { TagName = "caption", InterfaceType = typeof(nsIDOMHTMLTableCaptionElement), GeckoElement = typeof(GeckoTableCaptionElement) });
            Add(new GeckoClassDesc() { TagName = "td", InterfaceType = typeof(nsIDOMHTMLTableCellElement), GeckoElement = typeof(GeckoTableCellElement) });
            Add(new GeckoClassDesc() { TagName = "col", InterfaceType = typeof(nsIDOMHTMLTableColElement), GeckoElement = typeof(GeckoTableColElement) });
            Add(new GeckoClassDesc() { TagName = "table", InterfaceType = typeof(nsIDOMHTMLTableElement), GeckoElement = typeof(GeckoTableElement) });
            Add(new GeckoClassDesc() { TagName = "tr", InterfaceType = typeof(nsIDOMHTMLTableRowElement), GeckoElement = typeof(GeckoTableRowElement) });
            Add(new GeckoClassDesc() { TagName = "thead", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Add(new GeckoClassDesc() { TagName = "tbody", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Add(new GeckoClassDesc() { TagName = "tfoot", InterfaceType = typeof(nsIDOMHTMLTableSectionElement), GeckoElement = typeof(GeckoTableSectionElement) });
            Add(new GeckoClassDesc() { TagName = "textarea", InterfaceType = typeof(nsIDOMHTMLTextAreaElement), GeckoElement = typeof(GeckoTextAreaElement) });
            Add(new GeckoClassDesc() { TagName = "title", InterfaceType = typeof(nsIDOMHTMLTitleElement), GeckoElement = typeof(GeckoTitleElement) });
            Add(new GeckoClassDesc() { TagName = "ul", InterfaceType = typeof(nsIDOMHTMLUListElement), GeckoElement = typeof(GeckoUListElement) });
        }

		internal static GeckoElement GetClassFor(nsIDOMHTMLElement element)
		{
			GeckoElement ret = GetClassFor<GeckoElement>(element);
			if (ret == null)
				ret = new GeckoElement(element);
			return ret;
		}

        internal static T GetClassFor<T>(nsIDOMHTMLElement element)  where T : GeckoElement
        {
        	var lowerTagName = nsString.Get( element.GetTagNameAttribute ).ToLower();
        	GeckoClassDesc desc;

			if (_dictionary.TryGetValue(lowerTagName,out desc ))
			{
				object HTMLElement = Xpcom.QueryInterface(element,desc.InterfaceType.GUID);
				if(HTMLElement != null)
				{
					object o = Activator.CreateInstance( desc.GeckoElement, new object[] {HTMLElement} );
					if (o is T)
						return (T)o;
				}
			}
			return null;
        }
    }
}

