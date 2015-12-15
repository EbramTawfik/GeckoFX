namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGClipPathElement : WebIDLBase
    {
        
        public SVGClipPathElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports ClipPathUnits
        {
            get
            {
                return this.GetProperty<nsISupports>("clipPathUnits");
            }
        }
        
        public nsISupports Transform
        {
            get
            {
                return this.GetProperty<nsISupports>("transform");
            }
        }
    }
}
