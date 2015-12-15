namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVEITBroadcastedEvent : WebIDLBase
    {
        
        public TVEITBroadcastedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] Programs
        {
            get
            {
                return this.GetProperty<nsISupports[]>("programs");
            }
        }
    }
}
