namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputRegistryEventDetail : WebIDLBase
    {
        
        public MozInputRegistryEventDetail(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string ManifestURL
        {
            get
            {
                return this.GetProperty<string>("manifestURL");
            }
        }
        
        public string InputId
        {
            get
            {
                return this.GetProperty<string>("inputId");
            }
        }
        
        public object InputManifest
        {
            get
            {
                return this.GetProperty<object>("inputManifest");
            }
        }
        
        public void WaitUntil(Promise <object> p)
        {
            this.CallVoidMethod("waitUntil", p);
        }
    }
}
