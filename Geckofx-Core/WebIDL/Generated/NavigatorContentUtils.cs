namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorContentUtils : WebIDLBase
    {
        
        public NavigatorContentUtils(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public void RegisterProtocolHandler(nsAString scheme, nsAString url, nsAString title)
        {
            this.CallVoidMethod("registerProtocolHandler", scheme, url, title);
        }
        
        public void RegisterContentHandler(nsAString mimeType, nsAString url, nsAString title)
        {
            this.CallVoidMethod("registerContentHandler", mimeType, url, title);
        }
    }
}
