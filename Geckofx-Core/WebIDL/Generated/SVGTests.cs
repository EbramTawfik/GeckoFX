namespace Gecko.WebIDL
{
    using System;
    
    
    public class SVGTests : WebIDLBase
    {
        
        public SVGTests(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public bool HasExtension(string extension)
        {
            return this.CallMethod<bool>("hasExtension", extension);
        }
    }
}
