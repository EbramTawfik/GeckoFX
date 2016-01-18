namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedNumber : WebIDLBase
    {
        
        public SVGAnimatedNumber(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float BaseVal
        {
            get
            {
                return this.GetProperty<float>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public float AnimVal
        {
            get
            {
                return this.GetProperty<float>("animVal");
            }
        }
    }
}
