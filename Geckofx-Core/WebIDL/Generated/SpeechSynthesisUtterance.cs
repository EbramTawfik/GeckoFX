namespace Gecko.WebIDL
{
    using System;
    
    
    public class SpeechSynthesisUtterance : WebIDLBase
    {
        
        public SpeechSynthesisUtterance(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Text
        {
            get
            {
                return this.GetProperty<nsAString>("text");
            }
            set
            {
                this.SetProperty("text", value);
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
        
        public nsAString ChosenVoiceURI
        {
            get
            {
                return this.GetProperty<nsAString>("chosenVoiceURI");
            }
        }
    }
}
