namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesis : WebIDLBase
    {
        
        public SpeechSynthesis(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Pending
        {
            get
            {
                return this.GetProperty<bool>("pending");
            }
        }
        
        public bool Speaking
        {
            get
            {
                return this.GetProperty<bool>("speaking");
            }
        }
        
        public bool Paused
        {
            get
            {
                return this.GetProperty<bool>("paused");
            }
        }
        
        public void Speak(nsISupports utterance)
        {
            this.CallVoidMethod("speak", utterance);
        }
        
        public void Cancel()
        {
            this.CallVoidMethod("cancel");
        }
        
        public void Pause()
        {
            this.CallVoidMethod("pause");
        }
        
        public void Resume()
        {
            this.CallVoidMethod("resume");
        }
        
        public nsISupports[] GetVoices()
        {
            return this.CallMethod<nsISupports[]>("getVoices");
        }
        
        public void ForceEnd()
        {
            this.CallVoidMethod("forceEnd");
        }
    }
}
