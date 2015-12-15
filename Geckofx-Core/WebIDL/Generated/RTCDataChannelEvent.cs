namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCDataChannelEvent : WebIDLBase
    {
        
        public RTCDataChannelEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
    }
}
