namespace Gecko.WebIDL
{
    using System;
    
    
    public class DelayNode : WebIDLBase
    {
        
        public DelayNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports DelayTime
        {
            get
            {
                return this.GetProperty<nsISupports>("delayTime");
            }
        }
    }
}
