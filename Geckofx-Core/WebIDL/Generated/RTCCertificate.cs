namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCCertificate : WebIDLBase
    {
        
        public RTCCertificate(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Expires
        {
            get
            {
                return this.GetProperty<nsISupports>("expires");
            }
        }
    }
}
