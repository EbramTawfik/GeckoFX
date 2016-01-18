namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGCircleElement : WebIDLBase
    {
        
        public SVGCircleElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
