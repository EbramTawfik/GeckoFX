namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGMatrix : WebIDLBase
    {
        
        public SVGMatrix(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float A
        {
            get
            {
                return this.GetProperty<float>("a");
            }
            set
            {
                this.SetProperty("a", value);
            }
        }
        
        public float B
        {
            get
            {
                return this.GetProperty<float>("b");
            }
            set
            {
                this.SetProperty("b", value);
            }
        }
        
        public float C
        {
            get
            {
                return this.GetProperty<float>("c");
            }
            set
            {
                this.SetProperty("c", value);
            }
        }
        
        public float D
        {
            get
            {
                return this.GetProperty<float>("d");
            }
            set
            {
                this.SetProperty("d", value);
            }
        }
        
        public float E
        {
            get
            {
                return this.GetProperty<float>("e");
            }
            set
            {
                this.SetProperty("e", value);
            }
        }
        
        public float F
        {
            get
            {
                return this.GetProperty<float>("f");
            }
            set
            {
                this.SetProperty("f", value);
            }
        }
        
        public nsISupports Multiply(nsISupports secondMatrix)
        {
            return this.CallMethod<nsISupports>("multiply", secondMatrix);
        }
        
        public nsISupports Inverse()
        {
            return this.CallMethod<nsISupports>("inverse");
        }
        
        public nsISupports Translate(float x, float y)
        {
            return this.CallMethod<nsISupports>("translate", x, y);
        }
        
        public nsISupports Scale(float scaleFactor)
        {
            return this.CallMethod<nsISupports>("scale", scaleFactor);
        }
        
        public nsISupports ScaleNonUniform(float scaleFactorX, float scaleFactorY)
        {
            return this.CallMethod<nsISupports>("scaleNonUniform", scaleFactorX, scaleFactorY);
        }
        
        public nsISupports Rotate(float angle)
        {
            return this.CallMethod<nsISupports>("rotate", angle);
        }
        
        public nsISupports RotateFromVector(float x, float y)
        {
            return this.CallMethod<nsISupports>("rotateFromVector", x, y);
        }
        
        public nsISupports FlipX()
        {
            return this.CallMethod<nsISupports>("flipX");
        }
        
        public nsISupports FlipY()
        {
            return this.CallMethod<nsISupports>("flipY");
        }
        
        public nsISupports SkewX(float angle)
        {
            return this.CallMethod<nsISupports>("skewX", angle);
        }
        
        public nsISupports SkewY(float angle)
        {
            return this.CallMethod<nsISupports>("skewY", angle);
        }
    }
}
