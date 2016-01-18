namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEConvolveMatrixElement : WebIDLBase
    {
        
        public SVGFEConvolveMatrixElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports In1
        {
            get
            {
                return this.GetProperty<nsISupports>("in1");
            }
        }
        
        public nsISupports OrderX
        {
            get
            {
                return this.GetProperty<nsISupports>("orderX");
            }
        }
        
        public nsISupports OrderY
        {
            get
            {
                return this.GetProperty<nsISupports>("orderY");
            }
        }
        
        public nsISupports KernelMatrix
        {
            get
            {
                return this.GetProperty<nsISupports>("kernelMatrix");
            }
        }
        
        public nsISupports Divisor
        {
            get
            {
                return this.GetProperty<nsISupports>("divisor");
            }
        }
        
        public nsISupports Bias
        {
            get
            {
                return this.GetProperty<nsISupports>("bias");
            }
        }
        
        public nsISupports TargetX
        {
            get
            {
                return this.GetProperty<nsISupports>("targetX");
            }
        }
        
        public nsISupports TargetY
        {
            get
            {
                return this.GetProperty<nsISupports>("targetY");
            }
        }
        
        public nsISupports EdgeMode
        {
            get
            {
                return this.GetProperty<nsISupports>("edgeMode");
            }
        }
        
        public nsISupports KernelUnitLengthX
        {
            get
            {
                return this.GetProperty<nsISupports>("kernelUnitLengthX");
            }
        }
        
        public nsISupports KernelUnitLengthY
        {
            get
            {
                return this.GetProperty<nsISupports>("kernelUnitLengthY");
            }
        }
        
        public nsISupports PreserveAlpha
        {
            get
            {
                return this.GetProperty<nsISupports>("preserveAlpha");
            }
        }
    }
}
