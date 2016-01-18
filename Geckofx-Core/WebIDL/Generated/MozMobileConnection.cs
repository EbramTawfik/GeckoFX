namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileConnection : WebIDLBase
    {
        
        public MozMobileConnection(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string LastKnownNetwork
        {
            get
            {
                return this.GetProperty<string>("lastKnownNetwork");
            }
        }
        
        public string LastKnownHomeNetwork
        {
            get
            {
                return this.GetProperty<string>("lastKnownHomeNetwork");
            }
        }
        
        public nsISupports Voice
        {
            get
            {
                return this.GetProperty<nsISupports>("voice");
            }
        }
        
        public nsISupports Data
        {
            get
            {
                return this.GetProperty<nsISupports>("data");
            }
        }
        
        public string IccId
        {
            get
            {
                return this.GetProperty<string>("iccId");
            }
        }
        
        public MobileNetworkSelectionMode NetworkSelectionMode
        {
            get
            {
                return this.GetProperty<MobileNetworkSelectionMode>("networkSelectionMode");
            }
        }
        
        public MobileRadioState RadioState
        {
            get
            {
                return this.GetProperty<MobileRadioState>("radioState");
            }
        }
        
        public MobileNetworkType[] SupportedNetworkTypes
        {
            get
            {
                return this.GetProperty<MobileNetworkType[]>("supportedNetworkTypes");
            }
        }
        
        public nsISupports GetNetworks()
        {
            return this.CallMethod<nsISupports>("getNetworks");
        }
        
        public nsISupports SelectNetwork(nsISupports network)
        {
            return this.CallMethod<nsISupports>("selectNetwork", network);
        }
        
        public nsISupports SelectNetworkAutomatically()
        {
            return this.CallMethod<nsISupports>("selectNetworkAutomatically");
        }
        
        public nsISupports SetPreferredNetworkType(MobilePreferredNetworkType type)
        {
            return this.CallMethod<nsISupports>("setPreferredNetworkType", type);
        }
        
        public nsISupports GetPreferredNetworkType()
        {
            return this.CallMethod<nsISupports>("getPreferredNetworkType");
        }
        
        public nsISupports SetRoamingPreference(MobileRoamingMode mode)
        {
            return this.CallMethod<nsISupports>("setRoamingPreference", mode);
        }
        
        public nsISupports GetRoamingPreference()
        {
            return this.CallMethod<nsISupports>("getRoamingPreference");
        }
        
        public nsISupports SetVoicePrivacyMode(bool enabled)
        {
            return this.CallMethod<nsISupports>("setVoicePrivacyMode", enabled);
        }
        
        public nsISupports GetVoicePrivacyMode()
        {
            return this.CallMethod<nsISupports>("getVoicePrivacyMode");
        }
        
        public nsISupports SetCallForwardingOption()
        {
            return this.CallMethod<nsISupports>("setCallForwardingOption");
        }
        
        public nsISupports SetCallForwardingOption(object options)
        {
            return this.CallMethod<nsISupports>("setCallForwardingOption", options);
        }
        
        public nsISupports GetCallForwardingOption(ushort reason)
        {
            return this.CallMethod<nsISupports>("getCallForwardingOption", reason);
        }
        
        public nsISupports SetCallBarringOption()
        {
            return this.CallMethod<nsISupports>("setCallBarringOption");
        }
        
        public nsISupports SetCallBarringOption(object options)
        {
            return this.CallMethod<nsISupports>("setCallBarringOption", options);
        }
        
        public nsISupports GetCallBarringOption()
        {
            return this.CallMethod<nsISupports>("getCallBarringOption");
        }
        
        public nsISupports GetCallBarringOption(object options)
        {
            return this.CallMethod<nsISupports>("getCallBarringOption", options);
        }
        
        public nsISupports ChangeCallBarringPassword()
        {
            return this.CallMethod<nsISupports>("changeCallBarringPassword");
        }
        
        public nsISupports ChangeCallBarringPassword(object options)
        {
            return this.CallMethod<nsISupports>("changeCallBarringPassword", options);
        }
        
        public nsISupports SetCallWaitingOption(bool enabled)
        {
            return this.CallMethod<nsISupports>("setCallWaitingOption", enabled);
        }
        
        public nsISupports GetCallWaitingOption()
        {
            return this.CallMethod<nsISupports>("getCallWaitingOption");
        }
        
        public nsISupports SetCallingLineIdRestriction(ushort mode)
        {
            return this.CallMethod<nsISupports>("setCallingLineIdRestriction", mode);
        }
        
        public nsISupports GetCallingLineIdRestriction()
        {
            return this.CallMethod<nsISupports>("getCallingLineIdRestriction");
        }
        
        public nsISupports ExitEmergencyCbMode()
        {
            return this.CallMethod<nsISupports>("exitEmergencyCbMode");
        }
        
        public nsISupports SetRadioEnabled(bool enabled)
        {
            return this.CallMethod<nsISupports>("setRadioEnabled", enabled);
        }
    }
}
