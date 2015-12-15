namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventTarget : WebIDLBase
    {
        
        public EventTarget(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void AddEventListener(nsAString type, nsISupports listener, bool capture, System.Nullable<bool> wantsUntrusted)
        {
            this.CallVoidMethod("addEventListener", type, listener, capture, wantsUntrusted);
        }
        
        public void RemoveEventListener(nsAString type, nsISupports listener, bool capture)
        {
            this.CallVoidMethod("removeEventListener", type, listener, capture);
        }
        
        public bool DispatchEvent(nsIDOMEvent @event)
        {
            return this.CallMethod<bool>("dispatchEvent", @event);
        }
        
        public nsIDOMWindow OwnerGlobal
        {
            get
            {
                return this.GetProperty<nsIDOMWindow>("ownerGlobal");
            }
        }
    }
}
