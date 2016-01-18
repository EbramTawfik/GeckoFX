namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLSourceElement : WebIDLBase
    {
        
        public HTMLSourceElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Src
        {
            get
            {
                return this.GetProperty<nsAString>("src");
            }
            set
            {
                this.SetProperty("src", value);
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
        
        public nsAString Srcset
        {
            get
            {
                return this.GetProperty<nsAString>("srcset");
            }
            set
            {
                this.SetProperty("srcset", value);
            }
        }
        
        public nsAString Sizes
        {
            get
            {
                return this.GetProperty<nsAString>("sizes");
            }
            set
            {
                this.SetProperty("sizes", value);
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
    }
}
