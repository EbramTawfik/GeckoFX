namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegArcAbs : WebIDLBase
    {
        
        public SVGPathSegArcAbs(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public float X
        {
            get
            {
                return this.GetProperty<float>("x");
            }
            set
            {
                this.SetProperty("x", value);
            }
        }
        
        public float Y
        {
            get
            {
                return this.GetProperty<float>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
        
        public float R1
        {
            get
            {
                return this.GetProperty<float>("r1");
            }
            set
            {
                this.SetProperty("r1", value);
            }
        }
        
        public float R2
        {
            get
            {
                return this.GetProperty<float>("r2");
            }
            set
            {
                this.SetProperty("r2", value);
            }
        }
        
        public float Angle
        {
            get
            {
                return this.GetProperty<float>("angle");
            }
            set
            {
                this.SetProperty("angle", value);
            }
        }
        
        public bool LargeArcFlag
        {
            get
            {
                return this.GetProperty<bool>("largeArcFlag");
            }
            set
            {
                this.SetProperty("largeArcFlag", value);
            }
        }
        
        public bool SweepFlag
        {
            get
            {
                return this.GetProperty<bool>("sweepFlag");
            }
            set
            {
                this.SetProperty("sweepFlag", value);
            }
        }
    }
}
