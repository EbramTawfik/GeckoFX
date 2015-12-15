namespace Gecko.WebIDL
{
    using System;
    
    
    public class CallEvent : WebIDLBase
    {
        
        public CallEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Call
        {
            get
            {
                return this.GetProperty<nsISupports>("call");
            }
        }
    }
}
