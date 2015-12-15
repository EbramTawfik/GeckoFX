namespace Gecko.WebIDL
{
    using System;
    
    
    public class PageTransitionEvent : WebIDLBase
    {
        
        public PageTransitionEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Persisted
        {
            get
            {
                return this.GetProperty<bool>("persisted");
            }
        }
    }
}
