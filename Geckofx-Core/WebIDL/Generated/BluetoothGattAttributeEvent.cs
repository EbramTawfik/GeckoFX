namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothGattAttributeEvent : WebIDLBase
    {
        
        public BluetoothGattAttributeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Address
        {
            get
            {
                return this.GetProperty<string>("address");
            }
        }
        
        public int RequestId
        {
            get
            {
                return this.GetProperty<int>("requestId");
            }
        }
        
        public nsISupports Characteristic
        {
            get
            {
                return this.GetProperty<nsISupports>("characteristic");
            }
        }
        
        public nsISupports Descriptor
        {
            get
            {
                return this.GetProperty<nsISupports>("descriptor");
            }
        }
        
        public IntPtr Value
        {
            get
            {
                return this.GetProperty<IntPtr>("value");
            }
        }
        
        public bool NeedResponse
        {
            get
            {
                return this.GetProperty<bool>("needResponse");
            }
        }
    }
}
