namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEGaussianBlurElement : WebIDLBase
    {
        
        public SVGFEGaussianBlurElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports In1
        {
            get
            {
                return this.GetProperty<nsISupports>("in1");
            }
        }
        
        public nsISupports StdDeviationX
        {
            get
            {
                return this.GetProperty<nsISupports>("stdDeviationX");
            }
        }
        
        public nsISupports StdDeviationY
        {
            get
            {
                return this.GetProperty<nsISupports>("stdDeviationY");
            }
        }
        
        public void SetStdDeviation(float stdDeviationX, float stdDeviationY)
        {
            this.CallVoidMethod("setStdDeviation", stdDeviationX, stdDeviationY);
        }
    }
}
