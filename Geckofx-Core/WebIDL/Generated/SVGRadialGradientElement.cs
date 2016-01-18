namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGRadialGradientElement : WebIDLBase
    {
        
        public SVGRadialGradientElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Fx
        {
            get
            {
                return this.GetProperty<nsISupports>("fx");
            }
        }
        
        public nsISupports Fy
        {
            get
            {
                return this.GetProperty<nsISupports>("fy");
            }
        }
    }
}
