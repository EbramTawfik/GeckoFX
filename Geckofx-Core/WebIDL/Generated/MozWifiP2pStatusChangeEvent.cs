namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pStatusChangeEvent : WebIDLBase
    {
        
        public MozWifiP2pStatusChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString PeerAddress
        {
            get
            {
                return this.GetProperty<nsAString>("peerAddress");
            }
        }
    }
}
