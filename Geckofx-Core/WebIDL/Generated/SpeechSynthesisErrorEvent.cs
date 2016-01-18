namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisErrorEvent : WebIDLBase
    {
        
        public SpeechSynthesisErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
