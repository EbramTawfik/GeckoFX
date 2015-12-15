namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTableColElement : WebIDLBase
    {
        
        public HTMLTableColElement(nsISupports thisObject) : 
                base(thisObject)
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
    }
}
