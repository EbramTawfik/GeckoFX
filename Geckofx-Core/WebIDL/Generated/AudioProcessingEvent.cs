namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioProcessingEvent : WebIDLBase
    {
        
        public AudioProcessingEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public double PlaybackTime
        {
            get
            {
                return this.GetProperty<double>("playbackTime");
            }
        }
        
        public nsISupports InputBuffer
        {
            get
            {
                return this.GetProperty<nsISupports>("inputBuffer");
            }
        }
        
        public nsISupports OutputBuffer
        {
            get
            {
                return this.GetProperty<nsISupports>("outputBuffer");
            }
        }
    }
}
