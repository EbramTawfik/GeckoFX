namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEColorMatrixElement : WebIDLBase
    {
        
        public SVGFEColorMatrixElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports In1
        {
            get
            {
                return this.GetProperty<nsISupports>("in1");
            }
        }
        
        public nsISupports Type
        {
            get
            {
                return this.GetProperty<nsISupports>("type");
            }
        }
        
        public nsISupports Values
        {
            get
            {
                return this.GetProperty<nsISupports>("values");
            }
        }
    }
}
