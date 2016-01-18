namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBFactory : WebIDLBase
    {
        
        public IDBFactory(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Open(string name, ulong version)
        {
            return this.CallMethod<nsISupports>("open", name, version);
        }
        
        public nsISupports Open(string name)
        {
            return this.CallMethod<nsISupports>("open", name);
        }
        
        public nsISupports Open(string name, object options)
        {
            return this.CallMethod<nsISupports>("open", name, options);
        }
        
        public nsISupports DeleteDatabase(string name)
        {
            return this.CallMethod<nsISupports>("deleteDatabase", name);
        }
        
        public nsISupports DeleteDatabase(string name, object options)
        {
            return this.CallMethod<nsISupports>("deleteDatabase", name, options);
        }
        
        public short Cmp(object first, object second)
        {
            return this.CallMethod<short>("cmp", first, second);
        }
        
        public nsISupports OpenForPrincipal(nsISupports principal, string name, ulong version)
        {
            return this.CallMethod<nsISupports>("openForPrincipal", principal, name, version);
        }
        
        public nsISupports OpenForPrincipal(nsISupports principal, string name)
        {
            return this.CallMethod<nsISupports>("openForPrincipal", principal, name);
        }
        
        public nsISupports OpenForPrincipal(nsISupports principal, string name, object options)
        {
            return this.CallMethod<nsISupports>("openForPrincipal", principal, name, options);
        }
        
        public nsISupports DeleteForPrincipal(nsISupports principal, string name)
        {
            return this.CallMethod<nsISupports>("deleteForPrincipal", principal, name);
        }
        
        public nsISupports DeleteForPrincipal(nsISupports principal, string name, object options)
        {
            return this.CallMethod<nsISupports>("deleteForPrincipal", principal, name, options);
        }
    }
}
