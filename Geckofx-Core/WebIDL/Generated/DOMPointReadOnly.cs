namespace Gecko.WebIDL
{
    using System;
    
    
    public class DOMPointReadOnly : WebIDLBase
    {
        
        public DOMPointReadOnly(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public double Z
        {
            get
            {
                return this.GetProperty<double>("z");
            }
        }
        
        public double W
        {
            get
            {
                return this.GetProperty<double>("w");
            }
        }
    }
}
