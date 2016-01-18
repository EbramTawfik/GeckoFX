namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStoreImpl : WebIDLBase
    {
        
        public DataStoreImpl(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public string Owner
        {
            get
            {
                return this.GetProperty<string>("owner");
            }
        }
        
        public bool ReadOnly
        {
            get
            {
                return this.GetProperty<bool>("readOnly");
            }
        }
        
        public string RevisionId
        {
            get
            {
                return this.GetProperty<string>("revisionId");
            }
        }
        
        public void SetEventTarget(nsISupports eventTarget)
        {
            this.CallVoidMethod("setEventTarget", eventTarget);
        }
        
        public Promise <object> Get(WebIDLUnion<String,UInt32> id)
        {
            return this.CallMethod<Promise <object>>("get", id);
        }
        
        public Promise Put(object obj, WebIDLUnion<String,UInt32> id)
        {
            return this.CallMethod<Promise>("put", obj, id);
        }
        
        public Promise Put(object obj, WebIDLUnion<String,UInt32> id, string revisionId)
        {
            return this.CallMethod<Promise>("put", obj, id, revisionId);
        }
        
        public Promise < WebIDLUnion<String,UInt32>> Add(object obj)
        {
            return this.CallMethod<Promise < WebIDLUnion<String,UInt32>>>("add", obj);
        }
        
        public Promise < WebIDLUnion<String,UInt32>> Add(object obj, WebIDLUnion<String,UInt32> id)
        {
            return this.CallMethod<Promise < WebIDLUnion<String,UInt32>>>("add", obj, id);
        }
        
        public Promise < WebIDLUnion<String,UInt32>> Add(object obj, WebIDLUnion<String,UInt32> id, string revisionId)
        {
            return this.CallMethod<Promise < WebIDLUnion<String,UInt32>>>("add", obj, id, revisionId);
        }
        
        public Promise <bool> Remove(WebIDLUnion<String,UInt32> id)
        {
            return this.CallMethod<Promise <bool>>("remove", id);
        }
        
        public Promise <bool> Remove(WebIDLUnion<String,UInt32> id, string revisionId)
        {
            return this.CallMethod<Promise <bool>>("remove", id, revisionId);
        }
        
        public Promise Clear()
        {
            return this.CallMethod<Promise>("clear");
        }
        
        public Promise Clear(string revisionId)
        {
            return this.CallMethod<Promise>("clear", revisionId);
        }
        
        public Promise <uint> GetLength()
        {
            return this.CallMethod<Promise <uint>>("getLength");
        }
        
        public nsISupports Sync()
        {
            return this.CallMethod<nsISupports>("sync");
        }
        
        public nsISupports Sync(string revisionId)
        {
            return this.CallMethod<nsISupports>("sync", revisionId);
        }
    }
}
