namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGCircleElement : WebIDLBase
    {
        
        public SVGCircleElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Cx
        {
            get
            {
                return this.GetProperty<nsISupports>("cx");
            }
        }
        
        public nsISupports Cy
        {
            get
            {
                return this.GetProperty<nsISupports>("cy");
            }
        }
        
        public nsISupports R
        {
            get
            {
                return this.GetProperty<nsISupports>("r");
            }
        }
    }
}
