namespace Gecko.WebIDL
{
    using System;
    
    
    public class AudioContext : WebIDLBase
    {
        
        public AudioContext(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Destination
        {
            get
            {
                return this.GetProperty<nsISupports>("destination");
            }
        }
        
        public float SampleRate
        {
            get
            {
                return this.GetProperty<float>("sampleRate");
            }
        }
        
        public double CurrentTime
        {
            get
            {
                return this.GetProperty<double>("currentTime");
            }
        }
        
        public nsISupports Listener
        {
            get
            {
                return this.GetProperty<nsISupports>("listener");
            }
        }
        
        public AudioContextState State
        {
            get
            {
                return this.GetProperty<AudioContextState>("state");
            }
        }
        
        public Promise Suspend()
        {
            return this.CallMethod<Promise>("suspend");
        }
        
        public Promise Resume()
        {
            return this.CallMethod<Promise>("resume");
        }
        
        public Promise Close()
        {
            return this.CallMethod<Promise>("close");
        }
        
        public nsISupports CreateBuffer(uint numberOfChannels, uint length, float sampleRate)
        {
            return this.CallMethod<nsISupports>("createBuffer", numberOfChannels, length, sampleRate);
        }
        
        public nsISupports CreateBufferSource()
        {
            return this.CallMethod<nsISupports>("createBufferSource");
        }
        
        public nsISupports CreateMediaStreamDestination()
        {
            return this.CallMethod<nsISupports>("createMediaStreamDestination");
        }
        
        public nsISupports CreateScriptProcessor(uint bufferSize, uint numberOfInputChannels, uint numberOfOutputChannels)
        {
            return this.CallMethod<nsISupports>("createScriptProcessor", bufferSize, numberOfInputChannels, numberOfOutputChannels);
        }
        
        public nsISupports CreateStereoPanner()
        {
            return this.CallMethod<nsISupports>("createStereoPanner");
        }
        
        public nsISupports CreateAnalyser()
        {
            return this.CallMethod<nsISupports>("createAnalyser");
        }
        
        public nsISupports CreateMediaElementSource(nsISupports mediaElement)
        {
            return this.CallMethod<nsISupports>("createMediaElementSource", mediaElement);
        }
        
        public nsISupports CreateMediaStreamSource(nsISupports mediaStream)
        {
            return this.CallMethod<nsISupports>("createMediaStreamSource", mediaStream);
        }
        
        public nsISupports CreateGain()
        {
            return this.CallMethod<nsISupports>("createGain");
        }
        
        public nsISupports CreateDelay(double maxDelayTime)
        {
            return this.CallMethod<nsISupports>("createDelay", maxDelayTime);
        }
        
        public nsISupports CreateBiquadFilter()
        {
            return this.CallMethod<nsISupports>("createBiquadFilter");
        }
        
        public nsISupports CreateWaveShaper()
        {
            return this.CallMethod<nsISupports>("createWaveShaper");
        }
        
        public nsISupports CreatePanner()
        {
            return this.CallMethod<nsISupports>("createPanner");
        }
        
        public nsISupports CreateConvolver()
        {
            return this.CallMethod<nsISupports>("createConvolver");
        }
        
        public nsISupports CreateChannelSplitter(uint numberOfOutputs)
        {
            return this.CallMethod<nsISupports>("createChannelSplitter", numberOfOutputs);
        }
        
        public nsISupports CreateChannelMerger(uint numberOfInputs)
        {
            return this.CallMethod<nsISupports>("createChannelMerger", numberOfInputs);
        }
        
        public nsISupports CreateDynamicsCompressor()
        {
            return this.CallMethod<nsISupports>("createDynamicsCompressor");
        }
        
        public nsISupports CreateOscillator()
        {
            return this.CallMethod<nsISupports>("createOscillator");
        }
        
        public nsISupports CreatePeriodicWave(IntPtr real, IntPtr imag)
        {
            return this.CallMethod<nsISupports>("createPeriodicWave", real, imag);
        }
        
        public AudioChannel MozAudioChannelType
        {
            get
            {
                return this.GetProperty<AudioChannel>("mozAudioChannelType");
            }
        }
        
        public AudioChannel TestAudioChannelInAudioNodeStream()
        {
            return this.CallMethod<AudioChannel>("testAudioChannelInAudioNodeStream");
        }
    }
}
