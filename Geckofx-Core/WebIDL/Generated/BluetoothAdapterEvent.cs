namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothAdapterEvent : WebIDLBase
    {
        
        public BluetoothAdapterEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Adapter
        {
            get
            {
                return this.GetProperty<nsISupports>("adapter");
            }
        }
        
        public nsAString Address
        {
            get
            {
                return this.GetProperty<nsAString>("address");
            }
        }
    }
}
