namespace Gecko.WebIDL
{
    using System;
    
    
    public class USSDSession : WebIDLBase
    {
        
        public USSDSession(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise Send(string ussd)
        {
            return this.CallMethod<Promise>("send", ussd);
        }
        
        public Promise Cancel()
        {
            return this.CallMethod<Promise>("cancel");
        }
    }
}
