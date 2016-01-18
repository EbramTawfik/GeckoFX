namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGNumber : WebIDLBase
    {
        
        public SVGNumber(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public float Value
        {
            get
            {
                return this.GetProperty<float>("value");
            }
            set
            {
                this.SetProperty("value", value);
            }
        }
    }
}
