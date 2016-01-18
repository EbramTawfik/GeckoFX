namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPServerSocketEvent : WebIDLBase
    {
        
        public TCPServerSocketEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Socket
        {
            get
            {
                return this.GetProperty<nsISupports>("socket");
            }
        }
    }
}
