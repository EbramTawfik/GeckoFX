namespace Gecko.WebIDL
{
    using System;
    
    
    public class GlobalFetch : WebIDLBase
    {
        
        public GlobalFetch(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise < nsISupports > Fetch(WebIDLUnion<nsISupports,USVString> input, object init)
        {
            return this.CallMethod<Promise < nsISupports >>("fetch", input, init);
        }
    }
}
