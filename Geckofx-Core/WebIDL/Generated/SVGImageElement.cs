namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGImageElement : WebIDLBase
    {
        
        public SVGImageElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports PreserveAspectRatio
        {
            get
            {
                return this.GetProperty<nsISupports>("preserveAspectRatio");
            }
        }
    }
}
