namespace Gecko.WebIDL
{
    using System;
    
    
    public class SettingsLock : WebIDLBase
    {
        
        public SettingsLock(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public bool Closed
        {
            get
            {
                return this.GetProperty<bool>("closed");
            }
        }
        
        public nsISupports Set(object settings)
        {
            return this.CallMethod<nsISupports>("set", settings);
        }
        
        public nsISupports Get(nsAString name)
        {
            return this.CallMethod<nsISupports>("get", name);
        }
        
        public nsISupports Clear()
        {
            return this.CallMethod<nsISupports>("clear");
        }
    }
}
