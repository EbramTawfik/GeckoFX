namespace Gecko.WebIDL
{
    using System;
    
    
    public class PermissionSettings : WebIDLBase
    {
        
        public PermissionSettings(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Get(string permission, string manifestURI, string origin, bool browserFlag)
        {
            return this.CallMethod<string>("get", permission, manifestURI, origin, browserFlag);
        }
        
        public void Set(string permission, string value, string manifestURI, string origin, bool browserFlag)
        {
            this.CallVoidMethod("set", permission, value, manifestURI, origin, browserFlag);
        }
        
        public bool IsExplicit(string permission, string manifestURI, string origin, bool browserFlag)
        {
            return this.CallMethod<bool>("isExplicit", permission, manifestURI, origin, browserFlag);
        }
        
        public void Remove(string permission, string manifestURI, string origin)
        {
            this.CallVoidMethod("remove", permission, manifestURI, origin);
        }
    }
}
