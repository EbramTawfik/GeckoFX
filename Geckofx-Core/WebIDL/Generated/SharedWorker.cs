namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorker : WebIDLBase
    {
        
        public SharedWorker(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Port
        {
            get
            {
                return this.GetProperty<nsISupports>("port");
            }
        }
    }
}
