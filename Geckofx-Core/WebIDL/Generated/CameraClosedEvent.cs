namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraClosedEvent : WebIDLBase
    {
        
        public CameraClosedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Reason
        {
            get
            {
                return this.GetProperty<nsAString>("reason");
            }
        }
    }
}
