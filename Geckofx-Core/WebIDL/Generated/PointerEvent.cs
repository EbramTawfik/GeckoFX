namespace Gecko.WebIDL
{
    using System;
    
    
    public class PointerEvent : WebIDLBase
    {
        
        public PointerEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int PointerId
        {
            get
            {
                return this.GetProperty<int>("pointerId");
            }
        }
        
        public int Width
        {
            get
            {
                return this.GetProperty<int>("width");
            }
        }
        
        public int Height
        {
            get
            {
                return this.GetProperty<int>("height");
            }
        }
        
        public float Pressure
        {
            get
            {
                return this.GetProperty<float>("pressure");
            }
        }
        
        public int TiltX
        {
            get
            {
                return this.GetProperty<int>("tiltX");
            }
        }
        
        public int TiltY
        {
            get
            {
                return this.GetProperty<int>("tiltY");
            }
        }
        
        public nsAString PointerType
        {
            get
            {
                return this.GetProperty<nsAString>("pointerType");
            }
        }
        
        public bool IsPrimary
        {
            get
            {
                return this.GetProperty<bool>("isPrimary");
            }
        }
    }
}
