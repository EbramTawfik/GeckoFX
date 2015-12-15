namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceLightEvent : WebIDLBase
    {
        
        public DeviceLightEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
        }
    }
}
