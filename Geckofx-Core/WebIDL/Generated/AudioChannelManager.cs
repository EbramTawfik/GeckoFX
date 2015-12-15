namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioChannelManager : WebIDLBase
    {
        
        public AudioChannelManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Headphones
        {
            get
            {
                return this.GetProperty<bool>("headphones");
            }
        }
        
        public nsAString VolumeControlChannel
        {
            get
            {
                return this.GetProperty<nsAString>("volumeControlChannel");
            }
            set
            {
                this.SetProperty("volumeControlChannel", value);
            }
        }
        
        public nsISupports[] AllowedAudioChannels
        {
            get
            {
                return this.GetProperty<nsISupports[]>("allowedAudioChannels");
            }
        }
    }
}
