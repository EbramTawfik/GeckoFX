namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMParser : WebIDLBase
    {
        
        public DOMParser(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMDocument ParseFromString(nsAString str, SupportedType type)
        {
            return this.CallMethod<nsIDOMDocument>("parseFromString", str, type);
        }
        
        public nsIDOMDocument ParseFromBuffer(byte[] buf, uint bufLen, SupportedType type)
        {
            return this.CallMethod<nsIDOMDocument>("parseFromBuffer", buf, bufLen, type);
        }
        
        public nsIDOMDocument ParseFromBuffer(IntPtr buf, uint bufLen, SupportedType type)
        {
            return this.CallMethod<nsIDOMDocument>("parseFromBuffer", buf, bufLen, type);
        }
        
        public nsIDOMDocument ParseFromStream(nsISupports stream, nsAString charset, int contentLength, SupportedType type)
        {
            return this.CallMethod<nsIDOMDocument>("parseFromStream", stream, charset, contentLength, type);
        }
        
        public void Init(nsISupports principal, nsISupports documentURI, nsISupports baseURI)
        {
            this.CallVoidMethod("init", principal, documentURI, baseURI);
        }
    }
}
