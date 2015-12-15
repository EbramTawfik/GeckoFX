namespace Gecko.WebIDL
{
    using System;
    
    
    public class StorageEvent : WebIDLBase
    {
        
        public StorageEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Key
        {
            get
            {
                return this.GetProperty<nsAString>("key");
            }
        }
        
        public nsAString OldValue
        {
            get
            {
                return this.GetProperty<nsAString>("oldValue");
            }
        }
        
        public nsAString NewValue
        {
            get
            {
                return this.GetProperty<nsAString>("newValue");
            }
        }
        
        public nsAString Url
        {
            get
            {
                return this.GetProperty<nsAString>("url");
            }
        }
        
        public nsISupports StorageArea
        {
            get
            {
                return this.GetProperty<nsISupports>("storageArea");
            }
        }
        
        public void InitStorageEvent(nsAString type, bool canBubble, bool cancelable, nsAString key, nsAString oldValue, nsAString newValue, nsAString url, nsISupports storageArea)
        {
            this.CallVoidMethod("initStorageEvent", type, canBubble, cancelable, key, oldValue, newValue, url, storageArea);
        }
    }
}
