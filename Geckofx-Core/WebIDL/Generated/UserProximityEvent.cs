namespace Gecko.WebIDL
{
    using System;
    
    
    public class UserProximityEvent : WebIDLBase
    {
        
        public UserProximityEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Near
        {
            get
            {
                return this.GetProperty<bool>("near");
            }
        }
    }
}
