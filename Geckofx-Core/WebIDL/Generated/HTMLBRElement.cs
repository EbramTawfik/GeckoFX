namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLBRElement : WebIDLBase
    {
        
        public HTMLBRElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Clear
        {
            get
            {
                return this.GetProperty<nsAString>("clear");
            }
            set
            {
                this.SetProperty("clear", value);
            }
        }
    }
}
