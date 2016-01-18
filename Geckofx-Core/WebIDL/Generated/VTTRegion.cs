namespace Gecko.WebIDL
{
    using System;
    
    
    public class VTTRegion : WebIDLBase
    {
        
        public VTTRegion(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Width
        {
            get
            {
                return this.GetProperty<double>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public int Lines
        {
            get
            {
                return this.GetProperty<int>("lines");
            }
            set
            {
                this.SetProperty("lines", value);
            }
        }
        
        public double RegionAnchorX
        {
            get
            {
                return this.GetProperty<double>("regionAnchorX");
            }
            set
            {
                this.SetProperty("regionAnchorX", value);
            }
        }
        
        public double RegionAnchorY
        {
            get
            {
                return this.GetProperty<double>("regionAnchorY");
            }
            set
            {
                this.SetProperty("regionAnchorY", value);
            }
        }
        
        public double ViewportAnchorX
        {
            get
            {
                return this.GetProperty<double>("viewportAnchorX");
            }
            set
            {
                this.SetProperty("viewportAnchorX", value);
            }
        }
        
        public double ViewportAnchorY
        {
            get
            {
                return this.GetProperty<double>("viewportAnchorY");
            }
            set
            {
                this.SetProperty("viewportAnchorY", value);
            }
        }
        
        public string Scroll
        {
            get
            {
                return this.GetProperty<string>("scroll");
            }
            set
            {
                this.SetProperty("scroll", value);
            }
        }
    }
}
