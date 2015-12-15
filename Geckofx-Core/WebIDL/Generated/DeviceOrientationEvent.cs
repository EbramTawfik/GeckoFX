namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceOrientationEvent : WebIDLBase
    {
        
        public DeviceOrientationEvent(nsISupports thisObject) : 
                base(thisObject)
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
        
        public bool Absolute
        {
            get
            {
                return this.GetProperty<bool>("absolute");
            }
        }
        
        public void InitDeviceOrientationEvent(nsAString type, bool canBubble, bool cancelable, System.Nullable<double> alpha, System.Nullable<double> beta, System.Nullable<double> gamma, bool absolute)
        {
            this.CallVoidMethod("initDeviceOrientationEvent", type, canBubble, cancelable, alpha, beta, gamma, absolute);
        }
    }
}
