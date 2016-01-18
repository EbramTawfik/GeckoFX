namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGGradientElement : WebIDLBase
    {
        
        public SVGGradientElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports GradientUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("gradientUnits");
            }
        }
        
        public nsISupports GradientTransform
        {
            get
            {
                return this.GetProperty<nsISupports>("gradientTransform");
            }
        }
        
        public nsISupports SpreadMethod
        {
            get
            {
                return this.GetProperty<nsISupports>("spreadMethod");
            }
        }
    }
}
