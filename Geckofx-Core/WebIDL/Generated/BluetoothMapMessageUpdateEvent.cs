namespace Gecko.WebIDL
{
    using System;
    
    
    public class BluetoothMapMessageUpdateEvent : WebIDLBase
    {
        
        public BluetoothMapMessageUpdateEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint InstanceId
        {
            get
            {
                return this.GetProperty<uint>("instanceId");
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
