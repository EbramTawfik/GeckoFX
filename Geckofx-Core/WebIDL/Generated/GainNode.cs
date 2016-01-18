namespace Gecko.WebIDL
{
    using System;
    
    
    public class GainNode : WebIDLBase
    {
        
        public GainNode(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
