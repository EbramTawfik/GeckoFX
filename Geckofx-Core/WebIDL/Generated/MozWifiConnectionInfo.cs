namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiConnectionInfo : WebIDLBase
    {
        
        public MozWifiConnectionInfo(nsISupports thisObject) : 
                base(thisObject)
        {
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
