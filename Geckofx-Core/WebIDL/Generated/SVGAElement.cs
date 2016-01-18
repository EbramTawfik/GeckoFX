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
        
        public string Download
        {
            get
            {
                return this.GetProperty<string>("download");
            }
            set
            {
                this.SetProperty("download", value);
            }
        }
    }
}
