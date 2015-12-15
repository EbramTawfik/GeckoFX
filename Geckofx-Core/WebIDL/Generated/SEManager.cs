namespace Gecko.WebIDL
{
    using System;
    
    
    public class SEManager : WebIDLBase
    {
        
        public SEManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetSEReaders()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getSEReaders");
        }
    }
}
