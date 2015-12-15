namespace Gecko.WebIDL
{
    using System;
    
    
    public class SettingsManager : WebIDLBase
    {
        
        public SettingsManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports CreateLock()
        {
            return this.CallMethod<nsISupports>("createLock");
        }
    }
}
