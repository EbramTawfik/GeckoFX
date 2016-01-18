namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLLinkElement : WebIDLBase
    {
        
        public HTMLLinkElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public string Href
        {
            get
            {
                return this.GetProperty<string>("href");
            }
            set
            {
                this.SetProperty("href", value);
            }
        }
        
        public string CrossOrigin
        {
            get
            {
                return this.GetProperty<string>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public string Rel
        {
            get
            {
                return this.GetProperty<string>("rel");
            }
            set
            {
                this.SetProperty("rel", value);
            }
        }
        
        public nsISupports RelList
        {
            get
            {
                return this.GetProperty<nsISupports>("relList");
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
        
        public string Hreflang
        {
            get
            {
                return this.GetProperty<string>("hreflang");
            }
            set
            {
                this.SetProperty("hreflang", value);
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
        
        public nsISupports Sizes
        {
            get
            {
                return this.GetProperty<nsISupports>("sizes");
            }
        }
        
        public string Charset
        {
            get
            {
                return this.GetProperty<string>("charset");
            }
            set
            {
                this.SetProperty("charset", value);
            }
        }
        
        public string Rev
        {
            get
            {
                return this.GetProperty<string>("rev");
            }
            set
            {
                this.SetProperty("rev", value);
            }
        }
        
        public string Target
        {
            get
            {
                return this.GetProperty<string>("target");
            }
            set
            {
                this.SetProperty("target", value);
            }
        }
        
        public nsIDOMDocument Import
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("import");
            }
        }
        
        public string Integrity
        {
            get
            {
                return this.GetProperty<string>("integrity");
            }
            set
            {
                this.SetProperty("integrity", value);
            }
        }
    }
}
