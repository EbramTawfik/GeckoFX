namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPreserveAspectRatio : WebIDLBase
    {
        
        public SVGAnimatedPreserveAspectRatio(nsISupports thisObject) : 
                base(thisObject)
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
