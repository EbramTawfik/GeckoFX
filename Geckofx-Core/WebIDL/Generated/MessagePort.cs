namespace Gecko.WebIDL
{
    using System;
    
    
    public class MessagePort : WebIDLBase
    {
        
        public MessagePort(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void PostMessage(object message, Object[] transferable)
        {
            this.CallVoidMethod("postMessage", message, transferable);
        }
        
        public void Start()
        {
            this.CallVoidMethod("start");
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
