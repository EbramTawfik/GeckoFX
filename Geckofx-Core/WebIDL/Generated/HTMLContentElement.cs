namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLContentElement : WebIDLBase
    {
        
        public HTMLContentElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Select
        {
            get
            {
                return this.GetProperty<string>("select");
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
