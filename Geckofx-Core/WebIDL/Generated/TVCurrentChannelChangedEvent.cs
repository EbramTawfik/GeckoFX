namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVCurrentChannelChangedEvent : WebIDLBase
    {
        
        public TVCurrentChannelChangedEvent(nsISupports thisObject) : 
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
