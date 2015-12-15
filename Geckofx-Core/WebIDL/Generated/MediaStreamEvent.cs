namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaStreamEvent : WebIDLBase
    {
        
        public MediaStreamEvent(nsISupports thisObject) : 
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
