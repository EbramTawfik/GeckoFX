namespace Gecko.WebIDL
{
    using System;
    
    
    public class DownloadEvent : WebIDLBase
    {
        
        public DownloadEvent(nsISupports thisObject) : 
                base(thisObject)
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
