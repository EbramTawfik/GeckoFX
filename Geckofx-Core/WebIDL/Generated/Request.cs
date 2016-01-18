namespace Gecko.WebIDL
{
    using System;
    
    
    public class Request : WebIDLBase
    {
        
        public Request(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ByteString Method
        {
            get
            {
                return this.GetProperty<ByteString>("method");
            }
        }
        
        public USVString Url
        {
            get
            {
                return this.GetProperty<USVString>("url");
            }
        }
        
        public nsISupports Headers
        {
            get
            {
                return this.GetProperty<nsISupports>("headers");
            }
        }
        
        public RequestContext Context
        {
            get
            {
                return this.GetProperty<RequestContext>("context");
            }
        }
        
        public nsAString Referrer
        {
            get
            {
                return this.GetProperty<nsAString>("referrer");
            }
        }
        
        public RequestMode Mode
        {
            get
            {
                return this.GetProperty<RequestMode>("mode");
            }
        }
        
        public RequestCredentials Credentials
        {
            get
            {
                return this.GetProperty<RequestCredentials>("credentials");
            }
        }
        
        public RequestCache Cache
        {
            get
            {
                return this.GetProperty<RequestCache>("cache");
            }
        }
        
        public RequestRedirect Redirect
        {
            get
            {
                return this.GetProperty<RequestRedirect>("redirect");
            }
        }
        
        public nsISupports Clone()
        {
            return this.CallMethod<nsISupports>("clone");
        }
        
        public void SetContentPolicyType(UInt32 context)
        {
            this.CallVoidMethod("setContentPolicyType", context);
        }
    }
}
