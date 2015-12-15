namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpReceiver : WebIDLBase
    {
        
        public RTCRtpReceiver(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
    }
}
