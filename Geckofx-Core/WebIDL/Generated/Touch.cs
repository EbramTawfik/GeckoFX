namespace Gecko.WebIDL
{
    using System;
    
    
    public class Touch : WebIDLBase
    {
        
        public Touch(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public int Identifier
        {
            get
            {
                return this.GetProperty<int>("identifier");
            }
        }
        
        public nsISupports Target
        {
            get
            {
                return this.GetProperty<nsISupports>("target");
            }
        }
        
        public int ScreenX
        {
            get
            {
                return this.GetProperty<int>("screenX");
            }
        }
        
        public int ScreenY
        {
            get
            {
                return this.GetProperty<int>("screenY");
            }
        }
        
        public int ClientX
        {
            get
            {
                return this.GetProperty<int>("clientX");
            }
        }
        
        public int ClientY
        {
            get
            {
                return this.GetProperty<int>("clientY");
            }
        }
        
        public int PageX
        {
            get
            {
                return this.GetProperty<int>("pageX");
            }
        }
        
        public int PageY
        {
            get
            {
                return this.GetProperty<int>("pageY");
            }
        }
        
        public int RadiusX
        {
            get
            {
                return this.GetProperty<int>("radiusX");
            }
        }
        
        public int RadiusY
        {
            get
            {
                return this.GetProperty<int>("radiusY");
            }
        }
        
        public float RotationAngle
        {
            get
            {
                return this.GetProperty<float>("rotationAngle");
            }
        }
        
        public float Force
        {
            get
            {
                return this.GetProperty<float>("force");
            }
        }
    }
}
