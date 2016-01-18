namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGEllipseElement : WebIDLBase
    {
        
        public SVGEllipseElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Rx
        {
            get
            {
                return this.GetProperty<nsISupports>("rx");
            }
        }
        
        public nsISupports Ry
        {
            get
            {
                return this.GetProperty<nsISupports>("ry");
            }
        }
    }
}
