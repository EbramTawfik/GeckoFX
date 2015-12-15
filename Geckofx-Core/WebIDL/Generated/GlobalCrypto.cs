namespace Gecko.WebIDL
{
    using System;
    
    
    public class GlobalCrypto : WebIDLBase
    {
        
        public GlobalCrypto(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Crypto
        {
            get
            {
                return this.GetProperty<nsISupports>("crypto");
            }
        }
    }
}
