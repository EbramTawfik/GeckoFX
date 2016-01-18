namespace Gecko.WebIDL
{
    using System;
    
    
    public class ExtendableEvent : WebIDLBase
    {
        
        public ExtendableEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void WaitUntil(Promise <object> p)
        {
            this.CallVoidMethod("waitUntil", p);
        }
    }
}
