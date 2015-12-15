namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiStationInfoEvent : WebIDLBase
    {
        
        public MozWifiStationInfoEvent(nsISupports thisObject) : 
                base(thisObject)
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
