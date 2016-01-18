namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorID : WebIDLBase
    {
        
        public NavigatorID(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString AppCodeName
        {
            get
            {
                return this.GetProperty<nsAString>("appCodeName");
            }
        }
        
        public nsAString AppName
        {
            get
            {
                return this.GetProperty<nsAString>("appName");
            }
        }
        
        public nsAString AppVersion
        {
            get
            {
                return this.GetProperty<nsAString>("appVersion");
            }
        }
        
        public nsAString Platform
        {
            get
            {
                return this.GetProperty<nsAString>("platform");
            }
        }
        
        public nsAString UserAgent
        {
            get
            {
                return this.GetProperty<nsAString>("userAgent");
            }
        }
        
        public nsAString Product
        {
            get
            {
                return this.GetProperty<nsAString>("product");
            }
        }
        
        public bool TaintEnabled()
        {
            return this.CallMethod<bool>("taintEnabled");
        }
    }
}
