namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBObjectStore : WebIDLBase
    {
        
        public IDBObjectStore(nsISupports thisObject) : 
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
        
        public object KeyPath
        {
            get
            {
                return this.GetProperty<object>("keyPath");
            }
        }
        
        public nsISupports IndexNames
        {
            get
            {
                return this.GetProperty<nsISupports>("indexNames");
            }
        }
        
        public nsISupports Transaction
        {
            get
            {
                return this.GetProperty<nsISupports>("transaction");
            }
        }
        
        public bool AutoIncrement
        {
            get
            {
                return this.GetProperty<bool>("autoIncrement");
            }
        }
        
        public nsISupports Put(object value, object key)
        {
            return this.CallMethod<nsISupports>("put", value, key);
        }
        
        public nsISupports Add(object value, object key)
        {
            return this.CallMethod<nsISupports>("add", value, key);
        }
        
        public nsISupports Delete(object key)
        {
            return this.CallMethod<nsISupports>("delete", key);
        }
        
        public nsISupports Get(object key)
        {
            return this.CallMethod<nsISupports>("get", key);
        }
        
        public nsISupports Clear()
        {
            return this.CallMethod<nsISupports>("clear");
        }
        
        public nsISupports OpenCursor(object range, IDBCursorDirection direction)
        {
            return this.CallMethod<nsISupports>("openCursor", range, direction);
        }
        
        public nsISupports CreateIndex(nsAString name, nsAString keyPath, object optionalParameters)
        {
            return this.CallMethod<nsISupports>("createIndex", name, keyPath, optionalParameters);
        }
        
        public nsISupports CreateIndex(nsAString name, nsAString[] keyPath, object optionalParameters)
        {
            return this.CallMethod<nsISupports>("createIndex", name, keyPath, optionalParameters);
        }
        
        public nsISupports Index(nsAString name)
        {
            return this.CallMethod<nsISupports>("index", name);
        }
        
        public void DeleteIndex(nsAString indexName)
        {
            this.CallVoidMethod("deleteIndex", indexName);
        }
        
        public nsISupports Count(object key)
        {
            return this.CallMethod<nsISupports>("count", key);
        }
        
        public nsISupports MozGetAll(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("mozGetAll", key, limit);
        }
        
        public nsISupports GetAll(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("getAll", key, limit);
        }
        
        public nsISupports GetAllKeys(object key, uint limit)
        {
            return this.CallMethod<nsISupports>("getAllKeys", key, limit);
        }
        
        public nsISupports OpenKeyCursor(object range, IDBCursorDirection direction)
        {
            return this.CallMethod<nsISupports>("openKeyCursor", range, direction);
        }
    }
}
