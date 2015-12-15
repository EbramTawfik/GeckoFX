namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPoints : WebIDLBase
    {
        
        public SVGAnimatedPoints(nsISupports thisObject) : 
                base(thisObject)
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
