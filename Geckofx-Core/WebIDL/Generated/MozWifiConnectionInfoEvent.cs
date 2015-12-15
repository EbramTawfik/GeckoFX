namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiConnectionInfoEvent : WebIDLBase
    {
        
        public MozWifiConnectionInfoEvent(nsISupports thisObject) : 
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
        
        public short SignalStrength
        {
            get
            {
                return this.GetProperty<short>("signalStrength");
            }
        }
        
        public short RelSignalStrength
        {
            get
            {
                return this.GetProperty<short>("relSignalStrength");
            }
        }
        
        public int LinkSpeed
        {
            get
            {
                return this.GetProperty<int>("linkSpeed");
            }
        }
        
        public nsAString IpAddress
        {
            get
            {
                return this.GetProperty<nsAString>("ipAddress");
            }
        }
    }
}
