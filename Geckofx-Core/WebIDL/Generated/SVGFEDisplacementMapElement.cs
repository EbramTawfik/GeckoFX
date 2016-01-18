namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEDisplacementMapElement : WebIDLBase
    {
        
        public SVGFEDisplacementMapElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports Scale
        {
            get
            {
                return this.GetProperty<nsISupports>("scale");
            }
        }
        
        public nsISupports XChannelSelector
        {
            get
            {
                return this.GetProperty<nsISupports>("xChannelSelector");
            }
        }
        
        public nsISupports YChannelSelector
        {
            get
            {
                return this.GetProperty<nsISupports>("yChannelSelector");
            }
        }
    }
}
