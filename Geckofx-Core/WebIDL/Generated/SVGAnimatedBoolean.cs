namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedBoolean : WebIDLBase
    {
        
        public SVGAnimatedBoolean(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool BaseVal
        {
            get
            {
                return this.GetProperty<bool>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public bool AnimVal
        {
            get
            {
                return this.GetProperty<bool>("animVal");
            }
        }
    }
}
