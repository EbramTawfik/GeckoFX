namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPoint : WebIDLBase
    {
        
        public SVGPoint(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public nsISupports MatrixTransform(nsISupports matrix)
        {
            return this.CallMethod<nsISupports>("matrixTransform", matrix);
        }
    }
}
