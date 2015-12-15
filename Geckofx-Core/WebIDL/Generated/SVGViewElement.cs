namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGViewElement : WebIDLBase
    {
        
        public SVGViewElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports ViewTarget
        {
            get
            {
                return this.GetProperty<nsISupports>("viewTarget");
            }
        }
    }
}
