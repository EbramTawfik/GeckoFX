namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEDiffuseLightingElement : WebIDLBase
    {
        
        public SVGFEDiffuseLightingElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports DiffuseConstant
        {
            get
            {
                return this.GetProperty<nsISupports>("diffuseConstant");
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
