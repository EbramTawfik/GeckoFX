namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEBlendElement : WebIDLBase
    {
        
        public SVGFEBlendElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports In2
        {
            get
            {
                return this.GetProperty<nsISupports>("in2");
            }
        }
        
        public nsISupports Mode
        {
            get
            {
                return this.GetProperty<nsISupports>("mode");
            }
        }
    }
}
