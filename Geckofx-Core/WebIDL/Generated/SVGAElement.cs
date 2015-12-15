namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGAElement : WebIDLBase
    {
        
        public SVGAElement(nsISupports thisObject) : 
                base(thisObject)
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
