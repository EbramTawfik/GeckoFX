namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraRecorderAudioProfile : WebIDLBase
    {
        
        public CameraRecorderAudioProfile(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Codec
        {
            get
            {
                return this.GetProperty<nsAString>("codec");
            }
        }
        
        public uint BitsPerSecond
        {
            get
            {
                return this.GetProperty<uint>("bitsPerSecond");
            }
        }
        
        public uint SamplesPerSecond
        {
            get
            {
                return this.GetProperty<uint>("samplesPerSecond");
            }
        }
        
        public uint Channels
        {
            get
            {
                return this.GetProperty<uint>("channels");
            }
        }
    }
}
