namespace Gecko.WebIDL
{
    using System;
    
    
    public class WindowTimers : WebIDLBase
    {
        
        public WindowTimers(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int SetTimeout(string handler)
        {
            return this.CallMethod<int>("setTimeout", handler);
        }
        
        public int SetTimeout(string handler, int timeout)
        {
            return this.CallMethod<int>("setTimeout", handler, timeout);
        }
        
        public int SetTimeout(string handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setTimeout", handler, timeout, unused);
        }
        
        public void ClearTimeout()
        {
            this.CallVoidMethod("clearTimeout");
        }
        
        public void ClearTimeout(int handle)
        {
            this.CallVoidMethod("clearTimeout", handle);
        }
        
        public int SetInterval(string handler)
        {
            return this.CallMethod<int>("setInterval", handler);
        }
        
        public int SetInterval(string handler, int timeout)
        {
            return this.CallMethod<int>("setInterval", handler, timeout);
        }
        
        public int SetInterval(string handler, int timeout, object unused)
        {
            return this.CallMethod<int>("setInterval", handler, timeout, unused);
        }
        
        public void ClearInterval()
        {
            this.CallVoidMethod("clearInterval");
        }
        
        public void ClearInterval(int handle)
        {
            this.CallVoidMethod("clearInterval", handle);
        }
    }
}
