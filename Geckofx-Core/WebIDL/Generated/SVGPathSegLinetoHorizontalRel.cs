namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGPathSegLinetoHorizontalRel : WebIDLBase
    {
        
        public SVGPathSegLinetoHorizontalRel(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
    }
}
