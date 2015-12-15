namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLVideoElement : WebIDLBase
    {
        
        public HTMLVideoElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
        
        public uint VideoWidth
        {
            get
            {
                return this.GetProperty<uint>("videoWidth");
            }
        }
        
        public uint VideoHeight
        {
            get
            {
                return this.GetProperty<uint>("videoHeight");
            }
        }
        
        public nsAString Poster
        {
            get
            {
                return this.GetProperty<nsAString>("poster");
            }
            set
            {
                this.SetProperty("poster", value);
            }
        }
        
        public uint MozParsedFrames
        {
            get
            {
                return this.GetProperty<uint>("mozParsedFrames");
            }
        }
        
        public uint MozDecodedFrames
        {
            get
            {
                return this.GetProperty<uint>("mozDecodedFrames");
            }
        }
        
        public uint MozPresentedFrames
        {
            get
            {
                return this.GetProperty<uint>("mozPresentedFrames");
            }
        }
        
        public uint MozPaintedFrames
        {
            get
            {
                return this.GetProperty<uint>("mozPaintedFrames");
            }
        }
        
        public double MozFrameDelay
        {
            get
            {
                return this.GetProperty<double>("mozFrameDelay");
            }
        }
        
        public bool MozHasAudio
        {
            get
            {
                return this.GetProperty<bool>("mozHasAudio");
            }
        }
        
        public bool MozUseScreenWakeLock
        {
            get
            {
                return this.GetProperty<bool>("mozUseScreenWakeLock");
            }
            set
            {
                this.SetProperty("mozUseScreenWakeLock", value);
            }
        }
        
        public nsISupports GetVideoPlaybackQuality()
        {
            return this.CallMethod<nsISupports>("getVideoPlaybackQuality");
        }
    }
}
