namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceAcceleration : WebIDLBase
    {
        
        public DeviceAcceleration(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public System.Nullable<double> X
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("x");
            }
        }
        
        public System.Nullable<double> Y
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("y");
            }
        }
        
        public System.Nullable<double> Z
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("z");
            }
        }
    }
}
