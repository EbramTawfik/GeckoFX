namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGRectElement : WebIDLBase
    {
        
        public SVGRectElement(nsISupports thisObject) : 
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
