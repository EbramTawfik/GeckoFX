namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pGroupOwner : WebIDLBase
    {
        
        public MozWifiP2pGroupOwner(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsAString GroupName
        {
            get
            {
                return this.GetProperty<nsAString>("groupName");
            }
        }
        
        public nsAString MacAddress
        {
            get
            {
                return this.GetProperty<nsAString>("macAddress");
            }
        }
        
        public nsAString IpAddress
        {
            get
            {
                return this.GetProperty<nsAString>("ipAddress");
            }
        }
        
        public nsAString Passphrase
        {
            get
            {
                return this.GetProperty<nsAString>("passphrase");
            }
        }
        
        public nsAString Ssid
        {
            get
            {
                return this.GetProperty<nsAString>("ssid");
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
