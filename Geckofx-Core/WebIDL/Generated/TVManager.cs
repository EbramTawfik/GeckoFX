namespace Gecko.WebIDL
{
    using System;
    
    
    public class TVManager : WebIDLBase
    {
        
        public TVManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetTuners()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getTuners");
        }
    }
}
