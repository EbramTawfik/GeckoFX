namespace Gecko.WebIDL
{
    using System;
    
    
    public class BlobEvent : WebIDLBase
    {
        
        public BlobEvent(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsIDOMBlob Data
        {
            get
            {
                return this.GetProperty<nsIDOMBlob>("data");
            }
        }
    }
}
