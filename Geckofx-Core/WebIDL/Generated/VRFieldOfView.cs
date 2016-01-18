namespace Gecko.WebIDL
{
    using System;
    
    
    public class VRFieldOfView : WebIDLBase
    {
        
        public VRFieldOfView(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double UpDegrees
        {
            get
            {
                return this.GetProperty<double>("upDegrees");
            }
            set
            {
                this.SetProperty("upDegrees", value);
            }
        }
        
        public double RightDegrees
        {
            get
            {
                return this.GetProperty<double>("rightDegrees");
            }
            set
            {
                this.SetProperty("rightDegrees", value);
            }
        }
        
        public double DownDegrees
        {
            get
            {
                return this.GetProperty<double>("downDegrees");
            }
            set
            {
                this.SetProperty("downDegrees", value);
            }
        }
        
        public double LeftDegrees
        {
            get
            {
                return this.GetProperty<double>("leftDegrees");
            }
            set
            {
                this.SetProperty("leftDegrees", value);
            }
        }
    }
}
