namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCPeerConnectionIceEvent : WebIDLBase
    {
        
        public RTCPeerConnectionIceEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Candidate
        {
            get
            {
                return this.GetProperty<nsISupports>("candidate");
            }
        }
    }
}
