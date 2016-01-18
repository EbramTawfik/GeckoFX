namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorkerGlobalScope : WebIDLBase
    {
        
        public SharedWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
