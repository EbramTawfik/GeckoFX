namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBaseElement : WebIDLBase
    {
        
        public HTMLBaseElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
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
    }
}
