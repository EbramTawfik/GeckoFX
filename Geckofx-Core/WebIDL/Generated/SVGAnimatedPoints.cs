namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPoints : WebIDLBase
    {
        
        public SVGAnimatedPoints(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Points
        {
            get
            {
                return this.GetProperty<nsISupports>("points");
            }
        }
        
        public nsISupports AnimatedPoints
        {
            get
            {
                return this.GetProperty<nsISupports>("animatedPoints");
            }
        }
    }
}
