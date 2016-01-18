namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothPairingHandle : WebIDLBase
    {
        
        public BluetoothPairingHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Passkey
        {
            get
            {
                return this.GetProperty<nsAString>("passkey");
            }
        }
        
        public Promise SetPinCode(nsAString aPinCode)
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
