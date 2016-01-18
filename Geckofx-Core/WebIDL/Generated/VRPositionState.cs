namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRPositionState : WebIDLBase
    {
        
        public VRPositionState(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double TimeStamp
        {
            get
            {
                return this.GetProperty<double>("timeStamp");
            }
        }
        
        public bool HasPosition
        {
            get
            {
                return this.GetProperty<bool>("hasPosition");
            }
        }
        
        public nsISupports Position
        {
            get
            {
                return this.GetProperty<nsISupports>("position");
            }
        }
        
        public nsISupports LinearVelocity
        {
            get
            {
                return this.GetProperty<nsISupports>("linearVelocity");
            }
        }
        
        public nsISupports LinearAcceleration
        {
            get
            {
                return this.GetProperty<nsISupports>("linearAcceleration");
            }
        }
        
        public bool HasOrientation
        {
            get
            {
                return this.GetProperty<bool>("hasOrientation");
            }
        }
        
        public nsISupports Orientation
        {
            get
            {
                return this.GetProperty<nsISupports>("orientation");
            }
        }
        
        public nsISupports AngularVelocity
        {
            get
            {
                return this.GetProperty<nsISupports>("angularVelocity");
            }
        }
        
        public nsISupports AngularAcceleration
        {
            get
            {
                return this.GetProperty<nsISupports>("angularAcceleration");
            }
        }
    }
}
