namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothPairingHandle : WebIDLBase
    {
        
        public BluetoothPairingHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Passkey
        {
            get
            {
                return this.GetProperty<string>("passkey");
            }
        }
        
        public Promise SetPinCode(string aPinCode)
        {
            return this.CallMethod<Promise>("setPinCode", aPinCode);
        }
        
        public Promise Accept()
        {
            return this.CallMethod<Promise>("accept");
        }
        
        public Promise Reject()
        {
            return this.CallMethod<Promise>("reject");
        }
    }
}
