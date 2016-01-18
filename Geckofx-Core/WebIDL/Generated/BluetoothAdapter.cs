namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothAdapter : WebIDLBase
    {
        
        public BluetoothAdapter(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public BluetoothAdapterState State
        {
            get
            {
                return this.GetProperty<BluetoothAdapterState>("state");
            }
        }
        
        public nsAString Address
        {
            get
            {
                return this.GetProperty<nsAString>("address");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public bool Discoverable
        {
            get
            {
                return this.GetProperty<bool>("discoverable");
            }
        }
        
        public bool Discovering
        {
            get
            {
                return this.GetProperty<bool>("discovering");
            }
        }
        
        public nsISupports GattServer
        {
            get
            {
                return this.GetProperty<nsISupports>("gattServer");
            }
        }
        
        public nsISupports PairingReqs
        {
            get
            {
                return this.GetProperty<nsISupports>("pairingReqs");
            }
        }
        
        public Promise Enable()
        {
            return this.CallMethod<Promise>("enable");
        }
        
        public Promise Disable()
        {
            return this.CallMethod<Promise>("disable");
        }
        
        public Promise SetName(nsAString name)
        {
            return this.CallMethod<Promise>("setName", name);
        }
        
        public Promise SetDiscoverable(bool discoverable)
        {
            return this.CallMethod<Promise>("setDiscoverable", discoverable);
        }
        
        public Promise < nsISupports > StartDiscovery()
        {
            return this.CallMethod<Promise < nsISupports >>("startDiscovery");
        }
        
        public Promise StopDiscovery()
        {
            return this.CallMethod<Promise>("stopDiscovery");
        }
        
        public Promise Pair(nsAString deviceAddress)
        {
            return this.CallMethod<Promise>("pair", deviceAddress);
        }
        
        public Promise Unpair(nsAString deviceAddress)
        {
            return this.CallMethod<Promise>("unpair", deviceAddress);
        }
        
        public nsISupports[] GetPairedDevices()
        {
            return this.CallMethod<nsISupports[]>("getPairedDevices");
        }
        
        public Promise < nsISupports > StartLeScan(nsAString[] serviceUuids)
        {
            return this.CallMethod<Promise < nsISupports >>("startLeScan", serviceUuids);
        }
        
        public Promise StopLeScan(nsISupports discoveryHandle)
        {
            return this.CallMethod<Promise>("stopLeScan", discoveryHandle);
        }
        
        public nsISupports GetConnectedDevices(ushort serviceUuid)
        {
            return this.CallMethod<nsISupports>("getConnectedDevices", serviceUuid);
        }
        
        public nsISupports Connect(nsISupports device)
        {
            return this.CallMethod<nsISupports>("connect", device);
        }
        
        public nsISupports Connect(nsISupports device, ushort serviceUuid)
        {
            return this.CallMethod<nsISupports>("connect", device, serviceUuid);
        }
        
        public nsISupports Disconnect(nsISupports device)
        {
            return this.CallMethod<nsISupports>("disconnect", device);
        }
        
        public nsISupports Disconnect(nsISupports device, ushort serviceUuid)
        {
            return this.CallMethod<nsISupports>("disconnect", device, serviceUuid);
        }
        
        public nsISupports SendFile(nsAString deviceAddress, nsIDOMBlob blob)
        {
            return this.CallMethod<nsISupports>("sendFile", deviceAddress, blob);
        }
        
        public nsISupports StopSendingFile(nsAString deviceAddress)
        {
            return this.CallMethod<nsISupports>("stopSendingFile", deviceAddress);
        }
        
        public nsISupports ConfirmReceivingFile(nsAString deviceAddress, bool confirmation)
        {
            return this.CallMethod<nsISupports>("confirmReceivingFile", deviceAddress, confirmation);
        }
        
        public nsISupports ConnectSco()
        {
            return this.CallMethod<nsISupports>("connectSco");
        }
        
        public nsISupports DisconnectSco()
        {
            return this.CallMethod<nsISupports>("disconnectSco");
        }
        
        public nsISupports IsScoConnected()
        {
            return this.CallMethod<nsISupports>("isScoConnected");
        }
        
        public nsISupports AnswerWaitingCall()
        {
            return this.CallMethod<nsISupports>("answerWaitingCall");
        }
        
        public nsISupports IgnoreWaitingCall()
        {
            return this.CallMethod<nsISupports>("ignoreWaitingCall");
        }
        
        public nsISupports ToggleCalls()
        {
            return this.CallMethod<nsISupports>("toggleCalls");
        }
        
        public nsISupports SendMediaMetaData()
        {
            return this.CallMethod<nsISupports>("sendMediaMetaData");
        }
        
        public nsISupports SendMediaMetaData(object mediaMetaData)
        {
            return this.CallMethod<nsISupports>("sendMediaMetaData", mediaMetaData);
        }
        
        public nsISupports SendMediaPlayStatus()
        {
            return this.CallMethod<nsISupports>("sendMediaPlayStatus");
        }
        
        public nsISupports SendMediaPlayStatus(object mediaPlayStatus)
        {
            return this.CallMethod<nsISupports>("sendMediaPlayStatus", mediaPlayStatus);
        }
    }
}
