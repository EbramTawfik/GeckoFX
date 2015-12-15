namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothClassOfDevice : WebIDLBase
    {
        
        public BluetoothClassOfDevice(nsISupports thisObject) : 
                base(thisObject)
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
