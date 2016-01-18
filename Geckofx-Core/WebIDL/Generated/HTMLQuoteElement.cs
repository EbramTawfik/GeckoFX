namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLQuoteElement : WebIDLBase
    {
        
        public HTMLQuoteElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Cite
        {
            get
            {
                return this.GetProperty<nsAString>("cite");
            }
            set
            {
                this.SetProperty("cite", value);
            }
        }
    }
}
