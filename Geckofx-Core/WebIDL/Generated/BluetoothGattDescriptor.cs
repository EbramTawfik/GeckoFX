namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattDescriptor : WebIDLBase
    {
        
        public BluetoothGattDescriptor(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Characteristic
        {
            get
            {
                return this.GetProperty<nsISupports>("characteristic");
            }
        }
        
        public nsAString Uuid
        {
            get
            {
                return this.GetProperty<nsAString>("uuid");
            }
        }
        
        public IntPtr Value
        {
            get
            {
                return this.GetProperty<IntPtr>("value");
            }
        }
        
        public object Permissions
        {
            get
            {
                return this.GetProperty<object>("permissions");
            }
        }
        
        public Promise < IntPtr > ReadValue()
        {
            return this.CallMethod<Promise < IntPtr >>("readValue");
        }
        
        public Promise WriteValue(IntPtr value)
        {
            return this.CallMethod<Promise>("writeValue", value);
        }
    }
}
