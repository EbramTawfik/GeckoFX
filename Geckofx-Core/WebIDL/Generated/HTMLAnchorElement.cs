namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAnchorElement : WebIDLBase
    {
        
        public HTMLAnchorElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public nsAString Download
        {
            get
            {
                return this.GetProperty<nsAString>("download");
            }
            set
            {
                this.SetProperty("download", value);
            }
        }
        
        public nsAString Ping
        {
            get
            {
                return this.GetProperty<nsAString>("ping");
            }
            set
            {
                this.SetProperty("ping", value);
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
        
        public nsAString ReferrerPolicy
        {
            get
            {
                return this.GetProperty<nsAString>("referrerPolicy");
            }
            set
            {
                this.SetProperty("referrerPolicy", value);
            }
        }
        
        public nsISupports RelList
        {
            get
            {
                return this.GetProperty<nsISupports>("relList");
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
        
        public nsAString Coords
        {
            get
            {
                return this.GetProperty<nsAString>("coords");
            }
            set
            {
                this.SetProperty("coords", value);
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
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
            set
            {
                this.SetProperty("name", value);
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
        
        public nsAString Shape
        {
            get
            {
                return this.GetProperty<nsAString>("shape");
            }
            set
            {
                this.SetProperty("shape", value);
            }
        }
    }
}
