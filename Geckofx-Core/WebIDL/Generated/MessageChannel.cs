namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessageChannel : WebIDLBase
    {
        
        public MessageChannel(nsISupports thisObject) : 
                base(thisObject)
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
