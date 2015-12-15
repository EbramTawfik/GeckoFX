namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorageChangeEvent : WebIDLBase
    {
        
        public DeviceStorageChangeEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Path
        {
            get
            {
                return this.GetProperty<nsAString>("path");
            }
        }
        
        public nsAString Reason
        {
            get
            {
                return this.GetProperty<nsAString>("reason");
            }
        }
    }
}
