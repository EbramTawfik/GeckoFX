namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLAnchorElement : WebIDLBase
    {
        
        public HTMLAnchorElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
            set
            {
                this.SetProperty("name", value);
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
    }
}
