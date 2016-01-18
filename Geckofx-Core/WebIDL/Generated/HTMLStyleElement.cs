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
        
        public string Media
        {
            get
            {
                return this.GetProperty<string>("media");
            }
            set
            {
                this.SetProperty("media", value);
            }
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
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
