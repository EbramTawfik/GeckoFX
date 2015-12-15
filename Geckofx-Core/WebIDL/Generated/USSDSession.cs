namespace Gecko.WebIDL
{
    using System;
    
    
    public class USSDSession : WebIDLBase
    {
        
        public USSDSession(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise Send(nsAString ussd)
        {
            return this.CallMethod<Promise>("send", ussd);
        }
        
        public Promise Cancel()
        {
            return this.CallMethod<Promise>("cancel");
        }
    }
}
