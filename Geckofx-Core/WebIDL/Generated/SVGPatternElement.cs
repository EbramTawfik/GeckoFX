namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPatternElement : WebIDLBase
    {
        
        public SVGPatternElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports PatternUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("patternUnits");
            }
        }
        
        public nsISupports PatternContentUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("patternContentUnits");
            }
        }
        
        public nsISupports PatternTransform
        {
            get
            {
                return this.GetProperty<nsISupports>("patternTransform");
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
