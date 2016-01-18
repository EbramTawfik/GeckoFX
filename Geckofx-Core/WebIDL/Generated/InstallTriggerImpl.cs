namespace Gecko.WebIDL
{
    using System;
    
    
    public class InstallTriggerImpl : WebIDLBase
    {
        
        public InstallTriggerImpl(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Enabled()
        {
            return this.CallMethod<bool>("enabled");
        }
        
        public bool UpdateEnabled()
        {
            return this.CallMethod<bool>("updateEnabled");
        }
        
        public bool Install(MozMap < WebIDLUnion<nsAString,System.Object>> installs)
        {
            return this.CallMethod<bool>("install", installs);
        }
        
        public bool InstallChrome(ushort type, nsAString url, nsAString skin)
        {
            return this.CallMethod<bool>("installChrome", type, url, skin);
        }
        
        public bool StartSoftwareUpdate(nsAString url)
        {
            return this.CallMethod<bool>("startSoftwareUpdate", url);
        }
        
        public bool StartSoftwareUpdate(nsAString url, ushort flags)
        {
            return this.CallMethod<bool>("startSoftwareUpdate", url, flags);
        }
    }
}
