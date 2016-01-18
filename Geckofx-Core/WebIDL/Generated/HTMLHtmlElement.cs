namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHtmlElement : WebIDLBase
    {
        
        public HTMLHtmlElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Version
        {
            get
            {
                return this.GetProperty<nsAString>("version");
            }
            set
            {
                this.SetProperty("version", value);
            }
        }
    }
}
