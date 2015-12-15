namespace Gecko.WebIDL
{
    using System;
    
    
    public class NonDocumentTypeChildNode : WebIDLBase
    {
        
        public NonDocumentTypeChildNode(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMElement PreviousElementSibling
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("previousElementSibling");
            }
        }
        
        public nsIDOMElement NextElementSibling
        {
            get
            {
                return this.GetProperty<nsIDOMElement>("nextElementSibling");
            }
        }
    }
}
