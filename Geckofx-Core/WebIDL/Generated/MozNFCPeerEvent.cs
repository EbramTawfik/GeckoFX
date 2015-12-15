namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFCPeerEvent : WebIDLBase
    {
        
        public MozNFCPeerEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Peer
        {
            get
            {
                return this.GetProperty<nsISupports>("peer");
            }
        }
    }
}
