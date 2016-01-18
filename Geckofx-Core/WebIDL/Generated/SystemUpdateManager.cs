namespace Gecko.WebIDL
{
    using System;
    
    
    public class SystemUpdateManager : WebIDLBase
    {
        
        public SystemUpdateManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < System.Object[] > GetProviders()
        {
            return this.CallMethod<Promise < System.Object[] >>("getProviders");
        }
        
        public Promise < nsISupports > SetActiveProvider(string uuid)
        {
            return this.CallMethod<Promise < nsISupports >>("setActiveProvider", uuid);
        }
        
        public Promise < nsISupports > GetActiveProvider()
        {
            return this.CallMethod<Promise < nsISupports >>("getActiveProvider");
        }
    }
}
