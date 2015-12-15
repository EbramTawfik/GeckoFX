namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBDatabase : WebIDLBase
    {
        
        public IDBDatabase(nsISupports thisObject) : 
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
        
        public nsISupports CreateObjectStore(nsAString name, object optionalParameters)
        {
            return this.CallMethod<nsISupports>("createObjectStore", name, optionalParameters);
        }
        
        public void DeleteObjectStore(nsAString name)
        {
            this.CallVoidMethod("deleteObjectStore", name);
        }
        
        public nsISupports Transaction(WebIDLUnion<nsAString,nsAString[]> storeNames, IDBTransactionMode mode)
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
        
        public nsISupports CreateMutableFile(nsAString name, nsAString type)
        {
            return this.CallMethod<nsISupports>("createMutableFile", name, type);
        }
        
        public nsISupports MozCreateFileHandle(nsAString name, nsAString type)
        {
            return this.CallMethod<nsISupports>("mozCreateFileHandle", name, type);
        }
    }
}
