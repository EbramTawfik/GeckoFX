namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerGlobalScope : WebIDLBase
    {
        
        public ServiceWorkerGlobalScope(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Clients
        {
            get
            {
                return this.GetProperty<nsISupports>("clients");
            }
        }
        
        public nsISupports Registration
        {
            get
            {
                return this.GetProperty<nsISupports>("registration");
            }
        }
        
        public Promise <bool> SkipWaiting()
        {
            return this.CallMethod<Promise <bool>>("skipWaiting");
        }
    }
}
