namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventListener : WebIDLBase
    {
        
        public EventListener(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void HandleEvent(nsIDOMEvent @event)
        {
            this.CallVoidMethod("handleEvent", @event);
        }
    }
}
