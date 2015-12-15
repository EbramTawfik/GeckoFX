namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorageAreaChangedEvent : WebIDLBase
    {
        
        public DeviceStorageAreaChangedEvent(nsISupports thisObject) : 
                base(thisObject)
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
