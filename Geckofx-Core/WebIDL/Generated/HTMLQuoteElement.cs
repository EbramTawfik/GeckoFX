namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLQuoteElement : WebIDLBase
    {
        
        public HTMLQuoteElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Cite
        {
            get
            {
                return this.GetProperty<string>("cite");
            }
            set
            {
                this.SetProperty("cite", value);
            }
        }
    }
}
