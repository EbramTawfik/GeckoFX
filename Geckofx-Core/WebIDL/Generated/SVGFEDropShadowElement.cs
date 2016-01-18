namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEDropShadowElement : WebIDLBase
    {
        
        public SVGFEDropShadowElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Dx
        {
            get
            {
                return this.GetProperty<nsISupports>("dx");
            }
        }
        
        public nsISupports Dy
        {
            get
            {
                return this.GetProperty<nsISupports>("dy");
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
