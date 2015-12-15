namespace Gecko.WebIDL
{
    using System;
    
    
    public class BroadcastChannel : WebIDLBase
    {
        
        public BroadcastChannel(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
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
