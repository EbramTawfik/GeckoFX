namespace Gecko.WebIDL
{
    using System;
    
    
    public class _Promise : WebIDLBase
    {
        
        public _Promise(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Then()
        {
            return this.CallMethod<object>("then");
        }
        
        public object Catch()
        {
            return this.CallMethod<object>("catch");
        }
    }
}
