namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFitToViewBox : WebIDLBase
    {
        
        public SVGFitToViewBox(nsISupports thisObject) : 
                base(thisObject)
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
