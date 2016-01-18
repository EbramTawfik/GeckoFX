namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorageAreaChangedEvent : WebIDLBase
    {
        
        public DeviceStorageAreaChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public DeviceStorageAreaChangedEventOperation Operation
        {
            get
            {
                return this.GetProperty<DeviceStorageAreaChangedEventOperation>("operation");
            }
        }
        
        public nsAString StorageName
        {
            get
            {
                return this.GetProperty<nsAString>("storageName");
            }
        }
    }
}
