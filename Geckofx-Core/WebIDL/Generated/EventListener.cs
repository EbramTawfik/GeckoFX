namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventListener : WebIDLBase
    {
        
        public EventListener(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void HandleEvent(nsIDOMEvent @event)
        {
            this.CallVoidMethod("handleEvent", @event);
        }
    }
}
