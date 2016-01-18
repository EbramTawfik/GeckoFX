namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRFieldOfViewReadOnly : WebIDLBase
    {
        
        public VRFieldOfViewReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double UpDegrees
        {
            get
            {
                return this.GetProperty<double>("upDegrees");
            }
        }
        
        public double RightDegrees
        {
            get
            {
                return this.GetProperty<double>("rightDegrees");
            }
        }
        
        public double DownDegrees
        {
            get
            {
                return this.GetProperty<double>("downDegrees");
            }
        }
        
        public double LeftDegrees
        {
            get
            {
                return this.GetProperty<double>("leftDegrees");
            }
        }
    }
}
