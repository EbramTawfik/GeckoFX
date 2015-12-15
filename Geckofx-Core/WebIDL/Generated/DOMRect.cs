namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRect : WebIDLBase
    {
        
        public DOMRect(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public double X
        {
            get
            {
                return this.GetProperty<double>("x");
            }
            set
            {
                this.SetProperty("x", value);
            }
        }
        
        public double Y
        {
            get
            {
                return this.GetProperty<double>("y");
            }
            set
            {
                this.SetProperty("y", value);
            }
        }
        
        public double Width
        {
            get
            {
                return this.GetProperty<double>("width");
            }
            set
            {
                this.SetProperty("width", value);
            }
        }
        
        public double Height
        {
            get
            {
                return this.GetProperty<double>("height");
            }
            set
            {
                this.SetProperty("height", value);
            }
        }
    }
}
