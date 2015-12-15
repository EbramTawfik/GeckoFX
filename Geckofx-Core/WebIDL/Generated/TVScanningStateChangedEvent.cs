namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVScanningStateChangedEvent : WebIDLBase
    {
        
        public TVScanningStateChangedEvent(nsISupports thisObject) : 
                base(thisObject)
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
