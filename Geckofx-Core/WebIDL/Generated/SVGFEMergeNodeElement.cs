namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGFEMergeNodeElement : WebIDLBase
    {
        
        public SVGFEMergeNodeElement(nsISupports thisObject) : 
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
