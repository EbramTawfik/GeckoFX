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
        
        public nsAString Component
        {
            get
            {
                return this.GetProperty<nsAString>("component");
            }
        }
        
        public SystemService ServiceType
        {
            get
            {
                return this.GetProperty<SystemService>("serviceType");
            }
        }
        
        public nsAString ManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("manifestURL");
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
