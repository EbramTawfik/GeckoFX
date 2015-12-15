namespace Gecko.WebIDL
{
    using System;
    
    
    public class DedicatedWorkerGlobalScope : WebIDLBase
    {
        
        public DedicatedWorkerGlobalScope(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void PostMessage(object message, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
    }
}
