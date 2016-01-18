namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVScanningStateChangedEvent : WebIDLBase
    {
        
        public TVScanningStateChangedEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public TVScanningState State
        {
            get
            {
                return this.GetProperty<TVScanningState>("state");
            }
        }
        
        public nsISupports Channel
        {
            get
            {
                return this.GetProperty<nsISupports>("channel");
            }
        }
    }
}
