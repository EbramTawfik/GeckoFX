namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLHtmlElement : WebIDLBase
    {
        
        public HTMLHtmlElement(nsISupports thisObject) : 
                base(thisObject)
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
