namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableCellElement : WebIDLBase
    {
        
        public HTMLTableCellElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string Headers
        {
            get
            {
                return this.GetProperty<string>("headers");
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
        
        public string Abbr
        {
            get
            {
                return this.GetProperty<string>("abbr");
            }
            set
            {
                this.SetProperty("abbr", value);
            }
        }
        
        public string Scope
        {
            get
            {
                return this.GetProperty<string>("scope");
            }
            set
            {
                this.SetProperty("scope", value);
            }
        }
        
        public string Align
        {
            get
            {
                return this.GetProperty<string>("align");
            }
            set
            {
                this.SetProperty("align", value);
            }
        }
        
        public string Axis
        {
            get
            {
                return this.GetProperty<string>("axis");
            }
            set
            {
                this.SetProperty("axis", value);
            }
        }
        
        public string Height
        {
            get
            {
                return this.GetProperty<string>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public string Width
        {
            get
            {
                return this.GetProperty<string>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public string Ch
        {
            get
            {
                return this.GetProperty<string>("ch");
            }
            set
            {
                this.SetProperty("ch", value);
            }
        }
        
        public string ChOff
        {
            get
            {
                return this.GetProperty<string>("chOff");
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
        
        public string VAlign
        {
            get
            {
                return this.GetProperty<string>("vAlign");
            }
            set
            {
                this.SetProperty("vAlign", value);
            }
        }
        
        public string BgColor
        {
            get
            {
                return this.GetProperty<string>("bgColor");
            }
            set
            {
                this.SetProperty("bgColor", value);
            }
        }
    }
}
