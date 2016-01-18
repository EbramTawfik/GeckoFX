namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothDevice : WebIDLBase
    {
        
        public BluetoothDevice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Address
        {
            get
            {
                return this.GetProperty<string>("address");
            }
        }
        
        public nsISupports Cod
        {
            get
            {
                return this.GetProperty<nsISupports>("cod");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
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
        
        public string[] Uuids
        {
            get
            {
                return this.GetProperty<string[]>("uuids");
            }
        }
        
        public Promise < System.String[] > FetchUuids()
        {
            return this.CallMethod<Promise < System.String[] >>("fetchUuids");
        }
    }
}
