namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiCapabilities : WebIDLBase
    {
        
        public MozWifiCapabilities(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public WifiSecurityMethod[] Security
        {
            get
            {
                return this.GetProperty<WifiSecurityMethod[]>("security");
            }
        }
        
        public WifiWpaMethod[] EapMethod
        {
            get
            {
                return this.GetProperty<WifiWpaMethod[]>("eapMethod");
            }
        }
        
        public WifiWpaPhase2Method[] EapPhase2
        {
            get
            {
                return this.GetProperty<WifiWpaPhase2Method[]>("eapPhase2");
            }
        }
        
        public WifiWpaCertificate[] Certificate
        {
            get
            {
                return this.GetProperty<WifiWpaCertificate[]>("certificate");
            }
        }
    }
}
