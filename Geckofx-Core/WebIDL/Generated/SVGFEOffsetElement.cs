namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEOffsetElement : WebIDLBase
    {
        
        public SVGFEOffsetElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports In1
        {
            get
            {
                return this.GetProperty<nsISupports>("in1");
            }
        }
        
        public nsISupports Dx
        {
            get
            {
                return this.GetProperty<nsISupports>("dx");
            }
        }
        
        public nsISupports Dy
        {
            get
            {
                return this.GetProperty<nsISupports>("dy");
            }
        }
    }
}
