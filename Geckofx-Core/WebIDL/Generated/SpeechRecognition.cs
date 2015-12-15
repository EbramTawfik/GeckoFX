namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechRecognition : WebIDLBase
    {
        
        public SpeechRecognition(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Grammars
        {
            get
            {
                return this.GetProperty<nsISupports>("grammars");
            }
            set
            {
                this.SetProperty("grammars", value);
            }
        }
        
        public nsAString Lang
        {
            get
            {
                return this.GetProperty<nsAString>("lang");
            }
            set
            {
                this.SetProperty("lang", value);
            }
        }
        
        public bool Continuous
        {
            get
            {
                return this.GetProperty<bool>("continuous");
            }
            set
            {
                this.SetProperty("continuous", value);
            }
        }
        
        public bool InterimResults
        {
            get
            {
                return this.GetProperty<bool>("interimResults");
            }
            set
            {
                this.SetProperty("interimResults", value);
            }
        }
        
        public uint MaxAlternatives
        {
            get
            {
                return this.GetProperty<uint>("maxAlternatives");
            }
            set
            {
                this.SetProperty("maxAlternatives", value);
            }
        }
        
        public nsAString ServiceURI
        {
            get
            {
                return this.GetProperty<nsAString>("serviceURI");
            }
            set
            {
                this.SetProperty("serviceURI", value);
            }
        }
        
        public void Start(nsISupports stream)
        {
            this.CallVoidMethod("start", stream);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Abort()
        {
            this.CallVoidMethod("abort");
        }
    }
}
