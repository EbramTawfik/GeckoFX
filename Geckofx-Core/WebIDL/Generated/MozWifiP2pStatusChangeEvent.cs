namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pStatusChangeEvent : WebIDLBase
    {
        
        public MozWifiP2pStatusChangeEvent(nsISupports thisObject) : 
                base(thisObject)
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
