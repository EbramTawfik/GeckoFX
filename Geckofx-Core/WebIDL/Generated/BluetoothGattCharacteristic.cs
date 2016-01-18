namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattCharacteristic : WebIDLBase
    {
        
        public BluetoothGattCharacteristic(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Service
        {
            get
            {
                return this.GetProperty<nsISupports>("service");
            }
        }
        
        public nsISupports[] Descriptors
        {
            get
            {
                return this.GetProperty<nsISupports[]>("descriptors");
            }
        }
        
        public string Uuid
        {
            get
            {
                return this.GetProperty<string>("uuid");
            }
        }
        
        public ushort InstanceId
        {
            get
            {
                return this.GetProperty<ushort>("instanceId");
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
        
        public object Properties
        {
            get
            {
                return this.GetProperty<object>("properties");
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
        
        public Promise StartNotifications()
        {
            return this.CallMethod<Promise>("startNotifications");
        }
        
        public Promise StopNotifications()
        {
            return this.CallMethod<Promise>("stopNotifications");
        }
        
        public Promise < nsISupports > AddDescriptor(string uuid, object permissions, IntPtr value)
        {
            return this.CallMethod<Promise < nsISupports >>("addDescriptor", uuid, permissions, value);
        }
    }
}
