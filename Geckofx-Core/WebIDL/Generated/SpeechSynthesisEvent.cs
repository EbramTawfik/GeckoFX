namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisEvent : WebIDLBase
    {
        
        public SpeechSynthesisEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Utterance
        {
            get
            {
                return this.GetProperty<nsISupports>("utterance");
            }
        }
        
        public uint CharIndex
        {
            get
            {
                return this.GetProperty<uint>("charIndex");
            }
        }
        
        public float ElapsedTime
        {
            get
            {
                return this.GetProperty<float>("elapsedTime");
            }
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
    }
}
