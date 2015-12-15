namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMMatrixReadOnly : WebIDLBase
    {
        
        public DOMMatrixReadOnly(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public double A
        {
            get
            {
                return this.GetProperty<double>("a");
            }
        }
        
        public double B
        {
            get
            {
                return this.GetProperty<double>("b");
            }
        }
        
        public double C
        {
            get
            {
                return this.GetProperty<double>("c");
            }
        }
        
        public double D
        {
            get
            {
                return this.GetProperty<double>("d");
            }
        }
        
        public double E
        {
            get
            {
                return this.GetProperty<double>("e");
            }
        }
        
        public double F
        {
            get
            {
                return this.GetProperty<double>("f");
            }
        }
        
        public double M11
        {
            get
            {
                return this.GetProperty<double>("m11");
            }
        }
        
        public double M12
        {
            get
            {
                return this.GetProperty<double>("m12");
            }
        }
        
        public double M13
        {
            get
            {
                return this.GetProperty<double>("m13");
            }
        }
        
        public double M14
        {
            get
            {
                return this.GetProperty<double>("m14");
            }
        }
        
        public double M21
        {
            get
            {
                return this.GetProperty<double>("m21");
            }
        }
        
        public double M22
        {
            get
            {
                return this.GetProperty<double>("m22");
            }
        }
        
        public double M23
        {
            get
            {
                return this.GetProperty<double>("m23");
            }
        }
        
        public double M24
        {
            get
            {
                return this.GetProperty<double>("m24");
            }
        }
        
        public double M31
        {
            get
            {
                return this.GetProperty<double>("m31");
            }
        }
        
        public double M32
        {
            get
            {
                return this.GetProperty<double>("m32");
            }
        }
        
        public double M33
        {
            get
            {
                return this.GetProperty<double>("m33");
            }
        }
        
        public double M34
        {
            get
            {
                return this.GetProperty<double>("m34");
            }
        }
        
        public double M41
        {
            get
            {
                return this.GetProperty<double>("m41");
            }
        }
        
        public double M42
        {
            get
            {
                return this.GetProperty<double>("m42");
            }
        }
        
        public double M43
        {
            get
            {
                return this.GetProperty<double>("m43");
            }
        }
        
        public double M44
        {
            get
            {
                return this.GetProperty<double>("m44");
            }
        }
        
        public bool Is2D
        {
            get
            {
                return this.GetProperty<bool>("is2D");
            }
        }
        
        public bool Identity
        {
            get
            {
                return this.GetProperty<bool>("identity");
            }
        }
        
        public nsISupports Translate(double tx, double ty, double tz)
        {
            return this.CallMethod<nsISupports>("translate", tx, ty, tz);
        }
        
        public nsISupports Scale(double scale, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("scale", scale, originX, originY);
        }
        
        public nsISupports Scale3d(double scale, double originX, double originY, double originZ)
        {
            return this.CallMethod<nsISupports>("scale3d", scale, originX, originY, originZ);
        }
        
        public nsISupports ScaleNonUniform(double scaleX, double scaleY, double scaleZ, double originX, double originY, double originZ)
        {
            return this.CallMethod<nsISupports>("scaleNonUniform", scaleX, scaleY, scaleZ, originX, originY, originZ);
        }
        
        public nsISupports Rotate(double angle, double originX, double originY)
        {
            return this.CallMethod<nsISupports>("rotate", angle, originX, originY);
        }
        
        public nsISupports RotateFromVector(double x, double y)
        {
            return this.CallMethod<nsISupports>("rotateFromVector", x, y);
        }
        
        public nsISupports RotateAxisAngle(double x, double y, double z, double angle)
        {
            return this.CallMethod<nsISupports>("rotateAxisAngle", x, y, z, angle);
        }
        
        public nsISupports SkewX(double sx)
        {
            return this.CallMethod<nsISupports>("skewX", sx);
        }
        
        public nsISupports SkewY(double sy)
        {
            return this.CallMethod<nsISupports>("skewY", sy);
        }
        
        public nsISupports Multiply(nsISupports other)
        {
            return this.CallMethod<nsISupports>("multiply", other);
        }
        
        public nsISupports FlipX()
        {
            return this.CallMethod<nsISupports>("flipX");
        }
        
        public nsISupports FlipY()
        {
            return this.CallMethod<nsISupports>("flipY");
        }
        
        public nsISupports Inverse()
        {
            return this.CallMethod<nsISupports>("inverse");
        }
        
        public nsISupports TransformPoint(object point)
        {
            return this.CallMethod<nsISupports>("transformPoint", point);
        }
        
        public IntPtr ToFloat32Array()
        {
            return this.CallMethod<IntPtr>("toFloat32Array");
        }
        
        public IntPtr ToFloat64Array()
        {
            return this.CallMethod<IntPtr>("toFloat64Array");
        }
    }
}
