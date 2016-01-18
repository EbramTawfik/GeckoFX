namespace Gecko.WebIDL
{
    using System;
    
    
    public class PhoneNumberService : WebIDLBase
    {
        
        public PhoneNumberService(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports FuzzyMatch()
        {
            return this.CallMethod<nsISupports>("fuzzyMatch");
        }
        
        public nsISupports FuzzyMatch(nsAString number1)
        {
            return this.CallMethod<nsISupports>("fuzzyMatch", number1);
        }
        
        public nsISupports FuzzyMatch(nsAString number1, nsAString number2)
        {
            return this.CallMethod<nsISupports>("fuzzyMatch", number1, number2);
        }
        
        public nsAString Normalize(nsAString number)
        {
            return this.CallMethod<nsAString>("normalize", number);
        }
    }
}
