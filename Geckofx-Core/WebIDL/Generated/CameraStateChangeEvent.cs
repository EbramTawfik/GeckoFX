namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraStateChangeEvent : WebIDLBase
    {
        
        public CameraStateChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString NewState
        {
            get
            {
                return this.GetProperty<nsAString>("newState");
            }
        }
    }
}
