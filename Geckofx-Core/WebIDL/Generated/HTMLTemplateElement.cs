namespace Gecko.WebIDL
{
    using System;
    
    
    public class HTMLTemplateElement : WebIDLBase
    {
        
        public HTMLTemplateElement(nsISupports thisObject) : 
                base(thisObject)
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
