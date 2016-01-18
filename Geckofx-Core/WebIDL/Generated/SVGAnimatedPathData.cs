namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedPathData : WebIDLBase
    {
        
        public SVGAnimatedPathData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
