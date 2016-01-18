namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationRequest : WebIDLBase
    {
        
        public PresentationRequest(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Start()
        {
            return this.CallMethod<Promise < nsISupports >>("start");
        }
        
        public Promise < nsISupports > GetAvailability()
        {
            return this.CallMethod<Promise < nsISupports >>("getAvailability");
        }
    }
}
