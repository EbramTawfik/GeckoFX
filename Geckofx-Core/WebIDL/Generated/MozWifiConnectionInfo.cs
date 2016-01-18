namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiConnectionInfo : WebIDLBase
    {
        
        public MozWifiConnectionInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public string IpAddress
        {
            get
            {
                return this.GetProperty<string>("ipAddress");
            }
        }
    }
}
