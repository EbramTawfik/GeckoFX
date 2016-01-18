namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRDevice : WebIDLBase
    {
        
        public VRDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string HardwareUnitId
        {
            get
            {
                return this.GetProperty<string>("hardwareUnitId");
            }
        }
        
        public string DeviceId
        {
            get
            {
                return this.GetProperty<string>("deviceId");
            }
        }
        
        public string DeviceName
        {
            get
            {
                return this.GetProperty<string>("deviceName");
            }
        }
    }
}
