namespace Gecko.WebIDL
{
    using System;
    
    
    public class PushSubscription : WebIDLBase
    {
        
        public PushSubscription(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public USVString Endpoint
        {
            get
            {
                return this.GetProperty<USVString>("endpoint");
            }
        }
        
        public IntPtr GetKey(PushEncryptionKeyName name)
        {
            return this.CallMethod<IntPtr>("getKey", name);
        }
        
        public Promise <bool> Unsubscribe()
        {
            return this.CallMethod<Promise <bool>>("unsubscribe");
        }
        
        public void SetPrincipal(nsISupports principal)
        {
            this.CallVoidMethod("setPrincipal", principal);
        }
    }
}
