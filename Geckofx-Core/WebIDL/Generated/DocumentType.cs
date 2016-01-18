namespace Gecko.WebIDL
{
    using System;
    
    
    public class DocumentType : WebIDLBase
    {
        
        public DocumentType(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string PublicId
        {
            get
            {
                return this.GetProperty<string>("publicId");
            }
        }
        
        public string SystemId
        {
            get
            {
                return this.GetProperty<string>("systemId");
            }
        }
    }
}
