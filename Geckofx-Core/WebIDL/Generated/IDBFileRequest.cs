namespace Gecko.WebIDL
{
    using System;
    
    
    public class IDBFileRequest : WebIDLBase
    {
        
        public IDBFileRequest(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports FileHandle
        {
            get
            {
                return this.GetProperty<nsISupports>("fileHandle");
            }
        }
        
        public nsISupports LockedFile
        {
            get
            {
                return this.GetProperty<nsISupports>("lockedFile");
            }
        }
    }
}
