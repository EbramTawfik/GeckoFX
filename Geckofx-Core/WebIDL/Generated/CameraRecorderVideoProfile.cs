namespace Gecko.WebIDL
{
    using System;
    
    
    public class CameraRecorderVideoProfile : WebIDLBase
    {
        
        public CameraRecorderVideoProfile(nsISupports thisObject) : 
                base(thisObject)
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
        
        public uint FramesPerSecond
        {
            get
            {
                return this.GetProperty<uint>("framesPerSecond");
            }
        }
        
        public object Size
        {
            get
            {
                return this.GetProperty<object>("size");
            }
        }
        
        public uint Width
        {
            get
            {
                return this.GetProperty<uint>("width");
            }
        }
        
        public uint Height
        {
            get
            {
                return this.GetProperty<uint>("height");
            }
        }
    }
}
