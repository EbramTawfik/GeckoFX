namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionError : WebIDLBase
    {
        
        public SpeechRecognitionError(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public SpeechRecognitionErrorCode Error
        {
            get
            {
                return this.GetProperty<SpeechRecognitionErrorCode>("error");
            }
        }
        
        public nsAString Message
        {
            get
            {
                return this.GetProperty<nsAString>("message");
            }
        }
    }
}
