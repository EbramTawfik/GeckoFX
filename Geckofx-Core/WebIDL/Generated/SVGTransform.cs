namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTransform : WebIDLBase
    {
        
        public SVGTransform(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ushort Type
        {
            get
            {
                return this.GetProperty<ushort>("type");
            }
        }
        
        public nsISupports Matrix
        {
            get
            {
                return this.GetProperty<nsISupports>("matrix");
            }
        }
        
        public float Angle
        {
            get
            {
                return this.GetProperty<float>("angle");
            }
        }
        
        public void SetMatrix(nsISupports matrix)
        {
            this.CallVoidMethod("setMatrix", matrix);
        }
        
        public void SetTranslate(float tx, float ty)
        {
            this.CallVoidMethod("setTranslate", tx, ty);
        }
        
        public void SetScale(float sx, float sy)
        {
            this.CallVoidMethod("setScale", sx, sy);
        }
        
        public void SetRotate(float angle, float cx, float cy)
        {
            this.CallVoidMethod("setRotate", angle, cx, cy);
        }
        
        public void SetSkewX(float angle)
        {
            this.CallVoidMethod("setSkewX", angle);
        }
        
        public void SetSkewY(float angle)
        {
            this.CallVoidMethod("setSkewY", angle);
        }
    }
}
