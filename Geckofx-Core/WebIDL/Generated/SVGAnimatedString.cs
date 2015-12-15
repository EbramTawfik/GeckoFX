namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedString : WebIDLBase
    {
        
        public SVGAnimatedString(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString BaseVal
        {
            get
            {
                return this.GetProperty<nsAString>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public nsAString AnimVal
        {
            get
            {
                return this.GetProperty<nsAString>("animVal");
            }
        }
    }
}
