namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothLeDeviceEvent : WebIDLBase
    {
        
        public BluetoothLeDeviceEvent(nsISupports thisObject) : 
                base(thisObject)
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
