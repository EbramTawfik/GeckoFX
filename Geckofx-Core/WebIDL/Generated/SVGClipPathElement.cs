namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGClipPathElement : WebIDLBase
    {
        
        public SVGClipPathElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
