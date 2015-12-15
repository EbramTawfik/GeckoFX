namespace Gecko.WebIDL
{
    using System;
    
    
    public class StereoPannerNode : WebIDLBase
    {
        
        public StereoPannerNode(nsISupports thisObject) : 
                base(thisObject)
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
