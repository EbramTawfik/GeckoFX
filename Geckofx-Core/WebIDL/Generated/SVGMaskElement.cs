namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGMaskElement : WebIDLBase
    {
        
        public SVGMaskElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports MaskUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("maskUnits");
            }
        }
        
        public nsISupports MaskContentUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("maskContentUnits");
            }
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
        
        public nsISupports Width
        {
            get
            {
                return this.GetProperty<nsISupports>("width");
            }
        }
        
        public nsISupports Height
        {
            get
            {
                return this.GetProperty<nsISupports>("height");
            }
        }
    }
}
