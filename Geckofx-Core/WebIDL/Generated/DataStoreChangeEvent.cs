namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStoreChangeEvent : WebIDLBase
    {
        
        public DataStoreChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string RevisionId
        {
            get
            {
                return this.GetProperty<string>("revisionId");
            }
        }
        
        public WebIDLUnion<String,UInt32> Id
        {
            get
            {
                return this.GetProperty<WebIDLUnion<String,UInt32>>("id");
            }
        }
        
        public string Operation
        {
            get
            {
                return this.GetProperty<string>("operation");
            }
        }
        
        public string Owner
        {
            get
            {
                return this.GetProperty<string>("owner");
            }
        }
    }
}
