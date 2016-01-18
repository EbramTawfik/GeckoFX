namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileNetworkInfo : WebIDLBase
    {
        
        public MozMobileNetworkInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ShortName
        {
            get
            {
                return this.GetProperty<string>("shortName");
            }
        }
        
        public string LongName
        {
            get
            {
                return this.GetProperty<string>("longName");
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
        
        public MobileNetworkState State
        {
            get
            {
                return this.GetProperty<MobileNetworkState>("state");
            }
        }
    }
}
