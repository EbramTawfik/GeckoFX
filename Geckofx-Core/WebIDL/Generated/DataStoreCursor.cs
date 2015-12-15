namespace Gecko.WebIDL
{
    using System;
    
    
    public class DataStoreCursor : WebIDLBase
    {
        
        public DataStoreCursor(nsISupports thisObject) : 
                base(thisObject)
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
        
        public void SetDataStoreCursorImpl(nsISupports cursor)
        {
            this.CallVoidMethod("setDataStoreCursorImpl", cursor);
        }
    }
}
