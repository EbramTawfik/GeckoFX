namespace Gecko.WebIDL
{
    using System;
    
    
    public class RequestSyncApp : WebIDLBase
    {
        
        public RequestSyncApp(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public USVString Origin
        {
            get
            {
                return this.GetProperty<USVString>("origin");
            }
        }
        
        public USVString ManifestURL
        {
            get
            {
                return this.GetProperty<USVString>("manifestURL");
            }
        }
        
        public bool IsInBrowserElement
        {
            get
            {
                return this.GetProperty<bool>("isInBrowserElement");
            }
        }
    }
}
