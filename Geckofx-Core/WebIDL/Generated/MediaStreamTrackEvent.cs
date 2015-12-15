namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamTrackEvent : WebIDLBase
    {
        
        public MediaStreamTrackEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Receiver
        {
            get
            {
                return this.GetProperty<nsISupports>("receiver");
            }
        }
        
        public nsISupports Track
        {
            get
            {
                return this.GetProperty<nsISupports>("track");
            }
        }
        
        public nsISupports Stream
        {
            get
            {
                return this.GetProperty<nsISupports>("stream");
            }
        }
    }
}
