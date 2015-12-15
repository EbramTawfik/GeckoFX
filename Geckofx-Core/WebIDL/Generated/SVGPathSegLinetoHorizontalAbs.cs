namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegLinetoHorizontalAbs : WebIDLBase
    {
        
        public SVGPathSegLinetoHorizontalAbs(nsISupports thisObject) : 
                base(thisObject)
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
    }
}
