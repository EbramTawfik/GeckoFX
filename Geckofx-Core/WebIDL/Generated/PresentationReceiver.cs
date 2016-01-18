namespace Gecko.WebIDL
{
    using System;
    
    
    public class PresentationReceiver : WebIDLBase
    {
        
        public PresentationReceiver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
