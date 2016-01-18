namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraClosedEvent : WebIDLBase
    {
        
        public CameraClosedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Reason
        {
            get
            {
                return this.GetProperty<string>("reason");
            }
        }
    }
}
