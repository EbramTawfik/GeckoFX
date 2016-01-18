namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEMorphologyElement : WebIDLBase
    {
        
        public SVGFEMorphologyElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Operator
        {
            get
            {
                return this.GetProperty<nsISupports>("operator");
            }
        }
        
        public nsISupports RadiusX
        {
            get
            {
                return this.GetProperty<nsISupports>("radiusX");
            }
        }
        
        public nsISupports RadiusY
        {
            get
            {
                return this.GetProperty<nsISupports>("radiusY");
            }
        }
    }
}
