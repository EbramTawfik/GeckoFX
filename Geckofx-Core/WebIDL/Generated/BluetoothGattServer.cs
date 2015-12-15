namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattServer : WebIDLBase
    {
        
        public BluetoothGattServer(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] Services
        {
            get
            {
                return this.GetProperty<nsISupports[]>("services");
            }
        }
        
        public Promise Connect(nsAString address)
        {
            return this.CallMethod<Promise>("connect", address);
        }
        
        public Promise Disconnect(nsAString address)
        {
            return this.CallMethod<Promise>("disconnect", address);
        }
        
        public Promise AddService(nsISupports service)
        {
            return this.CallMethod<Promise>("addService", service);
        }
        
        public Promise RemoveService(nsISupports service)
        {
            return this.CallMethod<Promise>("removeService", service);
        }
        
        public Promise NotifyCharacteristicChanged(nsAString address, nsISupports characteristic, bool confirm)
        {
            return this.CallMethod<Promise>("notifyCharacteristicChanged", address, characteristic, confirm);
        }
        
        public Promise SendResponse(nsAString address, ushort status, int requestId)
        {
            return this.CallMethod<Promise>("sendResponse", address, status, requestId);
        }
    }
}
