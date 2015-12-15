namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioBufferSourceNode : WebIDLBase
    {
        
        public AudioBufferSourceNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Buffer
        {
            get
            {
                return this.GetProperty<nsISupports>("buffer");
            }
            set
            {
                this.SetProperty("buffer", value);
            }
        }
        
        public nsISupports PlaybackRate
        {
            get
            {
                return this.GetProperty<nsISupports>("playbackRate");
            }
        }
        
        public nsISupports Detune
        {
            get
            {
                return this.GetProperty<nsISupports>("detune");
            }
        }
        
        public bool Loop
        {
            get
            {
                return this.GetProperty<bool>("loop");
            }
            set
            {
                this.SetProperty("loop", value);
            }
        }
        
        public double LoopStart
        {
            get
            {
                return this.GetProperty<double>("loopStart");
            }
            set
            {
                this.SetProperty("loopStart", value);
            }
        }
        
        public double LoopEnd
        {
            get
            {
                return this.GetProperty<double>("loopEnd");
            }
            set
            {
                this.SetProperty("loopEnd", value);
            }
        }
        
        public void Start(double when, double grainOffset, double grainDuration)
        {
            this.CallVoidMethod("start", when, grainOffset, grainDuration);
        }
        
        public void Stop(double when)
        {
            this.CallVoidMethod("stop", when);
        }
    }
}
