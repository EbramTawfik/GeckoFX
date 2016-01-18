namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothLeDeviceEvent : WebIDLBase
    {
        
        public BluetoothLeDeviceEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Device
        {
            get
            {
                return this.GetProperty<nsISupports>("device");
            }
        }
        
        public short Rssi
        {
            get
            {
                return this.GetProperty<short>("rssi");
            }
        }
        
        public IntPtr ScanRecord
        {
            get
            {
                return this.GetProperty<IntPtr>("scanRecord");
            }
        }
    }
}
