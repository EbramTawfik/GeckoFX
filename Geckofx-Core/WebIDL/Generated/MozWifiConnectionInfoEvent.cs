namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiConnectionInfoEvent : WebIDLBase
    {
        
        public MozWifiConnectionInfoEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
