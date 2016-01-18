namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceStorage : WebIDLBase
    {
        
        public DeviceStorage(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string StorageName
        {
            get
            {
                return this.GetProperty<string>("storageName");
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
        
        public nsISupports AddNamed(nsIDOMBlob aBlob, string aName)
        {
            return this.CallMethod<nsISupports>("addNamed", aBlob, aName);
        }
        
        public nsISupports AppendNamed(nsIDOMBlob aBlob, string aName)
        {
            return this.CallMethod<nsISupports>("appendNamed", aBlob, aName);
        }
        
        public nsISupports Get(string aName)
        {
            return this.CallMethod<nsISupports>("get", aName);
        }
        
        public nsISupports GetEditable(string aName)
        {
            return this.CallMethod<nsISupports>("getEditable", aName);
        }
        
        public nsISupports Delete(string aName)
        {
            return this.CallMethod<nsISupports>("delete", aName);
        }
        
        public nsISupports Enumerate()
        {
            return this.CallMethod<nsISupports>("enumerate");
        }
        
        public nsISupports Enumerate(object options)
        {
            return this.CallMethod<nsISupports>("enumerate", options);
        }
        
        public nsISupports Enumerate(string path)
        {
            return this.CallMethod<nsISupports>("enumerate", path);
        }
        
        public nsISupports Enumerate(string path, object options)
        {
            return this.CallMethod<nsISupports>("enumerate", path, options);
        }
        
        public nsISupports EnumerateEditable()
        {
            return this.CallMethod<nsISupports>("enumerateEditable");
        }
        
        public nsISupports EnumerateEditable(object options)
        {
            return this.CallMethod<nsISupports>("enumerateEditable", options);
        }
        
        public nsISupports EnumerateEditable(string path)
        {
            return this.CallMethod<nsISupports>("enumerateEditable", path);
        }
        
        public nsISupports EnumerateEditable(string path, object options)
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
