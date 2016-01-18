namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothStatusChangedEvent : WebIDLBase
    {
        
        public BluetoothStatusChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool Status
        {
            get
            {
                return this.GetProperty<bool>("status");
            }
        }
    }
}
