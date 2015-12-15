namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTests : WebIDLBase
    {
        
        public SVGTests(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports RequiredFeatures
        {
            get
            {
                return this.GetProperty<nsISupports>("requiredFeatures");
            }
        }
        
        public nsISupports RequiredExtensions
        {
            get
            {
                return this.GetProperty<nsISupports>("requiredExtensions");
            }
        }
        
        public nsISupports SystemLanguage
        {
            get
            {
                return this.GetProperty<nsISupports>("systemLanguage");
            }
        }
        
        public bool HasExtension(nsAString extension)
        {
            return this.CallMethod<bool>("hasExtension", extension);
        }
    }
}
