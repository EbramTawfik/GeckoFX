namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattService : WebIDLBase
    {
        
        public BluetoothGattService(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] Characteristics
        {
            get
            {
                return this.GetProperty<nsISupports[]>("characteristics");
            }
        }
        
        public nsISupports[] IncludedServices
        {
            get
            {
                return this.GetProperty<nsISupports[]>("includedServices");
            }
        }
        
        public bool IsPrimary
        {
            get
            {
                return this.GetProperty<bool>("isPrimary");
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
        
        public Promise < nsISupports > AddCharacteristic(string uuid, object permissions, object properties, IntPtr value)
        {
            return this.CallMethod<Promise < nsISupports >>("addCharacteristic", uuid, permissions, properties, value);
        }
        
        public Promise AddIncludedService(nsISupports service)
        {
            return this.CallMethod<Promise>("addIncludedService", service);
        }
    }
}
