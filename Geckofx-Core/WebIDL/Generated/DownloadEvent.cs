namespace Gecko.WebIDL
{
    using System;
    
    
    public class DownloadEvent : WebIDLBase
    {
        
        public DownloadEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Download
        {
            get
            {
                return this.GetProperty<nsISupports>("download");
            }
        }
    }
}
