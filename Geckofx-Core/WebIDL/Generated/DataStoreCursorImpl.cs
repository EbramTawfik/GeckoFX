namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStoreCursorImpl : WebIDLBase
    {
        
        public DataStoreCursorImpl(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Store
        {
            get
            {
                return this.GetProperty<nsISupports>("store");
            }
        }
        
        public Promise <object> Next()
        {
            return this.CallMethod<Promise <object>>("next");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
