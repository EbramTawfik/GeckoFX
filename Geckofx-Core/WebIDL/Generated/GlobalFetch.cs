namespace Gecko.WebIDL
{
    using System;
    
    
    public class GlobalFetch : WebIDLBase
    {
        
        public GlobalFetch(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise < nsISupports > Fetch(WebIDLUnion<nsISupports,USVString> input)
        {
            return this.CallMethod<Promise < nsISupports >>("fetch", input);
        }
        
        public Promise < nsISupports > Fetch(WebIDLUnion<nsISupports,USVString> input, object init)
        {
            return this.CallMethod<Promise < nsISupports >>("fetch", input, init);
        }
    }
}
