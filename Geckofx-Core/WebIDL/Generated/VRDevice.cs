namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRDevice : WebIDLBase
    {
        
        public VRDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString HardwareUnitId
        {
            get
            {
                return this.GetProperty<nsAString>("hardwareUnitId");
            }
        }
        
        public nsAString DeviceId
        {
            get
            {
                return this.GetProperty<nsAString>("deviceId");
            }
        }
        
        public nsAString DeviceName
        {
            get
            {
                return this.GetProperty<nsAString>("deviceName");
            }
        }
    }
}
