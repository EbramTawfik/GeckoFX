namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pManager : WebIDLBase
    {
        
        public MozWifiP2pManager(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public bool Enabled
        {
            get
            {
                return this.GetProperty<bool>("enabled");
            }
        }
        
        public nsISupports GroupOwner
        {
            get
            {
                return this.GetProperty<nsISupports>("groupOwner");
            }
        }
        
        public nsISupports SetScanEnabled(bool enabled)
        {
            return this.CallMethod<nsISupports>("setScanEnabled", enabled);
        }
        
        public nsISupports Connect(nsAString address, WPSMethod wpsMethod, sbyte goIntent)
        {
            return this.CallMethod<nsISupports>("connect", address, wpsMethod, goIntent);
        }
        
        public nsISupports Disconnect(nsAString address)
        {
            return this.CallMethod<nsISupports>("disconnect", address);
        }
        
        public nsISupports GetPeerList()
        {
            return this.CallMethod<nsISupports>("getPeerList");
        }
        
        public nsISupports SetPairingConfirmation(bool accepted, nsAString pin)
        {
            return this.CallMethod<nsISupports>("setPairingConfirmation", accepted, pin);
        }
        
        public nsISupports SetDeviceName(nsAString deviceName)
        {
            return this.CallMethod<nsISupports>("setDeviceName", deviceName);
        }
    }
}
