namespace Gecko.WebIDL
{
    using System;
    
    
    public class DocumentType : WebIDLBase
    {
        
        public DocumentType(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString PublicId
        {
            get
            {
                return this.GetProperty<nsAString>("publicId");
            }
        }
        
        public nsAString SystemId
        {
            get
            {
                return this.GetProperty<nsAString>("systemId");
            }
        }
    }
}
