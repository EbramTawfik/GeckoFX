namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEMergeNodeElement : WebIDLBase
    {
        
        public SVGFEMergeNodeElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
