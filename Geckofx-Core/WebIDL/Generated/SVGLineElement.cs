namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGLineElement : WebIDLBase
    {
        
        public SVGLineElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports X1
        {
            get
            {
                return this.GetProperty<nsISupports>("x1");
            }
        }
        
        public nsISupports Y1
        {
            get
            {
                return this.GetProperty<nsISupports>("y1");
            }
        }
        
        public nsISupports X2
        {
            get
            {
                return this.GetProperty<nsISupports>("x2");
            }
        }
        
        public nsISupports Y2
        {
            get
            {
                return this.GetProperty<nsISupports>("y2");
            }
        }
    }
}
