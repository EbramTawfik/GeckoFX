namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPathData : WebIDLBase
    {
        
        public SVGAnimatedPathData(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports PathSegList
        {
            get
            {
                return this.GetProperty<nsISupports>("pathSegList");
            }
        }
        
        public nsISupports AnimatedPathSegList
        {
            get
            {
                return this.GetProperty<nsISupports>("animatedPathSegList");
            }
        }
    }
}
