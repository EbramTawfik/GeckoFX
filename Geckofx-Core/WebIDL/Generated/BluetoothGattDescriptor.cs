namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattDescriptor : WebIDLBase
    {
        
        public BluetoothGattDescriptor(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Characteristic
        {
            get
            {
                return this.GetProperty<nsISupports>("characteristic");
            }
        }
        
        public string Uuid
        {
            get
            {
                return this.GetProperty<string>("uuid");
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
