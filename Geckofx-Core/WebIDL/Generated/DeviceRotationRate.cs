namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceRotationRate : WebIDLBase
    {
        
        public DeviceRotationRate(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public System.Nullable<double> Alpha
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("alpha");
            }
        }
        
        public System.Nullable<double> Beta
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("beta");
            }
        }
        
        public System.Nullable<double> Gamma
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("gamma");
            }
        }
    }
}
