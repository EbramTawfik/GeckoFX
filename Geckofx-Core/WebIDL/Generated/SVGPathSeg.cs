namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSeg : WebIDLBase
    {
        
        public SVGPathSeg(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort PathSegType
        {
            get
            {
                return this.GetProperty<ushort>("pathSegType");
            }
        }
        
        public nsAString PathSegTypeAsLetter
        {
            get
            {
                return this.GetProperty<nsAString>("pathSegTypeAsLetter");
            }
        }
    }
}
