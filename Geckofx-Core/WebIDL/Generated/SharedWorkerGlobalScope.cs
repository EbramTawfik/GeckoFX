namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorkerGlobalScope : WebIDLBase
    {
        
        public SharedWorkerGlobalScope(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
    }
}
