namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAnimatedEnumeration : WebIDLBase
    {
        
        public SVGAnimatedEnumeration(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ushort BaseVal
        {
            get
            {
                return this.GetProperty<ushort>("baseVal");
            }
            set
            {
                this.SetProperty("baseVal", value);
            }
        }
        
        public ushort AnimVal
        {
            get
            {
                return this.GetProperty<ushort>("animVal");
            }
        }
    }
}
