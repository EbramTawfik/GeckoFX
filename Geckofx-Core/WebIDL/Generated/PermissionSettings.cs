namespace Gecko.WebIDL
{
    using System;
    
    
    public class PermissionSettings : WebIDLBase
    {
        
        public PermissionSettings(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Get(nsAString permission, nsAString manifestURI, nsAString origin, bool browserFlag)
        {
            return this.CallMethod<nsAString>("get", permission, manifestURI, origin, browserFlag);
        }
        
        public void Set(nsAString permission, nsAString value, nsAString manifestURI, nsAString origin, bool browserFlag)
        {
            this.CallVoidMethod("set", permission, value, manifestURI, origin, browserFlag);
        }
        
        public bool IsExplicit(nsAString permission, nsAString manifestURI, nsAString origin, bool browserFlag)
        {
            return this.CallMethod<bool>("isExplicit", permission, manifestURI, origin, browserFlag);
        }
        
        public void Remove(nsAString permission, nsAString manifestURI, nsAString origin)
        {
            this.CallVoidMethod("remove", permission, manifestURI, origin);
        }
    }
}
