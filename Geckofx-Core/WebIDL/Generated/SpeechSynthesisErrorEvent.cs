namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisErrorEvent : WebIDLBase
    {
        
        public SpeechSynthesisErrorEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public SpeechSynthesisErrorCode Error
        {
            get
            {
                return this.GetProperty<SpeechSynthesisErrorCode>("error");
            }
        }
    }
}
