namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStoreChangeEvent : WebIDLBase
    {
        
        public DataStoreChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString RevisionId
        {
            get
            {
                return this.GetProperty<nsAString>("revisionId");
            }
        }
        
        public WebIDLUnion<nsAString,UInt32> Id
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsAString,UInt32>>("id");
            }
        }
        
        public nsAString Operation
        {
            get
            {
                return this.GetProperty<nsAString>("operation");
            }
        }
        
        public nsAString Owner
        {
            get
            {
                return this.GetProperty<nsAString>("owner");
            }
        }
    }
}
