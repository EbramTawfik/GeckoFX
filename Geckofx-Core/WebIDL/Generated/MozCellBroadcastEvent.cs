namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCellBroadcastEvent : WebIDLBase
    {
        
        public MozCellBroadcastEvent(nsISupports thisObject) : 
                base(thisObject)
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
