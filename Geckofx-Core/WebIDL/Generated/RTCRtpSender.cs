namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpSender : WebIDLBase
    {
        
        public RTCRtpSender(nsISupports thisObject) : 
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
        
        public Promise ReplaceTrack(nsISupports track)
        {
            return this.CallMethod<Promise>("replaceTrack", track);
        }
    }
}
