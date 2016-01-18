namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiStationInfoEvent : WebIDLBase
    {
        
        public MozWifiStationInfoEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public short Station
        {
            get
            {
                return this.GetProperty<short>("station");
            }
        }
    }
}
