namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFilterElement : WebIDLBase
    {
        
        public SVGFilterElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports FilterUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("filterUnits");
            }
        }
        
        public nsISupports PrimitiveUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("primitiveUnits");
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
