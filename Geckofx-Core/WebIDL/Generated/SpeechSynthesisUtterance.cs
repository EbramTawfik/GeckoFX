namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisUtterance : WebIDLBase
    {
        
        public SpeechSynthesisUtterance(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Text
        {
            get
            {
                return this.GetProperty<string>("text");
            }
            set
            {
                this.SetProperty("text", value);
            }
        }
        
        public string Lang
        {
            get
            {
                return this.GetProperty<string>("lang");
            }
            set
            {
                this.SetProperty("lang", value);
            }
        }
        
        public nsISupports Voice
        {
            get
            {
                return this.GetProperty<nsISupports>("voice");
            }
            set
            {
                this.SetProperty("voice", value);
            }
        }
        
        public float Volume
        {
            get
            {
                return this.GetProperty<float>("volume");
            }
            set
            {
                this.SetProperty("volume", value);
            }
        }
        
        public float Rate
        {
            get
            {
                return this.GetProperty<float>("rate");
            }
            set
            {
                this.SetProperty("rate", value);
            }
        }
        
        public float Pitch
        {
            get
            {
                return this.GetProperty<float>("pitch");
            }
            set
            {
                this.SetProperty("pitch", value);
            }
        }
        
        public string ChosenVoiceURI
        {
            get
            {
                return this.GetProperty<string>("chosenVoiceURI");
            }
        }
    }
}
