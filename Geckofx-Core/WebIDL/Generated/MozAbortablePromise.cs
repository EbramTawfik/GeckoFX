namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozAbortablePromise : WebIDLBase
    {
        
        public MozAbortablePromise(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
