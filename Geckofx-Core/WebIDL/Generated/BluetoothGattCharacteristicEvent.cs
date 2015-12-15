namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattCharacteristicEvent : WebIDLBase
    {
        
        public BluetoothGattCharacteristicEvent(nsISupports thisObject) : 
                base(thisObject)
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
