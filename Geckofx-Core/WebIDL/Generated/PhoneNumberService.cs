namespace Gecko.WebIDL
{
    using System;
    
    
    public class PhoneNumberService : WebIDLBase
    {
        
        public PhoneNumberService(nsISupports thisObject) : 
                base(thisObject)
        {
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
