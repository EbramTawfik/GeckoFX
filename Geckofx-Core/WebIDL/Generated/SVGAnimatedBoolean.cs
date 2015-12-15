namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedBoolean : WebIDLBase
    {
        
        public SVGAnimatedBoolean(nsISupports thisObject) : 
                base(thisObject)
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
