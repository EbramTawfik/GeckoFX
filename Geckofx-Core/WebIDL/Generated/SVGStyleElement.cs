namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStyleElement : WebIDLBase
    {
        
        public SVGStyleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Xmlspace
        {
            get
            {
                return this.GetProperty<string>("xmlspace");
            }
            set
            {
                this.SetProperty("xmlspace", value);
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
        
        public string Title
        {
            get
            {
                return this.GetProperty<string>("title");
            }
            set
            {
                this.SetProperty("title", value);
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
