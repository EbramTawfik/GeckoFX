namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFilterPrimitiveStandardAttributes : WebIDLBase
    {
        
        public SVGFilterPrimitiveStandardAttributes(nsISupports thisObject) : 
                base(thisObject)
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
        
        public nsISupports Result
        {
            get
            {
                return this.GetProperty<nsISupports>("result");
            }
        }
    }
}
