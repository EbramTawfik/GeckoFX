namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegCurvetoQuadraticRel : WebIDLBase
    {
        
        public SVGPathSegCurvetoQuadraticRel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public float X1
        {
            get
            {
                return this.GetProperty<float>("x1");
            }
            set
            {
                this.SetProperty("x1", value);
            }
        }
        
        public float Y1
        {
            get
            {
                return this.GetProperty<float>("y1");
            }
            set
            {
                this.SetProperty("y1", value);
            }
        }
    }
}
