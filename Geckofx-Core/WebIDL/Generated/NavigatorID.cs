namespace Gecko.WebIDL
{
    using System;
    
    
    public class NavigatorID : WebIDLBase
    {
        
        public NavigatorID(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string AppCodeName
        {
            get
            {
                return this.GetProperty<string>("appCodeName");
            }
        }
        
        public string AppName
        {
            get
            {
                return this.GetProperty<string>("appName");
            }
        }
        
        public string AppVersion
        {
            get
            {
                return this.GetProperty<string>("appVersion");
            }
        }
        
        public string Platform
        {
            get
            {
                return this.GetProperty<string>("platform");
            }
        }
        
        public string UserAgent
        {
            get
            {
                return this.GetProperty<string>("userAgent");
            }
        }
        
        public string Product
        {
            get
            {
                return this.GetProperty<string>("product");
            }
        }
        
        public bool TaintEnabled()
        {
            return this.CallMethod<bool>("taintEnabled");
        }
    }
}
