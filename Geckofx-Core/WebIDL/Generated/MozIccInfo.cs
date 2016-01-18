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
        
        public string Iccid
        {
            get
            {
                return this.GetProperty<string>("iccid");
            }
        }
        
        public string Mcc
        {
            get
            {
                return this.GetProperty<string>("mcc");
            }
        }
        
        public string Mnc
        {
            get
            {
                return this.GetProperty<string>("mnc");
            }
        }
        
        public string Spn
        {
            get
            {
                return this.GetProperty<string>("spn");
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
