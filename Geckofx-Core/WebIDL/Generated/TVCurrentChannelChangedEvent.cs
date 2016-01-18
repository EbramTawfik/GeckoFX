namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVCurrentChannelChangedEvent : WebIDLBase
    {
        
        public TVCurrentChannelChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
