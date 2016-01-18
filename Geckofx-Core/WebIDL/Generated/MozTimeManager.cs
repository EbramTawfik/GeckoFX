namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozTimeManager : WebIDLBase
    {
        
        public MozTimeManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Set(IntPtr time)
        {
            this.CallVoidMethod("set", time);
        }
        
        public void Set(double time)
        {
            this.CallVoidMethod("set", time);
        }
    }
}
