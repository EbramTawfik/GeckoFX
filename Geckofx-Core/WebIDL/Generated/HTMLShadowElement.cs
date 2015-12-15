namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLShadowElement : WebIDLBase
    {
        
        public HTMLShadowElement(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports OlderShadowRoot
        {
            get
            {
                return this.GetProperty<nsISupports>("olderShadowRoot");
            }
        }
    }
}
