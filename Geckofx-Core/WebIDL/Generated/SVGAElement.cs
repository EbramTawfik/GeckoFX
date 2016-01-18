namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAElement : WebIDLBase
    {
        
        public SVGAElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Target
        {
            get
            {
                return this.GetProperty<nsISupports>("target");
            }
        }
        
        public nsAString Download
        {
            get
            {
                return this.GetProperty<nsAString>("download");
            }
            set
            {
                this.SetProperty("download", value);
            }
        }
    }
}
