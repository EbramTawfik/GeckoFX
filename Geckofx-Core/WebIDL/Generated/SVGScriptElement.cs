namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGScriptElement : WebIDLBase
    {
        
        public SVGScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Type
        {
            get
            {
                return this.GetProperty<nsAString>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public nsAString CrossOrigin
        {
            get
            {
                return this.GetProperty<nsAString>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
    }
}
