namespace Gecko.WebIDL
{
    using System;
    
    
    public class LegacyQueryInterface : WebIDLBase
    {
        
        public LegacyQueryInterface(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports QueryInterface(nsISupports iid)
        {
            return this.CallMethod<nsISupports>("queryInterface", iid);
        }
    }
}
