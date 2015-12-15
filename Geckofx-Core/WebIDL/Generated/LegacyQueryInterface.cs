namespace Gecko.WebIDL
{
    using System;
    
    
    public class LegacyQueryInterface : WebIDLBase
    {
        
        public LegacyQueryInterface(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports QueryInterface(nsISupports iid)
        {
            return this.CallMethod<nsISupports>("queryInterface", iid);
        }
    }
}
