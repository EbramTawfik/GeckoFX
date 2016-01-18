namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGDocument : WebIDLBase
    {
        
        public SVGDocument(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString Domain
        {
            get
            {
                return this.GetProperty<nsAString>("domain");
            }
        }
        
        public nsISupports RootElement
        {
            get
            {
                return this.GetProperty<nsISupports>("rootElement");
            }
        }
    }
}
