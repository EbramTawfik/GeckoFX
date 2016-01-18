namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTitleElement : WebIDLBase
    {
        
        public HTMLTitleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
    }
}
