namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushManager : WebIDLBase
    {
        
        public PushManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void SetPushManagerImpl(nsISupports store)
        {
            this.CallVoidMethod("setPushManagerImpl", store);
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
    }
}
