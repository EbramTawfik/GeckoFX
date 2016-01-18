namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothStatusChangedEvent : WebIDLBase
    {
        
        public BluetoothStatusChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
