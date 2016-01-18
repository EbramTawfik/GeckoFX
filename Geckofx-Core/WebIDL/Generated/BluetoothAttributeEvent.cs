namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothAttributeEvent : WebIDLBase
    {
        
        public BluetoothAttributeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString[] Attrs
        {
            get
            {
                return this.GetProperty<nsAString[]>("attrs");
            }
        }
    }
}
