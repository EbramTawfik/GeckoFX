namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProvider : WebIDLBase
    {
        
        public RTCIdentityProvider(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Promise <object> GenerateAssertion(nsAString contents, nsAString origin)
        {
            return this.CallMethod<Promise <object>>("generateAssertion", contents, origin);
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
