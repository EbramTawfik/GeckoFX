namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothAttributeEvent : WebIDLBase
    {
        
        public BluetoothAttributeEvent(nsISupports thisObject) : 
                base(thisObject)
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
