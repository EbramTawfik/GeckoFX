namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLLinkElement : WebIDLBase
    {
        
        public HTMLLinkElement(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsAString Href
        {
            get
            {
                return this.GetProperty<nsAString>("href");
            }
            set
            {
                this.SetProperty("href", value);
            }
        }
        
        public nsAString CrossOrigin
        {
            get
            {
                return this.GetProperty<nsAString>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
        
        public nsAString Rel
        {
            get
            {
                return this.GetProperty<nsAString>("rel");
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
        
        public nsAString Hreflang
        {
            get
            {
                return this.GetProperty<nsAString>("hreflang");
            }
            set
            {
                this.SetProperty("hreflang", value);
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
        
        public nsISupports Sizes
        {
            get
            {
                return this.GetProperty<nsISupports>("sizes");
            }
        }
        
        public nsAString Charset
        {
            get
            {
                return this.GetProperty<nsAString>("charset");
            }
            set
            {
                this.SetProperty("charset", value);
            }
        }
        
        public nsAString Rev
        {
            get
            {
                return this.GetProperty<nsAString>("rev");
            }
            set
            {
                this.SetProperty("rev", value);
            }
        }
        
        public nsAString Target
        {
            get
            {
                return this.GetProperty<nsAString>("target");
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
        
        public nsAString Integrity
        {
            get
            {
                return this.GetProperty<nsAString>("integrity");
            }
            set
            {
                this.SetProperty("integrity", value);
            }
        }
    }
}
