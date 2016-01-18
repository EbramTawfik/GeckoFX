namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLStyleElement : WebIDLBase
    {
        
        public HTMLStyleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Disabled
        {
            get
            {
                return this.GetProperty<bool>("disabled");
            }
            set
            {
                this.SetProperty("disabled", value);
            }
        }
        
        public nsAString Media
        {
            get
            {
                return this.GetProperty<nsAString>("media");
            }
            set
            {
                this.SetProperty("media", value);
            }
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public bool Scoped
        {
            get
            {
                return this.GetProperty<bool>("scoped");
            }
            set
            {
                this.SetProperty("scoped", value);
            }
        }
    }
}
