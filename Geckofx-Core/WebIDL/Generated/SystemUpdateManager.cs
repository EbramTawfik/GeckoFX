namespace Gecko.WebIDL
{
    using System;
    
    
    public class SystemUpdateManager : WebIDLBase
    {
        
        public SystemUpdateManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < System.Object[] > GetProviders()
        {
            return this.CallMethod<Promise < System.Object[] >>("getProviders");
        }
        
        public Promise < nsISupports > SetActiveProvider(nsAString uuid)
        {
            return this.CallMethod<Promise < nsISupports >>("setActiveProvider", uuid);
        }
        
        public Promise < nsISupports > GetActiveProvider()
        {
            return this.CallMethod<Promise < nsISupports >>("getActiveProvider");
        }
    }
}
