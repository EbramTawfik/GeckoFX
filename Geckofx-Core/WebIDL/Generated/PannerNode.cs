namespace Gecko.WebIDL
{
    using System;
    
    
    public class PannerNode : WebIDLBase
    {
        
        public PannerNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public PanningModelType PanningModel
        {
            get
            {
                return this.GetProperty<PanningModelType>("panningModel");
            }
            set
            {
                this.SetProperty("panningModel", value);
            }
        }
        
        public DistanceModelType DistanceModel
        {
            get
            {
                return this.GetProperty<DistanceModelType>("distanceModel");
            }
            set
            {
                this.SetProperty("distanceModel", value);
            }
        }
        
        public double RefDistance
        {
            get
            {
                return this.GetProperty<double>("refDistance");
            }
            set
            {
                this.SetProperty("refDistance", value);
            }
        }
        
        public double MaxDistance
        {
            get
            {
                return this.GetProperty<double>("maxDistance");
            }
            set
            {
                this.SetProperty("maxDistance", value);
            }
        }
        
        public double RolloffFactor
        {
            get
            {
                return this.GetProperty<double>("rolloffFactor");
            }
            set
            {
                this.SetProperty("rolloffFactor", value);
            }
        }
        
        public double ConeInnerAngle
        {
            get
            {
                return this.GetProperty<double>("coneInnerAngle");
            }
            set
            {
                this.SetProperty("coneInnerAngle", value);
            }
        }
        
        public double ConeOuterAngle
        {
            get
            {
                return this.GetProperty<double>("coneOuterAngle");
            }
            set
            {
                this.SetProperty("coneOuterAngle", value);
            }
        }
        
        public double ConeOuterGain
        {
            get
            {
                return this.GetProperty<double>("coneOuterGain");
            }
            set
            {
                this.SetProperty("coneOuterGain", value);
            }
        }
        
        public void SetPosition(double x, double y, double z)
        {
            this.CallVoidMethod("setPosition", x, y, z);
        }
        
        public void SetOrientation(double x, double y, double z)
        {
            this.CallVoidMethod("setOrientation", x, y, z);
        }
        
        public void SetVelocity(double x, double y, double z)
        {
            this.CallVoidMethod("setVelocity", x, y, z);
        }
    }
}
