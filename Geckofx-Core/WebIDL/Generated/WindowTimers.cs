namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowTimers : WebIDLBase
    {
        
        public WindowTimers(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int SetTimeout(nsAString handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setTimeout", handler, timeout, unused);
        }
        
        public void ClearTimeout(int handle)
        {
            this.CallVoidMethod("clearTimeout", handle);
        }
        
        public int SetInterval(nsAString handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setInterval", handler, timeout, unused);
        }
        
        public void ClearInterval(int handle)
        {
            this.CallVoidMethod("clearInterval", handle);
        }
    }
}
