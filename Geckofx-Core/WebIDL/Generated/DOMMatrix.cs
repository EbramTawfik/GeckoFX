namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMMatrix : WebIDLBase
    {
        
        public DOMMatrix(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double A
        {
            get
            {
                return this.GetProperty<double>("a");
            }
            set
            {
                this.SetProperty("a", value);
            }
        }
        
        public double B
        {
            get
            {
                return this.GetProperty<double>("b");
            }
            set
            {
                this.SetProperty("b", value);
            }
        }
        
        public double C
        {
            get
            {
                return this.GetProperty<double>("c");
            }
            set
            {
                this.SetProperty("c", value);
            }
        }
        
        public double D
        {
            get
            {
                return this.GetProperty<double>("d");
            }
            set
            {
                this.SetProperty("d", value);
            }
        }
        
        public double E
        {
            get
            {
                return this.GetProperty<double>("e");
            }
            set
            {
                this.SetProperty("e", value);
            }
        }
        
        public double F
        {
            get
            {
                return this.GetProperty<double>("f");
            }
            set
            {
                this.SetProperty("f", value);
            }
        }
        
        public double M11
        {
            get
            {
                return this.GetProperty<double>("m11");
            }
            set
            {
                this.SetProperty("m11", value);
            }
        }
        
        public double M12
        {
            get
            {
                return this.GetProperty<double>("m12");
            }
            set
            {
                this.SetProperty("m12", value);
            }
        }
        
        public double M13
        {
            get
            {
                return this.GetProperty<double>("m13");
            }
            set
            {
                this.SetProperty("m13", value);
            }
        }
        
        public double M14
        {
            get
            {
                return this.GetProperty<double>("m14");
            }
            set
            {
                this.SetProperty("m14", value);
            }
        }
        
        public double M21
        {
            get
            {
                return this.GetProperty<double>("m21");
            }
            set
            {
                this.SetProperty("m21", value);
            }
        }
        
        public double M22
        {
            get
            {
                return this.GetProperty<double>("m22");
            }
            set
            {
                this.SetProperty("m22", value);
            }
        }
        
        public double M23
        {
            get
            {
                return this.GetProperty<double>("m23");
            }
            set
            {
                this.SetProperty("m23", value);
            }
        }
        
        public double M24
        {
            get
            {
                return this.GetProperty<double>("m24");
            }
            set
            {
                this.SetProperty("m24", value);
            }
        }
        
        public double M31
        {
            get
            {
                return this.GetProperty<double>("m31");
            }
            set
            {
                this.SetProperty("m31", value);
            }
        }
        
        public double M32
        {
            get
            {
                return this.GetProperty<double>("m32");
            }
            set
            {
                this.SetProperty("m32", value);
            }
        }
        
        public double M33
        {
            get
            {
                return this.GetProperty<double>("m33");
            }
            set
            {
                this.SetProperty("m33", value);
            }
        }
        
        public double M34
        {
            get
            {
                return this.GetProperty<double>("m34");
            }
            set
            {
                this.SetProperty("m34", value);
            }
        }
        
        public double M41
        {
            get
            {
                return this.GetProperty<double>("m41");
            }
            set
            {
                this.SetProperty("m41", value);
            }
        }
        
        public double M42
        {
            get
            {
                return this.GetProperty<double>("m42");
            }
            set
            {
                this.SetProperty("m42", value);
            }
        }
        
        public double M43
        {
            get
            {
                return this.GetProperty<double>("m43");
            }
            set
            {
                this.SetProperty("m43", value);
            }
        }
        
        public double M44
        {
            get
            {
                return this.GetProperty<double>("m44");
            }
            set
            {
                this.SetProperty("m44", value);
            }
        }
        
        public nsISupports MultiplySelf(nsISupports other)
        {
            return this.CallMethod<nsISupports>("multiplySelf", other);
        }
        
        public nsISupports PreMultiplySelf(nsISupports other)
        {
            return this.CallMethod<nsISupports>("preMultiplySelf", other);
        }
        
        public nsISupports TranslateSelf(double tx, double ty)
        {
            return this.CallMethod<nsISupports>("translateSelf", tx, ty);
        }
        
        public nsISupports TranslateSelf(double tx, double ty, double tz)
        {
            return this.CallMethod<nsISupports>("translateSelf", tx, ty, tz);
        }
        
        public nsISupports ScaleSelf(double scale)
        {
            return this.CallMethod<nsISupports>("scaleSelf", scale);
        }
        
        public nsISupports ScaleSelf(double scale, double originX)
        {
            return this.CallMethod<nsISupports>("scaleSelf", scale, originX);
        }
        
        public nsISupports ScaleSelf(double scale, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("scaleSelf", scale, originX, originY);
        }
        
        public nsISupports Scale3dSelf(double scale)
        {
            return this.CallMethod<nsISupports>("scale3dSelf", scale);
        }
        
        public nsISupports Scale3dSelf(double scale, double originX)
        {
            return this.CallMethod<nsISupports>("scale3dSelf", scale, originX);
        }
        
        public nsISupports Scale3dSelf(double scale, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("scale3dSelf", scale, originX, originY);
        }
        
        public nsISupports Scale3dSelf(double scale, double originX, double originY, double originZ)
        {
            return this.CallMethod<nsISupports>("scale3dSelf", scale, originX, originY, originZ);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX, scaleY);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX, scaleY, scaleZ);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX, scaleY, scaleZ, originX);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX, scaleY, scaleZ, originX, originY);
        }
        
        public nsISupports ScaleNonUniformSelf(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ)
        {
            return this.CallMethod<nsISupports>("scaleNonUniformSelf", scaleX, scaleY, scaleZ, originX, originY, originZ);
        }
        
        public nsISupports RotateSelf(double angle)
        {
            return this.CallMethod<nsISupports>("rotateSelf", angle);
        }
        
        public nsISupports RotateSelf(double angle, double originX)
        {
            return this.CallMethod<nsISupports>("rotateSelf", angle, originX);
        }
        
        public nsISupports RotateSelf(double angle, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("rotateSelf", angle, originX, originY);
        }
        
        public nsISupports RotateFromVectorSelf(double x, double y)
        {
            return this.CallMethod<nsISupports>("rotateFromVectorSelf", x, y);
        }
        
        public nsISupports RotateAxisAngleSelf(double x, double y, double z, double angle)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngleSelf", x, y, z, angle);
        }
        
        public nsISupports SkewXSelf(double sx)
        {
            return this.CallMethod<nsISupports>("skewXSelf", sx);
        }
        
        public nsISupports SkewYSelf(double sy)
        {
            return this.CallMethod<nsISupports>("skewYSelf", sy);
        }
        
        public nsISupports InvertSelf()
        {
            return this.CallMethod<nsISupports>("invertSelf");
        }
        
        public nsISupports SetMatrixValue(string transformList)
        {
            return this.CallMethod<nsISupports>("setMatrixValue", transformList);
        }
    }
}
