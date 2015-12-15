namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAreaElement : WebIDLBase
    {
        
        public HTMLAreaElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Alt
        {
            get
            {
                return this.GetProperty<nsAString>("alt");
            }
            set
            {
                this.SetProperty("alt", value);
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
        
        public bool NoHref
        {
            get
            {
                return this.GetProperty<bool>("noHref");
            }
            set
            {
                this.SetProperty("noHref", value);
            }
        }
    }
}
