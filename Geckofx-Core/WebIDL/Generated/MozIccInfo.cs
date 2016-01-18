namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozIccInfo : WebIDLBase
    {
        
        public MozIccInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IccType IccType
        {
            get
            {
                return this.GetProperty<IccType>("iccType");
            }
        }
        
        public nsAString Iccid
        {
            get
            {
                return this.GetProperty<nsAString>("iccid");
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
        
        public nsAString Spn
        {
            get
            {
                return this.GetProperty<nsAString>("spn");
            }
        }
        
        public bool IsDisplayNetworkNameRequired
        {
            get
            {
                return this.GetProperty<bool>("isDisplayNetworkNameRequired");
            }
        }
        
        public bool IsDisplaySpnRequired
        {
            get
            {
                return this.GetProperty<bool>("isDisplaySpnRequired");
            }
        }
    }
}
