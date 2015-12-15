namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationReceiver : WebIDLBase
    {
        
        public PresentationReceiver(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > GetConnection()
        {
            return this.CallMethod<Promise < nsISupports >>("getConnection");
        }
        
        public Promise < nsISupports[] > GetConnections()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getConnections");
        }
    }
}
