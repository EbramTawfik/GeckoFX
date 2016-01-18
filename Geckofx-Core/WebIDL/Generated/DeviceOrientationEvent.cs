namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceOrientationEvent : WebIDLBase
    {
        
        public DeviceOrientationEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public bool Absolute
        {
            get
            {
                return this.GetProperty<bool>("absolute");
            }
        }
        
        public void InitDeviceOrientationEvent(string type, bool canBubble, bool cancelable, System.Nullable<double> alpha, System.Nullable<double> beta, System.Nullable<double> gamma, bool absolute)
        {
            this.CallVoidMethod("initDeviceOrientationEvent", type, canBubble, cancelable, alpha, beta, gamma, absolute);
        }
    }
}
