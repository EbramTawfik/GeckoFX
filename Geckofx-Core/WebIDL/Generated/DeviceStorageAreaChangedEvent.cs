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
        
        public string StorageName
        {
            get
            {
                return this.GetProperty<string>("storageName");
            }
        }
    }
}
