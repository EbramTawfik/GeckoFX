namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorage : WebIDLBase
    {
        
        public DeviceStorage(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString StorageName
        {
            get
            {
                return this.GetProperty<nsAString>("storageName");
            }
        }
        
        public bool CanBeMounted
        {
            get
            {
                return this.GetProperty<bool>("canBeMounted");
            }
        }
        
        public bool CanBeShared
        {
            get
            {
                return this.GetProperty<bool>("canBeShared");
            }
        }
        
        public bool CanBeFormatted
        {
            get
            {
                return this.GetProperty<bool>("canBeFormatted");
            }
        }
        
        public bool Default
        {
            get
            {
                return this.GetProperty<bool>("default");
            }
        }
        
        public bool IsRemovable
        {
            get
            {
                return this.GetProperty<bool>("isRemovable");
            }
        }
        
        public bool LowDiskSpace
        {
            get
            {
                return this.GetProperty<bool>("lowDiskSpace");
            }
        }
        
        public nsISupports Add(nsIDOMBlob aBlob)
        {
            return this.CallMethod<nsISupports>("add", aBlob);
        }
        
        public nsISupports AddNamed(nsIDOMBlob aBlob, nsAString aName)
        {
            return this.CallMethod<nsISupports>("addNamed", aBlob, aName);
        }
        
        public nsISupports AppendNamed(nsIDOMBlob aBlob, nsAString aName)
        {
            return this.CallMethod<nsISupports>("appendNamed", aBlob, aName);
        }
        
        public nsISupports Get(nsAString aName)
        {
            return this.CallMethod<nsISupports>("get", aName);
        }
        
        public nsISupports GetEditable(nsAString aName)
        {
            return this.CallMethod<nsISupports>("getEditable", aName);
        }
        
        public nsISupports Delete(nsAString aName)
        {
            return this.CallMethod<nsISupports>("delete", aName);
        }
        
        public nsISupports Enumerate(object options)
        {
            return this.CallMethod<nsISupports>("enumerate", options);
        }
        
        public nsISupports Enumerate(nsAString path, object options)
        {
            return this.CallMethod<nsISupports>("enumerate", path, options);
        }
        
        public nsISupports EnumerateEditable(object options)
        {
            return this.CallMethod<nsISupports>("enumerateEditable", options);
        }
        
        public nsISupports EnumerateEditable(nsAString path, object options)
        {
            return this.CallMethod<nsISupports>("enumerateEditable", path, options);
        }
        
        public nsISupports FreeSpace()
        {
            return this.CallMethod<nsISupports>("freeSpace");
        }
        
        public nsISupports UsedSpace()
        {
            return this.CallMethod<nsISupports>("usedSpace");
        }
        
        public nsISupports Available()
        {
            return this.CallMethod<nsISupports>("available");
        }
        
        public nsISupports StorageStatus()
        {
            return this.CallMethod<nsISupports>("storageStatus");
        }
        
        public nsISupports Format()
        {
            return this.CallMethod<nsISupports>("format");
        }
        
        public nsISupports Mount()
        {
            return this.CallMethod<nsISupports>("mount");
        }
        
        public nsISupports Unmount()
        {
            return this.CallMethod<nsISupports>("unmount");
        }
        
        public Promise <object> GetRoot()
        {
            return this.CallMethod<Promise <object>>("getRoot");
        }
    }
}
