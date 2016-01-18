namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBaseElement : WebIDLBase
    {
        
        public HTMLBaseElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Href
        {
            get
            {
                return this.GetProperty<string>("href");
            }
            set
            {
                this.SetProperty("href", value);
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
    }
}
