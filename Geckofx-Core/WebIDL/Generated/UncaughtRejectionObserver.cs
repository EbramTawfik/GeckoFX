namespace Gecko.WebIDL
{
    using System;
    
    
    public class UncaughtRejectionObserver : WebIDLBase
    {
        
        public UncaughtRejectionObserver(nsISupports thisObject) : 
                base(thisObject)
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
