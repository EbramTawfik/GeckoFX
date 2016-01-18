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
        
        public nsISupports FuzzyMatch(string number1)
        {
            return this.CallMethod<nsISupports>("fuzzyMatch", number1);
        }
        
        public nsISupports FuzzyMatch(string number1, string number2)
        {
            return this.CallMethod<nsISupports>("fuzzyMatch", number1, number2);
        }
        
        public string Normalize(string number)
        {
            return this.CallMethod<string>("normalize", number);
        }
    }
}
