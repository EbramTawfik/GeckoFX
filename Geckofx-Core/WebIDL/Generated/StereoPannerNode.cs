namespace Gecko.WebIDL
{
    using System;
    
    
    public class StereoPannerNode : WebIDLBase
    {
        
        public StereoPannerNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Pan
        {
            get
            {
                return this.GetProperty<nsISupports>("pan");
            }
        }
    }
}
