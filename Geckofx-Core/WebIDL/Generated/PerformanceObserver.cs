namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceObserver : WebIDLBase
    {
        
        public PerformanceObserver(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Observe(object options)
        {
            this.CallVoidMethod("observe", options);
        }
        
        public void Disconnect()
        {
            this.CallVoidMethod("disconnect");
        }
    }
}
