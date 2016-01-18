namespace Gecko.WebIDL
{
    using System;
    
    
    public class Response : WebIDLBase
    {
        
        public Response(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ResponseType Type
        {
            get
            {
                return this.GetProperty<ResponseType>("type");
            }
        }
        
        public USVString Url
        {
            get
            {
                return this.GetProperty<USVString>("url");
            }
        }
        
        public ushort Status
        {
            get
            {
                return this.GetProperty<ushort>("status");
            }
        }
        
        public bool Ok
        {
            get
            {
                return this.GetProperty<bool>("ok");
            }
        }
        
        public ByteString StatusText
        {
            get
            {
                return this.GetProperty<ByteString>("statusText");
            }
        }
        
        public nsISupports Headers
        {
            get
            {
                return this.GetProperty<nsISupports>("headers");
            }
        }
        
        public nsISupports Clone()
        {
            return this.CallMethod<nsISupports>("clone");
        }
    }
}
