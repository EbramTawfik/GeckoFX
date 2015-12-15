namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozGsmIccInfo : WebIDLBase
    {
        
        public MozGsmIccInfo(nsISupports thisObject) : 
                base(thisObject)
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
