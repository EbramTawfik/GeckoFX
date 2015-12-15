namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWakeLock : WebIDLBase
    {
        
        public MozWakeLock(nsISupports thisObject) : 
                base(thisObject)
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
