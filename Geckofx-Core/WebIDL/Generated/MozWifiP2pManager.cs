namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiP2pManager : WebIDLBase
    {
        
        public MozWifiP2pManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public nsISupports Connect(string address, WPSMethod wpsMethod)
        {
            return this.CallMethod<nsISupports>("connect", address, wpsMethod);
        }
        
        public nsISupports Connect(string address, WPSMethod wpsMethod, sbyte goIntent)
        {
            return this.CallMethod<nsISupports>("connect", address, wpsMethod, goIntent);
        }
        
        public nsISupports Disconnect(string address)
        {
            return this.CallMethod<nsISupports>("disconnect", address);
        }
        
        public nsISupports GetPeerList()
        {
            return this.CallMethod<nsISupports>("getPeerList");
        }
        
        public nsISupports SetPairingConfirmation(bool accepted)
        {
            return this.CallMethod<nsISupports>("setPairingConfirmation", accepted);
        }
        
        public nsISupports SetPairingConfirmation(bool accepted, string pin)
        {
            return this.CallMethod<nsISupports>("setPairingConfirmation", accepted, pin);
        }
        
        public nsISupports SetDeviceName(string deviceName)
        {
            return this.CallMethod<nsISupports>("setDeviceName", deviceName);
        }
    }
}
