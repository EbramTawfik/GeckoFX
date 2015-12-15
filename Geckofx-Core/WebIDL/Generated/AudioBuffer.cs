namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioBuffer : WebIDLBase
    {
        
        public AudioBuffer(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public float SampleRate
        {
            get
            {
                return this.GetProperty<float>("sampleRate");
            }
        }
        
        public int Length
        {
            get
            {
                return this.GetProperty<int>("length");
            }
        }
        
        public double Duration
        {
            get
            {
                return this.GetProperty<double>("duration");
            }
        }
        
        public int NumberOfChannels
        {
            get
            {
                return this.GetProperty<int>("numberOfChannels");
            }
        }
        
        public IntPtr GetChannelData(uint channel)
        {
            return this.CallMethod<IntPtr>("getChannelData", channel);
        }
        
        public void CopyFromChannel(IntPtr destination, int channelNumber, uint startInChannel)
        {
            this.CallVoidMethod("copyFromChannel", destination, channelNumber, startInChannel);
        }
        
        public void CopyToChannel(IntPtr source, int channelNumber, uint startInChannel)
        {
            this.CallVoidMethod("copyToChannel", source, channelNumber, startInChannel);
        }
    }
}
