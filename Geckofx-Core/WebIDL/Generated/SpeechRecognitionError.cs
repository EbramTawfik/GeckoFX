namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionError : WebIDLBase
    {
        
        public SpeechRecognitionError(nsISupports thisObject) : 
                base(thisObject)
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
