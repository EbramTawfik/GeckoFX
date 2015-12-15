namespace Gecko.WebIDL
{
    using System;
    
    
    public class AnalyserNode : WebIDLBase
    {
        
        public AnalyserNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint FftSize
        {
            get
            {
                return this.GetProperty<uint>("fftSize");
            }
            set
            {
                this.SetProperty("fftSize", value);
            }
        }
        
        public uint FrequencyBinCount
        {
            get
            {
                return this.GetProperty<uint>("frequencyBinCount");
            }
        }
        
        public double MinDecibels
        {
            get
            {
                return this.GetProperty<double>("minDecibels");
            }
            set
            {
                this.SetProperty("minDecibels", value);
            }
        }
        
        public double MaxDecibels
        {
            get
            {
                return this.GetProperty<double>("maxDecibels");
            }
            set
            {
                this.SetProperty("maxDecibels", value);
            }
        }
        
        public double SmoothingTimeConstant
        {
            get
            {
                return this.GetProperty<double>("smoothingTimeConstant");
            }
            set
            {
                this.SetProperty("smoothingTimeConstant", value);
            }
        }
        
        public void GetFloatFrequencyData(IntPtr array)
        {
            this.CallVoidMethod("getFloatFrequencyData", array);
        }
        
        public void GetByteFrequencyData(IntPtr array)
        {
            this.CallVoidMethod("getByteFrequencyData", array);
        }
        
        public void GetFloatTimeDomainData(IntPtr array)
        {
            this.CallVoidMethod("getFloatTimeDomainData", array);
        }
        
        public void GetByteTimeDomainData(IntPtr array)
        {
            this.CallVoidMethod("getByteTimeDomainData", array);
        }
    }
}
