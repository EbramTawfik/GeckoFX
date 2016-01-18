namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLSourceElement : WebIDLBase
    {
        
        public HTMLSourceElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Src
        {
            get
            {
                return this.GetProperty<string>("src");
            }
            set
            {
                this.SetProperty("src", value);
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
        
        public string Srcset
        {
            get
            {
                return this.GetProperty<string>("srcset");
            }
            set
            {
                this.SetProperty("srcset", value);
            }
        }
        
        public string Sizes
        {
            get
            {
                return this.GetProperty<string>("sizes");
            }
            set
            {
                this.SetProperty("sizes", value);
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
    }
}
