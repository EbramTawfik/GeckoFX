namespace Gecko.WebIDL
{
    using System;
    
    
    public class StorageEvent : WebIDLBase
    {
        
        public StorageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Key
        {
            get
            {
                return this.GetProperty<string>("key");
            }
        }
        
        public string OldValue
        {
            get
            {
                return this.GetProperty<string>("oldValue");
            }
        }
        
        public string NewValue
        {
            get
            {
                return this.GetProperty<string>("newValue");
            }
        }
        
        public string Url
        {
            get
            {
                return this.GetProperty<string>("url");
            }
        }
        
        public nsISupports StorageArea
        {
            get
            {
                return this.GetProperty<nsISupports>("storageArea");
            }
        }
        
        public void InitStorageEvent(string type, bool canBubble, bool cancelable, string key, string oldValue, string newValue, string url, nsISupports storageArea)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue, url, storageArea);
        }
    }
}
