namespace Gecko.WebIDL
{
    using System;
    
    
    public class Permissions : WebIDLBase
    {
        
        public Permissions(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > Query(object permission)
        {
            return this.CallMethod<Promise < nsISupports >>("query", permission);
        }
    }
}
