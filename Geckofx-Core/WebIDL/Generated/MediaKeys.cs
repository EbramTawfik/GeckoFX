namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeys : WebIDLBase
    {
        
        public MediaKeys(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string KeySystem
        {
            get
            {
                return this.GetProperty<string>("keySystem");
            }
        }
        
        public nsISupports CreateSession()
        {
            return this.CallMethod<nsISupports>("createSession");
        }
        
        public nsISupports CreateSession(SessionType sessionType)
        {
            return this.CallMethod<nsISupports>("createSession", sessionType);
        }
        
        public Promise SetServerCertificate(WebIDLUnion<IntPtr,IntPtr> serverCertificate)
        {
            return this.CallMethod<Promise>("setServerCertificate", serverCertificate);
        }
    }
}
