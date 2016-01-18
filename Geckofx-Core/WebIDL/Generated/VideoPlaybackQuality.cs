namespace Gecko.WebIDL
{
    using System;
    
    
    public class VideoPlaybackQuality : WebIDLBase
    {
        
        public VideoPlaybackQuality(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Double CreationTime
        {
            get
            {
                return this.GetProperty<Double>("creationTime");
            }
        }
        
        public uint TotalVideoFrames
        {
            get
            {
                return this.GetProperty<uint>("totalVideoFrames");
            }
        }
        
        public uint DroppedVideoFrames
        {
            get
            {
                return this.GetProperty<uint>("droppedVideoFrames");
            }
        }
        
        public uint CorruptedVideoFrames
        {
            get
            {
                return this.GetProperty<uint>("corruptedVideoFrames");
            }
        }
    }
}
