namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisVoice : WebIDLBase
    {
        
        public SpeechSynthesisVoice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString VoiceURI
        {
            get
            {
                return this.GetProperty<nsAString>("voiceURI");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString Lang
        {
            get
            {
                return this.GetProperty<nsAString>("lang");
            }
        }
        
        public bool LocalService
        {
            get
            {
                return this.GetProperty<bool>("localService");
            }
        }
        
        public bool Default
        {
            get
            {
                return this.GetProperty<bool>("default");
            }
        }
    }
}
