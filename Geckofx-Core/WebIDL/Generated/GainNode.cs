namespace Gecko.WebIDL
{
    using System;
    
    
    public class GainNode : WebIDLBase
    {
        
        public GainNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Gain
        {
            get
            {
                return this.GetProperty<nsISupports>("gain");
            }
        }
    }
}
