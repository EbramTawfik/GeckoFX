namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothDevice : WebIDLBase
    {
        
        public BluetoothDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Address
        {
            get
            {
                return this.GetProperty<nsAString>("address");
            }
        }
        
        public nsISupports Cod
        {
            get
            {
                return this.GetProperty<nsISupports>("cod");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public bool Paired
        {
            get
            {
                return this.GetProperty<bool>("paired");
            }
        }
        
        public BluetoothDeviceType Type
        {
            get
            {
                return this.GetProperty<BluetoothDeviceType>("type");
            }
        }
        
        public nsISupports Gatt
        {
            get
            {
                return this.GetProperty<nsISupports>("gatt");
            }
        }
        
        public nsAString[] Uuids
        {
            get
            {
                return this.GetProperty<nsAString[]>("uuids");
            }
        }
        
        public Promise < nsAString[] > FetchUuids()
        {
            return this.CallMethod<Promise < nsAString[] >>("fetchUuids");
        }
    }
}
