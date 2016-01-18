namespace Gecko.WebIDL
{
    using System;
    
    
    public class FetchEvent : WebIDLBase
    {
        
        public FetchEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Request
        {
            get
            {
                return this.GetProperty<nsISupports>("request");
            }
        }
        
        public string ClientId
        {
            get
            {
                return this.GetProperty<string>("clientId");
            }
        }
        
        public bool IsReload
        {
            get
            {
                return this.GetProperty<bool>("isReload");
            }
        }
        
        public void RespondWith(Promise < nsISupports > r)
        {
            this.CallVoidMethod("respondWith", r);
        }
    }
}
