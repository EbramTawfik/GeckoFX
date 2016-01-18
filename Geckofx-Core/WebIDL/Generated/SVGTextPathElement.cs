namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTextPathElement : WebIDLBase
    {
        
        public SVGTextPathElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports StartOffset
        {
            get
            {
                return this.GetProperty<nsISupports>("startOffset");
            }
        }
        
        public nsISupports Method
        {
            get
            {
                return this.GetProperty<nsISupports>("method");
            }
        }
        
        public nsISupports Spacing
        {
            get
            {
                return this.GetProperty<nsISupports>("spacing");
            }
        }
    }
}
