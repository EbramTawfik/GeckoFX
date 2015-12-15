namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataContainerEvent : WebIDLBase
    {
        
        public DataContainerEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports GetData(nsAString key)
        {
            return this.CallMethod<nsISupports>("getData", key);
        }
        
        public void SetData(nsAString key, object data)
        {
            this.CallVoidMethod("setData", key, data);
        }
    }
}
