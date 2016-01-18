namespace Gecko.WebIDL
{
    using System;
    
    
    public class DedicatedWorkerGlobalScope : WebIDLBase
    {
        
        public DedicatedWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void PostMessage(object message, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
    }
}
