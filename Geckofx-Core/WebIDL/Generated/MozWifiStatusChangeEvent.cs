namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiStatusChangeEvent : WebIDLBase
    {
        
        public MozWifiStatusChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Network
        {
            get
            {
                return this.GetProperty<object>("network");
            }
        }
        
        public nsAString Status
        {
            get
            {
                return this.GetProperty<nsAString>("status");
            }
        }
    }
}
