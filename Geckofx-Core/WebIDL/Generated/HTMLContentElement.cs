namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLContentElement : WebIDLBase
    {
        
        public HTMLContentElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Select
        {
            get
            {
                return this.GetProperty<nsAString>("select");
            }
            set
            {
                this.SetProperty("select", value);
            }
        }
        
        public nsISupports GetDistributedNodes()
        {
            return this.CallMethod<nsISupports>("getDistributedNodes");
        }
    }
}
