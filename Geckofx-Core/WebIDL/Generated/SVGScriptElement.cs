namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGScriptElement : WebIDLBase
    {
        
        public SVGScriptElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Type
        {
            get
            {
                return this.GetProperty<string>("type");
            }
            set
            {
                this.SetProperty("type", value);
            }
        }
        
        public string CrossOrigin
        {
            get
            {
                return this.GetProperty<string>("crossOrigin");
            }
            set
            {
                this.SetProperty("crossOrigin", value);
            }
        }
    }
}
