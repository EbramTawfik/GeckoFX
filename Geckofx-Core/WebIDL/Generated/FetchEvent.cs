namespace Gecko.WebIDL
{
    using System;
    
    
    public class FetchEvent : WebIDLBase
    {
        
        public FetchEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Request
        {
            get
            {
                return this.GetProperty<nsISupports>("request");
            }
        }
        
        public nsAString ClientId
        {
            get
            {
                return this.GetProperty<nsAString>("clientId");
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
