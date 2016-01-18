namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedString : WebIDLBase
    {
        
        public SVGAnimatedString(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string BaseVal
        {
            get
            {
                return this.GetProperty<string>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public string AnimVal
        {
            get
            {
                return this.GetProperty<string>("animVal");
            }
        }
    }
}
