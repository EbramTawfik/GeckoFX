namespace Gecko.WebIDL
{
    using System;
    
    
    public class RGBColor : WebIDLBase
    {
        
        public RGBColor(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Red
        {
            get
            {
                return this.GetProperty<nsISupports>("red");
            }
        }
        
        public nsISupports Green
        {
            get
            {
                return this.GetProperty<nsISupports>("green");
            }
        }
        
        public nsISupports Blue
        {
            get
            {
                return this.GetProperty<nsISupports>("blue");
            }
        }
        
        public nsISupports Alpha
        {
            get
            {
                return this.GetProperty<nsISupports>("alpha");
            }
        }
    }
}
