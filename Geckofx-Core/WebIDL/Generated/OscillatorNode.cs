namespace Gecko.WebIDL
{
    using System;
    
    
    public class OscillatorNode : WebIDLBase
    {
        
        public OscillatorNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public OscillatorType Type
        {
            get
            {
                return this.GetProperty<OscillatorType>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public nsISupports Frequency
        {
            get
            {
                return this.GetProperty<nsISupports>("frequency");
            }
        }
        
        public nsISupports Detune
        {
            get
            {
                return this.GetProperty<nsISupports>("detune");
            }
        }
        
        public void Start(double when)
        {
            this.CallVoidMethod("start", when);
        }
        
        public void Stop(double when)
        {
            this.CallVoidMethod("stop", when);
        }
        
        public void SetPeriodicWave(nsISupports periodicWave)
        {
            this.CallVoidMethod("setPeriodicWave", periodicWave);
        }
    }
}
