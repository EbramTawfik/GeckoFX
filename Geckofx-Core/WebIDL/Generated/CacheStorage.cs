namespace Gecko.WebIDL
{
    using System;
    
    
    public class CacheStorage : WebIDLBase
    {
        
        public CacheStorage(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > Match(WebIDLUnion<nsISupports,USVString> request, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("match", request, options);
        }
        
        public Promise <bool> Has(nsAString cacheName)
        {
            return this.CallMethod<Promise <bool>>("has", cacheName);
        }
        
        public Promise < nsISupports > Open(nsAString cacheName)
        {
            return this.CallMethod<Promise < nsISupports >>("open", cacheName);
        }
        
        public Promise <bool> Delete(nsAString cacheName)
        {
            return this.CallMethod<Promise <bool>>("delete", cacheName);
        }
        
        public Promise < nsAString[] > Keys()
        {
            return this.CallMethod<Promise < nsAString[] >>("keys");
        }
    }
}
