namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProvider : WebIDLBase
    {
        
        public RTCIdentityProvider(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin);
        }
        
        public Promise <object> GenerateAssertion(string contents, string origin, string usernameHint)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin, usernameHint);
        }
        
        public Promise <object> ValidateAssertion(string assertion, string origin)
        {
            return this.CallMethod<Promise <object>>("validateAssertion", assertion, origin);
        }
    }
}
