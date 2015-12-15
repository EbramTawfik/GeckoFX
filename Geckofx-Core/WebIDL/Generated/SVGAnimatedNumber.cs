namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedNumber : WebIDLBase
    {
        
        public SVGAnimatedNumber(nsISupports thisObject) : 
                base(thisObject)
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
