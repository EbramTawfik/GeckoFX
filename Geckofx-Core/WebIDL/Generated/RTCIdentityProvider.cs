namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProvider : WebIDLBase
    {
        
        public RTCIdentityProvider(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public Promise <object> GenerateAssertion(nsAString contents, nsAString origin, nsAString usernameHint)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin, usernameHint);
        }
        
        public Promise <object> ValidateAssertion(nsAString assertion, nsAString origin)
        {
            return this.CallMethod<Promise <object>>("validateAssertion", assertion, origin);
        }
    }
}
