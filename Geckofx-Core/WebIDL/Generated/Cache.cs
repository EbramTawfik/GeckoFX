namespace Gecko.WebIDL
{
    using System;
    
    
    public class Cache : WebIDLBase
    {
        
        public Cache(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Match(WebIDLUnion<nsISupports,USVString> request)
        {
            return this.CallMethod<Promise < nsISupports >>("match", request);
        }
        
        public Promise < nsISupports > Match(WebIDLUnion<nsISupports,USVString> request, object options)
        {
            return this.CallMethod<Promise < nsISupports >>("match", request, options);
        }
        
        public Promise < nsISupports[] > MatchAll()
        {
            return this.CallMethod<Promise < nsISupports[] >>("matchAll");
        }
        
        public Promise < nsISupports[] > MatchAll(WebIDLUnion<nsISupports,USVString> request)
        {
            return this.CallMethod<Promise < nsISupports[] >>("matchAll", request);
        }
        
        public Promise < nsISupports[] > MatchAll(WebIDLUnion<nsISupports,USVString> request, object options)
        {
            return this.CallMethod<Promise < nsISupports[] >>("matchAll", request, options);
        }
        
        public Promise Add(WebIDLUnion<nsISupports,USVString> request)
        {
            return this.CallMethod<Promise>("add", request);
        }
        
        public Promise AddAll(WebIDLUnion<nsISupports,USVString> requests)
        {
            return this.CallMethod<Promise>("addAll", requests);
        }
        
        public Promise Put(WebIDLUnion<nsISupports,USVString> request, nsISupports response)
        {
            return this.CallMethod<Promise>("put", request, response);
        }
        
        public Promise <bool> Delete(WebIDLUnion<nsISupports,USVString> request)
        {
            return this.CallMethod<Promise <bool>>("delete", request);
        }
        
        public Promise <bool> Delete(WebIDLUnion<nsISupports,USVString> request, object options)
        {
            return this.CallMethod<Promise <bool>>("delete", request, options);
        }
        
        public Promise < nsISupports[] > Keys()
        {
            return this.CallMethod<Promise < nsISupports[] >>("keys");
        }
        
        public Promise < nsISupports[] > Keys(WebIDLUnion<nsISupports,USVString> request)
        {
            return this.CallMethod<Promise < nsISupports[] >>("keys", request);
        }
        
        public Promise < nsISupports[] > Keys(WebIDLUnion<nsISupports,USVString> request, object options)
        {
            return this.CallMethod<Promise < nsISupports[] >>("keys", request, options);
        }
    }
}
