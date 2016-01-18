namespace Gecko.WebIDL
{
    using System;
    
    
    public class SharedWorkerGlobalScope : WebIDLBase
    {
        
        public SharedWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
    }
}
