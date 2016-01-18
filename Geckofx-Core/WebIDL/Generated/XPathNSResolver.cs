namespace Gecko.WebIDL
{
    using System;
    
    
    public class XPathNSResolver : WebIDLBase
    {
        
        public XPathNSResolver(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString LookupNamespaceURI(nsAString prefix)
        {
            return this.CallMethod<nsAString>("lookupNamespaceURI", prefix);
        }
    }
}
