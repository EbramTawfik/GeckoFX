namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGRect : WebIDLBase
    {
        
        public SVGRect(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public float Width
        {
            get
            {
                return this.GetProperty<float>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public float Height
        {
            get
            {
                return this.GetProperty<float>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
    }
}
