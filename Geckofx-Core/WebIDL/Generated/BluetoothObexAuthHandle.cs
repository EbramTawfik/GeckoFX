namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothObexAuthHandle : WebIDLBase
    {
        
        public BluetoothObexAuthHandle(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise SetPassword(nsAString aPassword)
        {
            return this.CallMethod<Promise>("setPassword", aPassword);
        }
        
        public Promise Reject()
        {
            return this.CallMethod<Promise>("reject");
        }
    }
}
