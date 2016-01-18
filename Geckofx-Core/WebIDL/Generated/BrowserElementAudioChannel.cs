namespace Gecko.WebIDL
{
    using System;
    
    
    public class BrowserElementAudioChannel : WebIDLBase
    {
        
        public BrowserElementAudioChannel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public AudioChannel Name
        {
            get
            {
                return this.GetProperty<AudioChannel>("name");
            }
        }
        
        public nsISupports GetVolume()
        {
            return this.CallMethod<nsISupports>("getVolume");
        }
        
        public nsISupports SetVolume(float aVolume)
        {
            return this.CallMethod<nsISupports>("setVolume", aVolume);
        }
        
        public nsISupports GetMuted()
        {
            return this.CallMethod<nsISupports>("getMuted");
        }
        
        public nsISupports SetMuted(bool aMuted)
        {
            return this.CallMethod<nsISupports>("setMuted", aMuted);
        }
        
        public nsISupports IsActive()
        {
            return this.CallMethod<nsISupports>("isActive");
        }
        
        public nsISupports NotifyChannel(nsAString aEvent)
        {
            return this.CallMethod<nsISupports>("notifyChannel", aEvent);
        }
    }
}
