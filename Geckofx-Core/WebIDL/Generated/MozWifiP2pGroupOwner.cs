namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pGroupOwner : WebIDLBase
    {
        
        public MozWifiP2pGroupOwner(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string GroupName
        {
            get
            {
                return this.GetProperty<string>("groupName");
            }
        }
        
        public string MacAddress
        {
            get
            {
                return this.GetProperty<string>("macAddress");
            }
        }
        
        public string IpAddress
        {
            get
            {
                return this.GetProperty<string>("ipAddress");
            }
        }
        
        public string Passphrase
        {
            get
            {
                return this.GetProperty<string>("passphrase");
            }
        }
        
        public string Ssid
        {
            get
            {
                return this.GetProperty<string>("ssid");
            }
        }
        
        public object WpsCapabilities
        {
            get
            {
                return this.GetProperty<object>("wpsCapabilities");
            }
        }
        
        public uint Freq
        {
            get
            {
                return this.GetProperty<uint>("freq");
            }
        }
        
        public bool IsLocal
        {
            get
            {
                return this.GetProperty<bool>("isLocal");
            }
        }
    }
}
