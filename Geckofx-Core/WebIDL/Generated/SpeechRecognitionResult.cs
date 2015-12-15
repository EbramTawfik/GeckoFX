namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionResult : WebIDLBase
    {
        
        public SpeechRecognitionResult(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Length
        {
            get
            {
                return this.GetProperty<uint>("length");
            }
        }
        
        public bool IsFinal
        {
            get
            {
                return this.GetProperty<bool>("isFinal");
            }
        }
    }
}
