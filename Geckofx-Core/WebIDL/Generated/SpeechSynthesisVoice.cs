namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisVoice : WebIDLBase
    {
        
        public SpeechSynthesisVoice(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string VoiceURI
        {
            get
            {
                return this.GetProperty<string>("voiceURI");
            }
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string Lang
        {
            get
            {
                return this.GetProperty<string>("lang");
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
