namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamAudioDestinationNode : WebIDLBase
    {
        
        public MediaStreamAudioDestinationNode(nsISupports thisObject) : 
                base(thisObject)
        {
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
