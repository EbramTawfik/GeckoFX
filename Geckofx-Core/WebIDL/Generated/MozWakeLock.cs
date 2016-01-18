namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWakeLock : WebIDLBase
    {
        
        public MozWakeLock(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Topic
        {
            get
            {
                return this.GetProperty<nsAString>("topic");
            }
        }
        
        public void Unlock()
        {
            this.CallVoidMethod("unlock");
        }
    }
}
