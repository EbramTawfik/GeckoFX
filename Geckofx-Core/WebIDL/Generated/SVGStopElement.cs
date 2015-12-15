namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGStopElement : WebIDLBase
    {
        
        public SVGStopElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Offset
        {
            get
            {
                return this.GetProperty<nsISupports>("offset");
            }
        }
    }
}
