namespace Gecko.WebIDL
{
    using System;
    
    
    public class ArchiveRequest : WebIDLBase
    {
        
        public ArchiveRequest(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Reader
        {
            get
            {
                return this.GetProperty<nsISupports>("reader");
            }
        }
    }
}
