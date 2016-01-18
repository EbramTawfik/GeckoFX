namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceProximityEvent : WebIDLBase
    {
        
        public DeviceProximityEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Value
        {
            get
            {
                return this.GetProperty<double>("value");
            }
        }
        
        public double Min
        {
            get
            {
                return this.GetProperty<double>("min");
            }
        }
        
        public double Max
        {
            get
            {
                return this.GetProperty<double>("max");
            }
        }
    }
}
