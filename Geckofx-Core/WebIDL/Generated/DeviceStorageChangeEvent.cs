namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorageChangeEvent : WebIDLBase
    {
        
        public DeviceStorageChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Path
        {
            get
            {
                return this.GetProperty<string>("path");
            }
        }
        
        public string Reason
        {
            get
            {
                return this.GetProperty<string>("reason");
            }
        }
    }
}
