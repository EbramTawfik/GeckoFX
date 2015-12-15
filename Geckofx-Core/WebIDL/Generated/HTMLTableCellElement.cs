namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableCellElement : WebIDLBase
    {
        
        public HTMLTableCellElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint ColSpan
        {
            get
            {
                return this.GetProperty<uint>("colSpan");
            }
            set
            {
                this.SetProperty("colSpan", value);
            }
        }
        
        public uint RowSpan
        {
            get
            {
                return this.GetProperty<uint>("rowSpan");
            }
            set
            {
                this.SetProperty("rowSpan", value);
            }
        }
        
        public nsAString Headers
        {
            get
            {
                return this.GetProperty<nsAString>("headers");
            }
            set
            {
                this.SetProperty("headers", value);
            }
        }
        
        public int CellIndex
        {
            get
            {
                return this.GetProperty<int>("cellIndex");
            }
        }
        
        public nsAString Abbr
        {
            get
            {
                return this.GetProperty<nsAString>("abbr");
            }
            set
            {
                this.SetProperty("abbr", value);
            }
        }
        
        public nsAString Scope
        {
            get
            {
                return this.GetProperty<nsAString>("scope");
            }
            set
            {
                this.SetProperty("scope", value);
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
        
        public nsAString Axis
        {
            get
            {
                return this.GetProperty<nsAString>("axis");
            }
            set
            {
                this.SetProperty("axis", value);
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
        
        public nsAString Ch
        {
            get
            {
                return this.GetProperty<nsAString>("ch");
            }
            set
            {
                this.SetProperty("ch", value);
            }
        }
        
        public nsAString ChOff
        {
            get
            {
                return this.GetProperty<nsAString>("chOff");
            }
            set
            {
                this.SetProperty("chOff", value);
            }
        }
        
        public bool NoWrap
        {
            get
            {
                return this.GetProperty<bool>("noWrap");
            }
            set
            {
                this.SetProperty("noWrap", value);
            }
        }
        
        public nsAString VAlign
        {
            get
            {
                return this.GetProperty<nsAString>("vAlign");
            }
            set
            {
                this.SetProperty("vAlign", value);
            }
        }
        
        public nsAString BgColor
        {
            get
            {
                return this.GetProperty<nsAString>("bgColor");
            }
            set
            {
                this.SetProperty("bgColor", value);
            }
        }
    }
}
