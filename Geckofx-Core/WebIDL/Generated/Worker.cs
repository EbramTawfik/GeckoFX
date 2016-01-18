namespace Gecko.WebIDL
{
    using System;
    
    
    public class Worker : WebIDLBase
    {
        
        public Worker(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Terminate()
        {
            this.CallVoidMethod("terminate");
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
