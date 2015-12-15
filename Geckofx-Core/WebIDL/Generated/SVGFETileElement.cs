namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFETileElement : WebIDLBase
    {
        
        public SVGFETileElement(nsISupports thisObject) : 
                base(thisObject)
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
