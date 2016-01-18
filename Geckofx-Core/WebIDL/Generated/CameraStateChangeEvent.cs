namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraStateChangeEvent : WebIDLBase
    {
        
        public CameraStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
