namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWakeLock : WebIDLBase
    {
        
        public MozWakeLock(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Topic
        {
            get
            {
                return this.GetProperty<string>("topic");
            }
        }
        
        public void Unlock()
        {
            this.CallVoidMethod("unlock");
        }
    }
}
