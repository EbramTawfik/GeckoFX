namespace Gecko.WebIDL
{
    using System;
    
    
    public class IdentityManager : WebIDLBase
    {
        
        public IdentityManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public void Watch(object options)
        {
            this.CallVoidMethod("watch", options);
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
