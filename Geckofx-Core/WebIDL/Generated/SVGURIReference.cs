namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGURIReference : WebIDLBase
    {
        
        public SVGURIReference(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Href
        {
            get
            {
                return this.GetProperty<nsISupports>("href");
            }
        }
    }
}
