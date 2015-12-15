namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBCursorWithValue : WebIDLBase
    {
        
        public IDBCursorWithValue(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public object Value
        {
            get
            {
                return this.GetProperty<object>("value");
            }
        }
    }
}
