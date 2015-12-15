namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushManagerImpl : WebIDLBase
    {
        
        public PushManagerImpl(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > Subscribe()
        {
            return this.CallMethod<Promise < nsISupports >>("subscribe");
        }
        
        public Promise < nsISupports > GetSubscription()
        {
            return this.CallMethod<Promise < nsISupports >>("getSubscription");
        }
        
        public Promise < PushPermissionState > PermissionState()
        {
            return this.CallMethod<Promise < PushPermissionState >>("permissionState");
        }
        
        public void SetScope(nsAString scope)
        {
            this.CallVoidMethod("setScope", scope);
        }
    }
}
