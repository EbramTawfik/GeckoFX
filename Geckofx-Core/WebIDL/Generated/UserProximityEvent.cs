namespace Gecko.WebIDL
{
    using System;
    
    
    public class UserProximityEvent : WebIDLBase
    {
        
        public UserProximityEvent(nsISupports thisObject) : 
                base(thisObject)
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
