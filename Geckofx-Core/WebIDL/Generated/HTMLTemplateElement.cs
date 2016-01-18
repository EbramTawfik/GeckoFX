namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTemplateElement : WebIDLBase
    {
        
        public HTMLTemplateElement(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports Content
        {
            get
            {
                return this.GetProperty<nsISupports>("content");
            }
        }
    }
}
