namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushEvent : WebIDLBase
    {
        
        public PushEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Data
        {
            get
            {
                return this.GetProperty<nsISupports>("data");
            }
        }
    }
}
