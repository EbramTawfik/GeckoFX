namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothObexAuthEvent : WebIDLBase
    {
        
        public BluetoothObexAuthEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string UserId
        {
            get
            {
                return this.GetProperty<string>("userId");
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
