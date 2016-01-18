namespace Gecko.WebIDL
{
    using System;
    
    
    public class ResourceStats : WebIDLBase
    {
        
        public ResourceStats(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ResourceType Type
        {
            get
            {
                return this.GetProperty<ResourceType>("type");
            }
        }
        
        public string Component
        {
            get
            {
                return this.GetProperty<string>("component");
            }
        }
        
        public SystemService ServiceType
        {
            get
            {
                return this.GetProperty<SystemService>("serviceType");
            }
        }
        
        public string ManifestURL
        {
            get
            {
                return this.GetProperty<string>("manifestURL");
            }
        }
        
        public nsISupports Start
        {
            get
            {
                return this.GetProperty<nsISupports>("start");
            }
        }
        
        public nsISupports End
        {
            get
            {
                return this.GetProperty<nsISupports>("end");
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports> GetData()
        {
            return this.CallMethod<WebIDLUnion<nsISupports,nsISupports>>("getData");
        }
    }
}
