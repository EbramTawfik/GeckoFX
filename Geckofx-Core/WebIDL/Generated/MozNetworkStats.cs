namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStats : WebIDLBase
    {
        
        public MozNetworkStats(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString AppManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("appManifestURL");
            }
        }
        
        public bool BrowsingTrafficOnly
        {
            get
            {
                return this.GetProperty<bool>("browsingTrafficOnly");
            }
        }
        
        public nsAString ServiceType
        {
            get
            {
                return this.GetProperty<nsAString>("serviceType");
            }
        }
        
        public nsISupports Network
        {
            get
            {
                return this.GetProperty<nsISupports>("network");
            }
        }
        
        public nsISupports[] Data
        {
            get
            {
                return this.GetProperty<nsISupports[]>("data");
            }
        }
        
        public object Start
        {
            get
            {
                return this.GetProperty<object>("start");
            }
        }
        
        public object End
        {
            get
            {
                return this.GetProperty<object>("end");
            }
        }
    }
}
