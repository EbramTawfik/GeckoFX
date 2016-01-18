namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTextPositioningElement : WebIDLBase
    {
        
        public SVGTextPositioningElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports X
        {
            get
            {
                return this.GetProperty<nsISupports>("x");
            }
        }
        
        public nsISupports Y
        {
            get
            {
                return this.GetProperty<nsISupports>("y");
            }
        }
        
        public nsISupports Dx
        {
            get
            {
                return this.GetProperty<nsISupports>("dx");
            }
        }
        
        public nsISupports Dy
        {
            get
            {
                return this.GetProperty<nsISupports>("dy");
            }
        }
        
        public nsISupports Rotate
        {
            get
            {
                return this.GetProperty<nsISupports>("rotate");
            }
        }
    }
}
