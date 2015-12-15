namespace Gecko.WebIDL
{
    using System;
    
    
    public class IccCardLockError : WebIDLBase
    {
        
        public IccCardLockError(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public short RetryCount
        {
            get
            {
                return this.GetProperty<short>("retryCount");
            }
        }
    }
}
