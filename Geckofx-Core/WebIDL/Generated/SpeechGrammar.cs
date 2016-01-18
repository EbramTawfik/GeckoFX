namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechGrammar : WebIDLBase
    {
        
        public SpeechGrammar(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Src
        {
            get
            {
                return this.GetProperty<nsAString>("src");
            }
            set
            {
                this.SetProperty("src", value);
            }
        }
        
        public float Weight
        {
            get
            {
                return this.GetProperty<float>("weight");
            }
            set
            {
                this.SetProperty("weight", value);
            }
        }
    }
}
