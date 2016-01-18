namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCRtpSender : WebIDLBase
    {
        
        public RTCRtpSender(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
