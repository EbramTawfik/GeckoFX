namespace Gecko.WebIDL
{
    using System;
    
    
    public class BiquadFilterNode : WebIDLBase
    {
        
        public BiquadFilterNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public BiquadFilterType Type
        {
            get
            {
                return this.GetProperty<BiquadFilterType>("type");
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
        
        public nsISupports Q
        {
            get
            {
                return this.GetProperty<nsISupports>("Q");
            }
        }
        
        public nsISupports Gain
        {
            get
            {
                return this.GetProperty<nsISupports>("gain");
            }
        }
        
        public void GetFrequencyResponse(IntPtr frequencyHz, IntPtr magResponse, IntPtr phaseResponse)
        {
            this.CallVoidMethod("getFrequencyResponse", frequencyHz, magResponse, phaseResponse);
        }
    }
}
