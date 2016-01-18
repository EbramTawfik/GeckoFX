namespace Gecko.WebIDL
{
    using System;
    
    
    public class UncaughtRejectionObserver : WebIDLBase
    {
        
        public UncaughtRejectionObserver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void OnLeftUncaught(Promise <object> p)
        {
            this.CallVoidMethod("onLeftUncaught", p);
        }
        
        public void OnConsumed(Promise <object> p)
        {
            this.CallVoidMethod("onConsumed", p);
        }
    }
}
