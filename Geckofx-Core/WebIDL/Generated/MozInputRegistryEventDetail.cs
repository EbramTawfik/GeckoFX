namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozInputRegistryEventDetail : WebIDLBase
    {
        
        public MozInputRegistryEventDetail(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString ManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("manifestURL");
            }
        }
        
        public nsAString InputId
        {
            get
            {
                return this.GetProperty<nsAString>("inputId");
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
