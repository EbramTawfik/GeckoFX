namespace Gecko.WebIDL
{
    using System;
    
    
    public class TCPServerSocketEvent : WebIDLBase
    {
        
        public TCPServerSocketEvent(nsISupports thisObject) : 
                base(thisObject)
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
