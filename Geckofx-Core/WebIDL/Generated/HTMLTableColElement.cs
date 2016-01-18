namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableColElement : WebIDLBase
    {
        
        public HTMLTableColElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint Span
        {
            get
            {
                return this.GetProperty<uint>("span");
            }
            set
            {
                this.SetProperty("span", value);
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
    }
}
