namespace Gecko.WebIDL
{
    using System;
    
    
    public class DeviceMotionEvent : WebIDLBase
    {
        
        public DeviceMotionEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Acceleration
        {
            get
            {
                return this.GetProperty<nsISupports>("acceleration");
            }
        }
        
        public nsISupports AccelerationIncludingGravity
        {
            get
            {
                return this.GetProperty<nsISupports>("accelerationIncludingGravity");
            }
        }
        
        public nsISupports RotationRate
        {
            get
            {
                return this.GetProperty<nsISupports>("rotationRate");
            }
        }
        
        public System.Nullable<double> Interval
        {
            get
            {
                return this.GetProperty<System.Nullable<double>>("interval");
            }
        }
        
        public void InitDeviceMotionEvent(nsAString type, bool canBubble, bool cancelable, object acceleration, object accelerationIncludingGravity, object rotationRate, System.Nullable<double> interval)
        {
            this.CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration, accelerationIncludingGravity, rotationRate, interval);
        }
    }
}
