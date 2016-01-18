namespace Gecko.WebIDL
{
    using System;
    
    
    public class XULElement : WebIDLBase
    {
        
        public XULElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString ClassName
        {
            get
            {
                return this.GetProperty<nsAString>("className");
            }
            set
            {
                this.SetProperty("className", value);
            }
        }
        
        public nsAString Align
        {
            get
            {
                return this.GetProperty<nsAString>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public nsAString Dir
        {
            get
            {
                return this.GetProperty<nsAString>("dir");
            }
            set
            {
                this.SetProperty("dir", value);
            }
        }
        
        public nsAString Flex
        {
            get
            {
                return this.GetProperty<nsAString>("flex");
            }
            set
            {
                this.SetProperty("flex", value);
            }
        }
        
        public nsAString FlexGroup
        {
            get
            {
                return this.GetProperty<nsAString>("flexGroup");
            }
            set
            {
                this.SetProperty("flexGroup", value);
            }
        }
        
        public nsAString Ordinal
        {
            get
            {
                return this.GetProperty<nsAString>("ordinal");
            }
            set
            {
                this.SetProperty("ordinal", value);
            }
        }
        
        public nsAString Orient
        {
            get
            {
                return this.GetProperty<nsAString>("orient");
            }
            set
            {
                this.SetProperty("orient", value);
            }
        }
        
        public nsAString Pack
        {
            get
            {
                return this.GetProperty<nsAString>("pack");
            }
            set
            {
                this.SetProperty("pack", value);
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.GetProperty<bool>("hidden");
            }
            set
            {
                this.SetProperty("hidden", value);
            }
        }
        
        public bool Collapsed
        {
            get
            {
                return this.GetProperty<bool>("collapsed");
            }
            set
            {
                this.SetProperty("collapsed", value);
            }
        }
        
        public nsAString Observes
        {
            get
            {
                return this.GetProperty<nsAString>("observes");
            }
            set
            {
                this.SetProperty("observes", value);
            }
        }
        
        public nsAString Menu
        {
            get
            {
                return this.GetProperty<nsAString>("menu");
            }
            set
            {
                this.SetProperty("menu", value);
            }
        }
        
        public nsAString ContextMenu
        {
            get
            {
                return this.GetProperty<nsAString>("contextMenu");
            }
            set
            {
                this.SetProperty("contextMenu", value);
            }
        }
        
        public nsAString Tooltip
        {
            get
            {
                return this.GetProperty<nsAString>("tooltip");
            }
            set
            {
                this.SetProperty("tooltip", value);
            }
        }
        
        public nsAString Width
        {
            get
            {
                return this.GetProperty<nsAString>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public nsAString Height
        {
            get
            {
                return this.GetProperty<nsAString>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public nsAString MinWidth
        {
            get
            {
                return this.GetProperty<nsAString>("minWidth");
            }
            set
            {
                this.SetProperty("minWidth", value);
            }
        }
        
        public nsAString MinHeight
        {
            get
            {
                return this.GetProperty<nsAString>("minHeight");
            }
            set
            {
                this.SetProperty("minHeight", value);
            }
        }
        
        public nsAString MaxWidth
        {
            get
            {
                return this.GetProperty<nsAString>("maxWidth");
            }
            set
            {
                this.SetProperty("maxWidth", value);
            }
        }
        
        public nsAString MaxHeight
        {
            get
            {
                return this.GetProperty<nsAString>("maxHeight");
            }
            set
            {
                this.SetProperty("maxHeight", value);
            }
        }
        
        public nsAString Persist
        {
            get
            {
                return this.GetProperty<nsAString>("persist");
            }
            set
            {
                this.SetProperty("persist", value);
            }
        }
        
        public nsAString Left
        {
            get
            {
                return this.GetProperty<nsAString>("left");
            }
            set
            {
                this.SetProperty("left", value);
            }
        }
        
        public nsAString Top
        {
            get
            {
                return this.GetProperty<nsAString>("top");
            }
            set
            {
                this.SetProperty("top", value);
            }
        }
        
        public nsAString Datasources
        {
            get
            {
                return this.GetProperty<nsAString>("datasources");
            }
            set
            {
                this.SetProperty("datasources", value);
            }
        }
        
        public nsAString Ref
        {
            get
            {
                return this.GetProperty<nsAString>("ref");
            }
            set
            {
                this.SetProperty("ref", value);
            }
        }
        
        public nsAString TooltipText
        {
            get
            {
                return this.GetProperty<nsAString>("tooltipText");
            }
            set
            {
                this.SetProperty("tooltipText", value);
            }
        }
        
        public nsAString StatusText
        {
            get
            {
                return this.GetProperty<nsAString>("statusText");
            }
            set
            {
                this.SetProperty("statusText", value);
            }
        }
        
        public bool AllowEvents
        {
            get
            {
                return this.GetProperty<bool>("allowEvents");
            }
            set
            {
                this.SetProperty("allowEvents", value);
            }
        }
        
        public nsISupports Database
        {
            get
            {
                return this.GetProperty<nsISupports>("database");
            }
        }
        
        public nsISupports Builder
        {
            get
            {
                return this.GetProperty<nsISupports>("builder");
            }
        }
        
        public nsISupports Resource
        {
            get
            {
                return this.GetProperty<nsISupports>("resource");
            }
        }
        
        public nsISupports Controllers
        {
            get
            {
                return this.GetProperty<nsISupports>("controllers");
            }
        }
        
        public nsISupports BoxObject
        {
            get
            {
                return this.GetProperty<nsISupports>("boxObject");
            }
        }
        
        public nsIDOMCSSStyleDeclaration Style
        {
            get
            {
                return this.GetProperty<nsIDOMCSSStyleDeclaration>("style");
            }
        }
        
        public void Focus()
        {
            this.CallVoidMethod("focus");
        }
        
        public void Blur()
        {
            this.CallVoidMethod("blur");
        }
        
        public void Click()
        {
            this.CallVoidMethod("click");
        }
        
        public void DoCommand()
        {
            this.CallVoidMethod("doCommand");
        }
        
        public nsISupports GetElementsByAttribute(nsAString name, nsAString value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttribute", name, value);
        }
        
        public nsISupports GetElementsByAttributeNS(nsAString namespaceURI, nsAString name, nsAString value)
        {
            return this.CallMethod<nsISupports>("getElementsByAttributeNS", namespaceURI, name, value);
        }
    }
}
