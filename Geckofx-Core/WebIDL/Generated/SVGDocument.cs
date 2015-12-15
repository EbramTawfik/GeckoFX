namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGDocument : WebIDLBase
    {
        
        public SVGDocument(nsISupports thisObject) : 
                base(thisObject)
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
