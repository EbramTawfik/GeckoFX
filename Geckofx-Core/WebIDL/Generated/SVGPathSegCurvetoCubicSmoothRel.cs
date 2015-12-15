namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegCurvetoCubicSmoothRel : WebIDLBase
    {
        
        public SVGPathSegCurvetoCubicSmoothRel(nsISupports thisObject) : 
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
        
        public float X2
        {
            get
            {
                return this.GetProperty<float>("x2");
            }
            set
            {
                this.SetProperty("x2", value);
            }
        }
        
        public float Y2
        {
            get
            {
                return this.GetProperty<float>("y2");
            }
            set
            {
                this.SetProperty("y2", value);
            }
        }
    }
}
