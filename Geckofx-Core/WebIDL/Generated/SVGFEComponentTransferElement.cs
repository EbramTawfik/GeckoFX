namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEComponentTransferElement : WebIDLBase
    {
        
        public SVGFEComponentTransferElement(nsISupports thisObject) : 
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
