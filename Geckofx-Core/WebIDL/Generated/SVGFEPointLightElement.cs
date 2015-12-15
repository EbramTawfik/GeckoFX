namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEPointLightElement : WebIDLBase
    {
        
        public SVGFEPointLightElement(nsISupports thisObject) : 
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
        
        public nsISupports Z
        {
            get
            {
                return this.GetProperty<nsISupports>("z");
            }
        }
    }
}
