namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStyleElement : WebIDLBase
    {
        
        public SVGStyleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Xmlspace
        {
            get
            {
                return this.GetProperty<nsAString>("xmlspace");
            }
            set
            {
                this.SetProperty("xmlspace", value);
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
        
        public nsAString Title
        {
            get
            {
                return this.GetProperty<nsAString>("title");
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
