namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorDataStore : WebIDLBase
    {
        
        public NavigatorDataStore(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetDataStores(nsAString name, nsAString owner)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getDataStores", name, owner);
        }
    }
}
