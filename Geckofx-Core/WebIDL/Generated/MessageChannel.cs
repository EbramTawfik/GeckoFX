namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessageChannel : WebIDLBase
    {
        
        public MessageChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Port1
        {
            get
            {
                return this.GetProperty<nsISupports>("port1");
            }
        }
        
        public nsISupports Port2
        {
            get
            {
                return this.GetProperty<nsISupports>("port2");
            }
        }
    }
}
