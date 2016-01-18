namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCStatsReport : WebIDLBase
    {
        
        public RTCStatsReport(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string MozPcid
        {
            get
            {
                return this.GetProperty<string>("mozPcid");
            }
        }
        
        public object Get(string key)
        {
            return this.CallMethod<object>("get", key);
        }
        
        public bool Has(string key)
        {
            return this.CallMethod<bool>("has", key);
        }
    }
}
