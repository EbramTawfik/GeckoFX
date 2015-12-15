namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCCertificate : WebIDLBase
    {
        
        public RTCCertificate(nsISupports thisObject) : 
                base(thisObject)
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
