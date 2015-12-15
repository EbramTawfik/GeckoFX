namespace Gecko.WebIDL
{
    using System;
    
    
    public class Clients : WebIDLBase
    {
        
        public Clients(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise <object> Get(nsAString id)
        {
            return this.CallMethod<Promise <object>>("get", id);
        }
        
        public Promise < nsISupports[] > MatchAll(object options)
        {
            return this.CallMethod<Promise < nsISupports[] >>("matchAll", options);
        }
        
        public Promise < nsISupports > OpenWindow(USVString url)
        {
            return this.CallMethod<Promise < nsISupports >>("openWindow", url);
        }
        
        public Promise Claim()
        {
            return this.CallMethod<Promise>("claim");
        }
    }
}
