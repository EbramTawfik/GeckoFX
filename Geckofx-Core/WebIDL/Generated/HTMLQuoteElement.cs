namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLQuoteElement : WebIDLBase
    {
        
        public HTMLQuoteElement(nsISupports thisObject) : 
                base(thisObject)
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
