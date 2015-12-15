namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEDistantLightElement : WebIDLBase
    {
        
        public SVGFEDistantLightElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Azimuth
        {
            get
            {
                return this.GetProperty<nsISupports>("azimuth");
            }
        }
        
        public nsISupports Elevation
        {
            get
            {
                return this.GetProperty<nsISupports>("elevation");
            }
        }
    }
}
