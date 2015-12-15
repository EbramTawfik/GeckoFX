namespace Gecko.WebIDL
{
    using System;
    
    
    public class MMICall : WebIDLBase
    {
        
        public MMICall(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise <object> Result
        {
            get
            {
                return this.GetProperty<Promise <object>>("result");
            }
        }
    }
}
