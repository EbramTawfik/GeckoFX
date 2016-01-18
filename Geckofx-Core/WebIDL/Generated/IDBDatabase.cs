namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBDatabase : WebIDLBase
    {
        
        public IDBDatabase(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public ulong Version
        {
            get
            {
                return this.GetProperty<ulong>("version");
            }
        }
        
        public nsISupports ObjectStoreNames
        {
            get
            {
                return this.GetProperty<nsISupports>("objectStoreNames");
            }
        }
        
        public nsISupports CreateObjectStore(string name)
        {
            return this.CallMethod<nsISupports>("createObjectStore", name);
        }
        
        public nsISupports CreateObjectStore(string name, object optionalParameters)
        {
            return this.CallMethod<nsISupports>("createObjectStore", name, optionalParameters);
        }
        
        public void DeleteObjectStore(string name)
        {
            this.CallVoidMethod("deleteObjectStore", name);
        }
        
        public nsISupports Transaction(WebIDLUnion<System.String,System.String[]> storeNames)
        {
            return this.CallMethod<nsISupports>("transaction", storeNames);
        }
        
        public nsISupports Transaction(WebIDLUnion<System.String,System.String[]> storeNames, IDBTransactionMode mode)
        {
            return this.CallMethod<nsISupports>("transaction", storeNames, mode);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public StorageType Storage
        {
            get
            {
                return this.GetProperty<StorageType>("storage");
            }
        }
        
        public nsISupports CreateMutableFile(string name)
        {
            return this.CallMethod<nsISupports>("createMutableFile", name);
        }
        
        public nsISupports CreateMutableFile(string name, string type)
        {
            return this.CallMethod<nsISupports>("createMutableFile", name, type);
        }
        
        public nsISupports MozCreateFileHandle(string name)
        {
            return this.CallMethod<nsISupports>("mozCreateFileHandle", name);
        }
        
        public nsISupports MozCreateFileHandle(string name, string type)
        {
            return this.CallMethod<nsISupports>("mozCreateFileHandle", name, type);
        }
    }
}
