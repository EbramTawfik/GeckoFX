namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCStatsReport : WebIDLBase
    {
        
        public RTCStatsReport(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString MozPcid
        {
            get
            {
                return this.GetProperty<nsAString>("mozPcid");
            }
        }
        
        public object Get(nsAString key)
        {
            return this.CallMethod<object>("get", key);
        }
        
        public bool Has(nsAString key)
        {
            return this.CallMethod<bool>("has", key);
        }
    }
}
