namespace Gecko.WebIDL
{
    using System;
    
    
    public class RequestSyncScheduler : WebIDLBase
    {
        
        public RequestSyncScheduler(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise Register(USVString task, object @params)
        {
            return this.CallMethod<Promise>("register", task, @params);
        }
        
        public Promise Unregister(USVString task)
        {
            return this.CallMethod<Promise>("unregister", task);
        }
        
        public Promise < System.Object[] > Registrations()
        {
            return this.CallMethod<Promise < System.Object[] >>("registrations");
        }
        
        public Promise <object> Registration(USVString task)
        {
            return this.CallMethod<Promise <object>>("registration", task);
        }
    }
}
