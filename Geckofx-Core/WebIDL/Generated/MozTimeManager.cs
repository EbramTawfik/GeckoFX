namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozTimeManager : WebIDLBase
    {
        
        public MozTimeManager(nsISupports thisObject) : 
                base(thisObject)
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
