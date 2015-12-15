namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBFactory : WebIDLBase
    {
        
        public IDBFactory(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Open(nsAString name, ulong version)
        {
            return this.CallMethod<nsISupports>("open", name, version);
        }
        
        public nsISupports Open(nsAString name, object options)
        {
            return this.CallMethod<nsISupports>("open", name, options);
        }
        
        public nsISupports DeleteDatabase(nsAString name, object options)
        {
            return this.CallMethod<nsISupports>("deleteDatabase", name, options);
        }
        
        public short Cmp(object first, object second)
        {
            return this.CallMethod<short>("cmp", first, second);
        }
        
        public nsISupports OpenForPrincipal(nsISupports principal, nsAString name, ulong version)
        {
            return this.CallMethod<nsISupports>("openForPrincipal", principal, name, version);
        }
        
        public nsISupports OpenForPrincipal(nsISupports principal, nsAString name, object options)
        {
            return this.CallMethod<nsISupports>("openForPrincipal", principal, name, options);
        }
        
        public nsISupports DeleteForPrincipal(nsISupports principal, nsAString name, object options)
        {
            return this.CallMethod<nsISupports>("deleteForPrincipal", principal, name, options);
        }
    }
}
