namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBodyElement : WebIDLBase
    {
        
        public HTMLBodyElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Text
        {
            get
            {
                return this.GetProperty<string>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public string Link
        {
            get
            {
                return this.GetProperty<string>("link");
            }
            set
            {
                this.SetProperty("link", value);
            }
        }
        
        public string VLink
        {
            get
            {
                return this.GetProperty<string>("vLink");
            }
            set
            {
                this.SetProperty("vLink", value);
            }
        }
        
        public string ALink
        {
            get
            {
                return this.GetProperty<string>("aLink");
            }
            set
            {
                this.SetProperty("aLink", value);
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
        
        public string Background
        {
            get
            {
                return this.GetProperty<string>("background");
            }
            set
            {
                this.SetProperty("background", value);
            }
        }
    }
}
