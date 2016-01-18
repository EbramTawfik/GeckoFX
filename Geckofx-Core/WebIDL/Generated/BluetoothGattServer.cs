namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattServer : WebIDLBase
    {
        
        public BluetoothGattServer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] Services
        {
            get
            {
                return this.GetProperty<nsISupports[]>("services");
            }
        }
        
        public Promise Connect(string address)
        {
            return this.CallMethod<Promise>("connect", address);
        }
        
        public Promise Disconnect(string address)
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
        
        public Promise NotifyCharacteristicChanged(string address, nsISupports characteristic, bool confirm)
        {
            return this.CallMethod<Promise>("notifyCharacteristicChanged", address, characteristic, confirm);
        }
        
        public Promise SendResponse(string address, ushort status, int requestId)
        {
            return this.CallMethod<Promise>("sendResponse", address, status, requestId);
        }
    }
}
