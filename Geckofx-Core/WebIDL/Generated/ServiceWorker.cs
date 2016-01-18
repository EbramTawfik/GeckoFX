namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorker : WebIDLBase
    {
        
        public ServiceWorker(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString ScriptURL
        {
            get
            {
                return this.GetProperty<USVString>("scriptURL");
            }
        }
        
        public ServiceWorkerState State
        {
            get
            {
                return this.GetProperty<ServiceWorkerState>("state");
            }
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void PostMessage(object message, Object[] transferable)
        {
            this.CallVoidMethod("postMessage", message, transferable);
        }
    }
}
