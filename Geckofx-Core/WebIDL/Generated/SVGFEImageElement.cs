namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEImageElement : WebIDLBase
    {
        
        public SVGFEImageElement(nsISupports thisObject) : 
                base(thisObject)
        {
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
