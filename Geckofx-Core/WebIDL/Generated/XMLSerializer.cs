namespace Gecko.WebIDL
{
    using System;
    
    
    public class XMLSerializer : WebIDLBase
    {
        
        public XMLSerializer(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string SerializeToString(nsIDOMNode root)
        {
            return this.CallMethod<string>("serializeToString", root);
        }
        
        public void SerializeToStream(nsIDOMNode root, nsISupports stream, string charset)
        {
            this.CallVoidMethod("serializeToStream", root, stream, charset);
        }
    }
}
