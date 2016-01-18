namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationDeviceInfoManager : WebIDLBase
    {
        
        public PresentationDeviceInfoManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < System.Object[] > GetAll()
        {
            return this.CallMethod<Promise < System.Object[] >>("getAll");
        }
        
        public void ForceDiscovery()
        {
            this.CallVoidMethod("forceDiscovery");
        }
    }
}
