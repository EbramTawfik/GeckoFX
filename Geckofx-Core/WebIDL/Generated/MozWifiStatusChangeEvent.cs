namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiStatusChangeEvent : WebIDLBase
    {
        
        public MozWifiStatusChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Network
        {
            get
            {
                return this.GetProperty<object>("network");
            }
        }
        
        public string Status
        {
            get
            {
                return this.GetProperty<string>("status");
            }
        }
    }
}
