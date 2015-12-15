namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStore : WebIDLBase
    {
        
        public DataStore(nsISupports thisObject) : 
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
        
        public nsAString Owner
        {
            get
            {
                return this.GetProperty<nsAString>("owner");
            }
        }
        
        public bool ReadOnly
        {
            get
            {
                return this.GetProperty<bool>("readOnly");
            }
        }
        
        public nsAString RevisionId
        {
            get
            {
                return this.GetProperty<nsAString>("revisionId");
            }
        }
        
        public Promise <object> Get(WebIDLUnion<nsAString,UInt32> id)
        {
            return this.CallMethod<Promise <object>>("get", id);
        }
        
        public Promise Put(object obj, WebIDLUnion<nsAString,UInt32> id, nsAString revisionId)
        {
            return this.CallMethod<Promise>("put", obj, id, revisionId);
        }
        
        public Promise < WebIDLUnion<nsAString,UInt32>> Add(object obj, WebIDLUnion<nsAString,UInt32> id, nsAString revisionId)
        {
            return this.CallMethod<Promise < WebIDLUnion<nsAString,UInt32>>>("add", obj, id, revisionId);
        }
        
        public Promise <bool> Remove(WebIDLUnion<nsAString,UInt32> id, nsAString revisionId)
        {
            return this.CallMethod<Promise <bool>>("remove", id, revisionId);
        }
        
        public Promise Clear(nsAString revisionId)
        {
            return this.CallMethod<Promise>("clear", revisionId);
        }
        
        public Promise <uint> GetLength()
        {
            return this.CallMethod<Promise <uint>>("getLength");
        }
        
        public nsISupports Sync(nsAString revisionId)
        {
            return this.CallMethod<nsISupports>("sync", revisionId);
        }
        
        public void SetDataStoreImpl(nsISupports store)
        {
            this.CallVoidMethod("setDataStoreImpl", store);
        }
    }
}
