namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMRectReadOnly : WebIDLBase
    {
        
        public DOMRectReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double X
        {
            get
            {
                return this.GetProperty<double>("x");
            }
        }
        
        public double Y
        {
            get
            {
                return this.GetProperty<double>("y");
            }
        }
        
        public double Width
        {
            get
            {
                return this.GetProperty<double>("width");
            }
        }
        
        public double Height
        {
            get
            {
                return this.GetProperty<double>("height");
            }
        }
        
        public double Top
        {
            get
            {
                return this.GetProperty<double>("top");
            }
        }
        
        public double Right
        {
            get
            {
                return this.GetProperty<double>("right");
            }
        }
        
        public double Bottom
        {
            get
            {
                return this.GetProperty<double>("bottom");
            }
        }
        
        public double Left
        {
            get
            {
                return this.GetProperty<double>("left");
            }
        }
    }
}
