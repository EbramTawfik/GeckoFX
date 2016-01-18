namespace Gecko.WebIDL
{
    using System;
    
    
    public class MMICall : WebIDLBase
    {
        
        public MMICall(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
