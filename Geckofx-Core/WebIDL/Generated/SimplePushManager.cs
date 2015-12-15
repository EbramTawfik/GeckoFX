namespace Gecko.WebIDL
{
    using System;
    
    
    public class SimplePushManager : WebIDLBase
    {
        
        public SimplePushManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Register()
        {
            return this.CallMethod<nsISupports>("register");
        }
        
        public nsISupports Unregister(nsAString pushEndpoint)
        {
            return this.CallMethod<nsISupports>("unregister", pushEndpoint);
        }
        
        public nsISupports Registrations()
        {
            return this.CallMethod<nsISupports>("registrations");
        }
    }
}
