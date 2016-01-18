namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPreserveAspectRatio : WebIDLBase
    {
        
        public SVGAnimatedPreserveAspectRatio(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports BaseVal
        {
            get
            {
                return this.GetProperty<nsISupports>("baseVal");
            }
        }
        
        public nsISupports AnimVal
        {
            get
            {
                return this.GetProperty<nsISupports>("animVal");
            }
        }
    }
}
