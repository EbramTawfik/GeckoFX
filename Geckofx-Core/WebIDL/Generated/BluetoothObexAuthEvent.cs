namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothObexAuthEvent : WebIDLBase
    {
        
        public BluetoothObexAuthEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString UserId
        {
            get
            {
                return this.GetProperty<nsAString>("userId");
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
