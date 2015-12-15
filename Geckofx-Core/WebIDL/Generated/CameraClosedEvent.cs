namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraClosedEvent : WebIDLBase
    {
        
        public CameraClosedEvent(nsISupports thisObject) : 
                base(thisObject)
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
