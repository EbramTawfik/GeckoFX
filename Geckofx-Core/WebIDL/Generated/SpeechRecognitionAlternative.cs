namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionAlternative : WebIDLBase
    {
        
        public SpeechRecognitionAlternative(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Transcript
        {
            get
            {
                return this.GetProperty<nsAString>("transcript");
            }
        }
        
        public float Confidence
        {
            get
            {
                return this.GetProperty<float>("confidence");
            }
        }
    }
}
