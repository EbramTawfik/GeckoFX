namespace Gecko.WebIDL
{
    using System;
    
    
    public class RequestSyncManager : WebIDLBase
    {
        
        public RequestSyncManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports[] > Registrations()
        {
            return this.CallMethod<Promise < nsISupports[] >>("registrations");
        }
    }
}
