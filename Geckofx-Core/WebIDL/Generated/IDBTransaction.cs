namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBTransaction : WebIDLBase
    {
        
        public IDBTransaction(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public IDBTransactionMode Mode
        {
            get
            {
                return this.GetProperty<IDBTransactionMode>("mode");
            }
        }
        
        public nsISupports Db
        {
            get
            {
                return this.GetProperty<nsISupports>("db");
            }
        }
        
        public nsISupports Error
        {
            get
            {
                return this.GetProperty<nsISupports>("error");
            }
        }
        
        public nsISupports ObjectStore(nsAString name)
        {
            return this.CallMethod<nsISupports>("objectStore", name);
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
        
        public nsISupports ObjectStoreNames
        {
            get
            {
                return this.GetProperty<nsISupports>("objectStoreNames");
            }
        }
    }
}
