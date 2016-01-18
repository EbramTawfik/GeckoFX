namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioBufferSourceNode : WebIDLBase
    {
        
        public AudioBufferSourceNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public void Start()
        {
            this.CallVoidMethod("start");
        }
        
        public void Start(double when)
        {
            this.CallVoidMethod("start", when);
        }
        
        public void Start(double when, double grainOffset)
        {
            this.CallVoidMethod("start", when, grainOffset);
        }
        
        public void Start(double when, double grainOffset, double grainDuration)
        {
            this.CallVoidMethod("start", when, grainOffset, grainDuration);
        }
        
        public void Stop()
        {
            this.CallVoidMethod("stop");
        }
        
        public void Stop(double when)
        {
            this.CallVoidMethod("stop", when);
        }
    }
}
