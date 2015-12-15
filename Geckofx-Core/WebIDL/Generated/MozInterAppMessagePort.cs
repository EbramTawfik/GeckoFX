namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInterAppMessagePort : WebIDLBase
    {
        
        public MozInterAppMessagePort(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void PostMessage(object message)
        {
            this.CallVoidMethod("postMessage", message);
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
