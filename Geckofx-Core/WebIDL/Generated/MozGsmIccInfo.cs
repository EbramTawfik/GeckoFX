namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozGsmIccInfo : WebIDLBase
    {
        
        public MozGsmIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Msisdn
        {
            get
            {
                return this.GetProperty<nsAString>("msisdn");
            }
        }
    }
}
