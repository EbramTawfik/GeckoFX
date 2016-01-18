namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFETileElement : WebIDLBase
    {
        
        public SVGFETileElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
