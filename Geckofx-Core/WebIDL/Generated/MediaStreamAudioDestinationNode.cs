namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamAudioDestinationNode : WebIDLBase
    {
        
        public MediaStreamAudioDestinationNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
