namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBIndex : WebIDLBase
    {
        
        public IDBIndex(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsISupports ObjectStore
        {
            get
            {
                return this.GetProperty<nsISupports>("objectStore");
            }
        }
        
        public object KeyPath
        {
            get
            {
                return this.GetProperty<object>("keyPath");
            }
        }
        
        public bool MultiEntry
        {
            get
            {
                return this.GetProperty<bool>("multiEntry");
            }
        }
        
        public bool Unique
        {
            get
            {
                return this.GetProperty<bool>("unique");
            }
        }
        
        public nsAString Locale
        {
            get
            {
                return this.GetProperty<nsAString>("locale");
            }
        }
        
        public bool IsAutoLocale
        {
            get
            {
                return this.GetProperty<bool>("isAutoLocale");
            }
        }
        
        public nsISupports OpenCursor(object range, IDBCursorDirection direction)
        {
            return this.CallMethod<nsISupports>("openCursor", range, direction);
        }
        
        public nsISupports OpenKeyCursor(object range, IDBCursorDirection direction)
        {
            return this.CallMethod<nsISupports>("openKeyCursor", range, direction);
        }
        
        public nsISupports Get(object key)
        {
            return this.CallMethod<nsISupports>("get", key);
        }
        
        public nsISupports GetKey(object key)
        {
            return this.CallMethod<nsISupports>("getKey", key);
        }
        
        public nsISupports Count(object key)
        {
            return this.CallMethod<nsISupports>("count", key);
        }
        
        public nsISupports MozGetAll(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("mozGetAll", key, limit);
        }
        
        public nsISupports MozGetAllKeys(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("mozGetAllKeys", key, limit);
        }
        
        public nsISupports GetAll(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("getAll", key, limit);
        }
        
        public nsISupports GetAllKeys(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("getAllKeys", key, limit);
        }
    }
}
