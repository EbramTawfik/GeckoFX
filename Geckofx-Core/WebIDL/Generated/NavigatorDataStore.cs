namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorDataStore : WebIDLBase
    {
        
        public NavigatorDataStore(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports[] > GetDataStores(nsAString name)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getDataStores", name);
        }
        
        public Promise < nsISupports[] > GetDataStores(nsAString name, nsAString owner)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getDataStores", name, owner);
        }
    }
}
