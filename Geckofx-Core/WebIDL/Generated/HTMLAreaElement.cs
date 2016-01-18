namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAreaElement : WebIDLBase
    {
        
        public HTMLAreaElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Alt
        {
            get
            {
                return this.GetProperty<string>("alt");
            }
            set
            {
                this.SetProperty("alt", value);
            }
        }
        
        public string Coords
        {
            get
            {
                return this.GetProperty<string>("coords");
            }
            set
            {
                this.SetProperty("coords", value);
            }
        }
        
        public string Shape
        {
            get
            {
                return this.GetProperty<string>("shape");
            }
            set
            {
                this.SetProperty("shape", value);
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
        
        public string Download
        {
            get
            {
                return this.GetProperty<string>("download");
            }
            set
            {
                this.SetProperty("download", value);
            }
        }
        
        public string Ping
        {
            get
            {
                return this.GetProperty<string>("ping");
            }
            set
            {
                this.SetProperty("ping", value);
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
        
        public string ReferrerPolicy
        {
            get
            {
                return this.GetProperty<string>("referrerPolicy");
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
