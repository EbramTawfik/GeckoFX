namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFECompositeElement : WebIDLBase
    {
        
        public SVGFECompositeElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports In2
        {
            get
            {
                return this.GetProperty<nsISupports>("in2");
            }
        }
        
        public nsISupports Operator
        {
            get
            {
                return this.GetProperty<nsISupports>("operator");
            }
        }
        
        public nsISupports K1
        {
            get
            {
                return this.GetProperty<nsISupports>("k1");
            }
        }
        
        public nsISupports K2
        {
            get
            {
                return this.GetProperty<nsISupports>("k2");
            }
        }
        
        public nsISupports K3
        {
            get
            {
                return this.GetProperty<nsISupports>("k3");
            }
        }
        
        public nsISupports K4
        {
            get
            {
                return this.GetProperty<nsISupports>("k4");
            }
        }
    }
}
