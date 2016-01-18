namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiConnection : WebIDLBase
    {
        
        public MozWifiConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ConnectionStatus Status
        {
            get
            {
                return this.GetProperty<ConnectionStatus>("status");
            }
        }
        
        public nsISupports Network
        {
            get
            {
                return this.GetProperty<nsISupports>("network");
            }
        }
    }
}
