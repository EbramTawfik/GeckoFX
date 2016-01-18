namespace Gecko.WebIDL
{
    using System;
    
    
    public class RequestSyncManager : WebIDLBase
    {
        
        public RequestSyncManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports[] > Registrations()
        {
            return this.CallMethod<Promise < nsISupports[] >>("registrations");
        }
    }
}
