namespace Gecko.WebIDL
{
    using System;
    
    
    public class WaveShaperNode : WebIDLBase
    {
        
        public WaveShaperNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public IntPtr Curve
        {
            get
            {
                return this.GetProperty<IntPtr>("curve");
            }
            set
            {
                this.SetProperty("curve", value);
            }
        }
        
        public OverSampleType Oversample
        {
            get
            {
                return this.GetProperty<OverSampleType>("oversample");
            }
            set
            {
                this.SetProperty("oversample", value);
            }
        }
    }
}
