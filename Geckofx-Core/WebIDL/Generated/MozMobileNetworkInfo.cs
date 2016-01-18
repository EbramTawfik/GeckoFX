namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileNetworkInfo : WebIDLBase
    {
        
        public MozMobileNetworkInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString ShortName
        {
            get
            {
                return this.GetProperty<nsAString>("shortName");
            }
        }
        
        public nsAString LongName
        {
            get
            {
                return this.GetProperty<nsAString>("longName");
            }
        }
        
        public nsAString Mcc
        {
            get
            {
                return this.GetProperty<nsAString>("mcc");
            }
        }
        
        public nsAString Mnc
        {
            get
            {
                return this.GetProperty<nsAString>("mnc");
            }
        }
        
        public MobileNetworkState State
        {
            get
            {
                return this.GetProperty<MobileNetworkState>("state");
            }
        }
    }
}
