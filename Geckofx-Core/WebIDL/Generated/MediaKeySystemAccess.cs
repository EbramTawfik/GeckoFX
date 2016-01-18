namespace Gecko.WebIDL
{
    using System;
    
    
    public class MediaKeySystemAccess : WebIDLBase
    {
        
        public MediaKeySystemAccess(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString KeySystem
        {
            get
            {
                return this.GetProperty<nsAString>("keySystem");
            }
        }
        
        public object GetConfiguration()
        {
            return this.CallMethod<object>("getConfiguration");
        }
        
        public Promise < nsISupports > CreateMediaKeys()
        {
            return this.CallMethod<Promise < nsISupports >>("createMediaKeys");
        }
    }
}
