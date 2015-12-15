namespace Gecko.WebIDL
{
    using System;
    
    
    public class TextMetrics : WebIDLBase
    {
        
        public TextMetrics(nsISupports thisObject) : 
                base(thisObject)
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
