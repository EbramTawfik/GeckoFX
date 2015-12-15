namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathNSResolver : WebIDLBase
    {
        
        public XPathNSResolver(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString LookupNamespaceURI(nsAString prefix)
        {
            return this.CallMethod<nsAString>("lookupNamespaceURI", prefix);
        }
    }
}
