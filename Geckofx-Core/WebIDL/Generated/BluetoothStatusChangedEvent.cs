namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothStatusChangedEvent : WebIDLBase
    {
        
        public BluetoothStatusChangedEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Address
        {
            get
            {
                return this.GetProperty<nsAString>("address");
            }
        }
        
        public bool Status
        {
            get
            {
                return this.GetProperty<bool>("status");
            }
        }
    }
}
