namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFESpecularLightingElement : WebIDLBase
    {
        
        public SVGFESpecularLightingElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports SurfaceScale
        {
            get
            {
                return this.GetProperty<nsISupports>("surfaceScale");
            }
        }
        
        public nsISupports SpecularConstant
        {
            get
            {
                return this.GetProperty<nsISupports>("specularConstant");
            }
        }
        
        public nsISupports SpecularExponent
        {
            get
            {
                return this.GetProperty<nsISupports>("specularExponent");
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
    }
}
