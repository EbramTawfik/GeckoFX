namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStats : WebIDLBase
    {
        
        public MozNetworkStats(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string AppManifestURL
        {
            get
            {
                return this.GetProperty<string>("appManifestURL");
            }
        }
        
        public bool BrowsingTrafficOnly
        {
            get
            {
                return this.GetProperty<bool>("browsingTrafficOnly");
            }
        }
        
        public string ServiceType
        {
            get
            {
                return this.GetProperty<string>("serviceType");
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
