namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognitionEvent : WebIDLBase
    {
        
        public SpeechRecognitionEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public uint ResultIndex
        {
            get
            {
                return this.GetProperty<uint>("resultIndex");
            }
        }
        
        public nsISupports Results
        {
            get
            {
                return this.GetProperty<nsISupports>("results");
            }
        }
        
        public object Interpretation
        {
            get
            {
                return this.GetProperty<object>("interpretation");
            }
        }
        
        public nsIDOMDocument Emma
        {
            get
            {
                return this.GetProperty<nsIDOMDocument>("emma");
            }
        }
    }
}
