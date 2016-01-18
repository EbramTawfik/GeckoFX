namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextMetrics : WebIDLBase
    {
        
        public TextMetrics(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public double Width
        {
            get
            {
                return this.GetProperty<double>("width");
            }
        }
    }
}
