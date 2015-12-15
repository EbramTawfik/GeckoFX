namespace Gecko.WebIDL
{
    using System;
    
    
    public class ExtendableEvent : WebIDLBase
    {
        
        public ExtendableEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void WaitUntil(Promise <object> p)
        {
            this.CallVoidMethod("waitUntil", p);
        }
    }
}
