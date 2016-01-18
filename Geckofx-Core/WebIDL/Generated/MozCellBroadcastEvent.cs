namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCellBroadcastEvent : WebIDLBase
    {
        
        public MozCellBroadcastEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Message
        {
            get
            {
                return this.GetProperty<nsISupports>("message");
            }
        }
    }
}
