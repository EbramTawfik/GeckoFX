namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFitToViewBox : WebIDLBase
    {
        
        public SVGFitToViewBox(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports ViewBox
        {
            get
            {
                return this.GetProperty<nsISupports>("viewBox");
            }
        }
        
        public nsISupports PreserveAspectRatio
        {
            get
            {
                return this.GetProperty<nsISupports>("preserveAspectRatio");
            }
        }
    }
}
