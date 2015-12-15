namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLSerializer : WebIDLBase
    {
        
        public XMLSerializer(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString SerializeToString(nsIDOMNode root)
        {
            return this.CallMethod<nsAString>("serializeToString", root);
        }
        
        public void SerializeToStream(nsIDOMNode root, nsISupports stream, nsAString charset)
        {
            this.CallVoidMethod("serializeToStream", root, stream, charset);
        }
    }
}
