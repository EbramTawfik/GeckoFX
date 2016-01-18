namespace Gecko.WebIDL
{
    using System;
    
    
    public class BroadcastChannel : WebIDLBase
    {
        
        public BroadcastChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
    }
}
