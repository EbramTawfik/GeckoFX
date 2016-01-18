namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioChannelManager : WebIDLBase
    {
        
        public AudioChannelManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Headphones
        {
            get
            {
                return this.GetProperty<bool>("headphones");
            }
        }
        
        public string VolumeControlChannel
        {
            get
            {
                return this.GetProperty<string>("volumeControlChannel");
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
