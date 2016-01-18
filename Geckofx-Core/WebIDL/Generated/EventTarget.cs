namespace Gecko.WebIDL
{
    using System;
    
    
    public class EventTarget : WebIDLBase
    {
        
        public EventTarget(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void AddEventListener(nsAString type, nsISupports listener)
        {
            this.CallVoidMethod("addEventListener", type, listener);
        }
        
        public void AddEventListener(nsAString type, nsISupports listener, bool capture)
        {
            this.CallVoidMethod("addEventListener", type, listener, capture);
        }
        
        public void AddEventListener(nsAString type, nsISupports listener, bool capture, System.Nullable<bool> wantsUntrusted)
        {
            this.CallVoidMethod("addEventListener", type, listener, capture, wantsUntrusted);
        }
        
        public void RemoveEventListener(nsAString type, nsISupports listener)
        {
            this.CallVoidMethod("removeEventListener", type, listener);
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
