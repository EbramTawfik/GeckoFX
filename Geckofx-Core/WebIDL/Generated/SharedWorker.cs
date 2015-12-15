namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorker : WebIDLBase
    {
        
        public SharedWorker(nsISupports thisObject) : 
                base(thisObject)
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
