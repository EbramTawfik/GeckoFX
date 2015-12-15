namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationRequest : WebIDLBase
    {
        
        public PresentationRequest(nsISupports thisObject) : 
                base(thisObject)
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
