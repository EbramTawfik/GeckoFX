namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattCharacteristicEvent : WebIDLBase
    {
        
        public BluetoothGattCharacteristicEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Characteristic
        {
            get
            {
                return this.GetProperty<nsISupports>("characteristic");
            }
        }
    }
}
