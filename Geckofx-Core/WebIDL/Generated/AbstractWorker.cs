namespace Gecko.WebIDL
{
    using System;
    
    
    public class AbstractWorker : WebIDLBase
    {
        
        public AbstractWorker(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
    }
}
