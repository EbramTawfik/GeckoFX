namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothPairingEvent : WebIDLBase
    {
        
        public BluetoothPairingEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString DeviceName
        {
            get
            {
                return this.GetProperty<nsAString>("deviceName");
            }
        }
        
        public nsISupports Handle
        {
            get
            {
                return this.GetProperty<nsISupports>("handle");
            }
        }
    }
}
