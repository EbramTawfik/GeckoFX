namespace Gecko.WebIDL
{
    using System;
    
    
    public class Worker : WebIDLBase
    {
        
        public Worker(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Terminate()
        {
            this.CallVoidMethod("terminate");
        }
        
        public void PostMessage(object message, object[] transfer)
        {
            this.CallVoidMethod("postMessage", message, transfer);
        }
    }
}
