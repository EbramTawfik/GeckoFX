namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothClassOfDevice : WebIDLBase
    {
        
        public BluetoothClassOfDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort MajorServiceClass
        {
            get
            {
                return this.GetProperty<ushort>("majorServiceClass");
            }
        }
        
        public byte MajorDeviceClass
        {
            get
            {
                return this.GetProperty<byte>("majorDeviceClass");
            }
        }
        
        public byte MinorDeviceClass
        {
            get
            {
                return this.GetProperty<byte>("minorDeviceClass");
            }
        }
    }
}
