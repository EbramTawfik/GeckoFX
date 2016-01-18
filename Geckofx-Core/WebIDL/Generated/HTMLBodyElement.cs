namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBodyElement : WebIDLBase
    {
        
        public HTMLBodyElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public nsAString Link
        {
            get
            {
                return this.GetProperty<nsAString>("link");
            }
            set
            {
                this.SetProperty("link", value);
            }
        }
        
        public nsAString VLink
        {
            get
            {
                return this.GetProperty<nsAString>("vLink");
            }
            set
            {
                this.SetProperty("vLink", value);
            }
        }
        
        public nsAString ALink
        {
            get
            {
                return this.GetProperty<nsAString>("aLink");
            }
            set
            {
                this.SetProperty("aLink", value);
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
        
        public nsAString Background
        {
            get
            {
                return this.GetProperty<nsAString>("background");
            }
            set
            {
                this.SetProperty("background", value);
            }
        }
    }
}
