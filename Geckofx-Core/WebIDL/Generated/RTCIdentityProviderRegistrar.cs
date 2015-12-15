namespace Gecko.WebIDL
{
    using System;
    
    
    public class RTCIdentityProviderRegistrar : WebIDLBase
    {
        
        public RTCIdentityProviderRegistrar(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Idp
        {
            get
            {
                return this.GetProperty<nsISupports>("idp");
            }
        }
        
        public void Register(nsISupports idp)
        {
            this.CallVoidMethod("register", idp);
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
