namespace Gecko.WebIDL
{
    using System;
    
    
    public class IdentityManager : WebIDLBase
    {
        
        public IdentityManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void Watch()
        {
            this.CallVoidMethod("watch");
        }
        
        public void Watch(object options)
        {
            this.CallVoidMethod("watch", options);
        }
        
        public void Request()
        {
            this.CallVoidMethod("request");
        }
        
        public void Request(object options)
        {
            this.CallVoidMethod("request", options);
        }
        
        public void Logout()
        {
            this.CallVoidMethod("logout");
        }
    }
}
