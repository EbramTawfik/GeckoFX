namespace Gecko.WebIDL
{
    using System;
    
    
    public class BatteryManager : WebIDLBase
    {
        
        public BatteryManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Charging
        {
            get
            {
                return this.GetProperty<bool>("charging");
            }
        }
        
        public double ChargingTime
        {
            get
            {
                return this.GetProperty<double>("chargingTime");
            }
        }
        
        public double DischargingTime
        {
            get
            {
                return this.GetProperty<double>("dischargingTime");
            }
        }
        
        public double Level
        {
            get
            {
                return this.GetProperty<double>("level");
            }
        }
    }
}
