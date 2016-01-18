namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNFC : WebIDLBase
    {
        
        public MozNFC(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
        }
        
        public void EventListenerWasAdded(string aType)
        {
            this.CallVoidMethod("eventListenerWasAdded", aType);
        }
        
        public void EventListenerWasRemoved(string aType)
        {
            this.CallVoidMethod("eventListenerWasRemoved", aType);
        }
    }
}
