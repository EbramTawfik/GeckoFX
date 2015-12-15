namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedLengthList : WebIDLBase
    {
        
        public SVGAnimatedLengthList(nsISupports thisObject) : 
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
