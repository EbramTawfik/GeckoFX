namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiNetwork : WebIDLBase
    {
        
        public MozWifiNetwork(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Ssid
        {
            get
            {
                return this.GetProperty<nsAString>("ssid");
            }
        }
        
        public int Mode
        {
            get
            {
                return this.GetProperty<int>("mode");
            }
        }
        
        public int Frequency
        {
            get
            {
                return this.GetProperty<int>("frequency");
            }
        }
        
        public nsAString[] Security
        {
            get
            {
                return this.GetProperty<nsAString[]>("security");
            }
        }
        
        public nsAString[] Capabilities
        {
            get
            {
                return this.GetProperty<nsAString[]>("capabilities");
            }
        }
        
        public bool Known
        {
            get
            {
                return this.GetProperty<bool>("known");
            }
        }
        
        public bool Connected
        {
            get
            {
                return this.GetProperty<bool>("connected");
            }
        }
        
        public bool Hidden
        {
            get
            {
                return this.GetProperty<bool>("hidden");
            }
        }
        
        public nsAString Bssid
        {
            get
            {
                return this.GetProperty<nsAString>("bssid");
            }
            set
            {
                this.SetProperty("bssid", value);
            }
        }
        
        public nsAString SignalStrength
        {
            get
            {
                return this.GetProperty<nsAString>("signalStrength");
            }
            set
            {
                this.SetProperty("signalStrength", value);
            }
        }
        
        public System.Nullable<int> RelSignalStrength
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("relSignalStrength");
            }
            set
            {
                this.SetProperty("relSignalStrength", value);
            }
        }
        
        public nsAString Psk
        {
            get
            {
                return this.GetProperty<nsAString>("psk");
            }
            set
            {
                this.SetProperty("psk", value);
            }
        }
        
        public nsAString Wep
        {
            get
            {
                return this.GetProperty<nsAString>("wep");
            }
            set
            {
                this.SetProperty("wep", value);
            }
        }
        
        public nsAString Wep_key0
        {
            get
            {
                return this.GetProperty<nsAString>("wep_key0");
            }
            set
            {
                this.SetProperty("wep_key0", value);
            }
        }
        
        public nsAString Wep_key1
        {
            get
            {
                return this.GetProperty<nsAString>("wep_key1");
            }
            set
            {
                this.SetProperty("wep_key1", value);
            }
        }
        
        public nsAString Wep_key2
        {
            get
            {
                return this.GetProperty<nsAString>("wep_key2");
            }
            set
            {
                this.SetProperty("wep_key2", value);
            }
        }
        
        public nsAString Wep_key3
        {
            get
            {
                return this.GetProperty<nsAString>("wep_key3");
            }
            set
            {
                this.SetProperty("wep_key3", value);
            }
        }
        
        public System.Nullable<int> Wep_tx_keyidx
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("wep_tx_keyidx");
            }
            set
            {
                this.SetProperty("wep_tx_keyidx", value);
            }
        }
        
        public System.Nullable<int> Priority
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("priority");
            }
            set
            {
                this.SetProperty("priority", value);
            }
        }
        
        public System.Nullable<int> Scan_ssid
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("scan_ssid");
            }
            set
            {
                this.SetProperty("scan_ssid", value);
            }
        }
        
        public nsAString KeyManagement
        {
            get
            {
                return this.GetProperty<nsAString>("keyManagement");
            }
            set
            {
                this.SetProperty("keyManagement", value);
            }
        }
        
        public nsAString Identity
        {
            get
            {
                return this.GetProperty<nsAString>("identity");
            }
            set
            {
                this.SetProperty("identity", value);
            }
        }
        
        public nsAString Password
        {
            get
            {
                return this.GetProperty<nsAString>("password");
            }
            set
            {
                this.SetProperty("password", value);
            }
        }
        
        public nsAString Auth_alg
        {
            get
            {
                return this.GetProperty<nsAString>("auth_alg");
            }
            set
            {
                this.SetProperty("auth_alg", value);
            }
        }
        
        public nsAString Phase1
        {
            get
            {
                return this.GetProperty<nsAString>("phase1");
            }
            set
            {
                this.SetProperty("phase1", value);
            }
        }
        
        public nsAString Phase2
        {
            get
            {
                return this.GetProperty<nsAString>("phase2");
            }
            set
            {
                this.SetProperty("phase2", value);
            }
        }
        
        public nsAString Eap
        {
            get
            {
                return this.GetProperty<nsAString>("eap");
            }
            set
            {
                this.SetProperty("eap", value);
            }
        }
        
        public nsAString Pin
        {
            get
            {
                return this.GetProperty<nsAString>("pin");
            }
            set
            {
                this.SetProperty("pin", value);
            }
        }
        
        public System.Nullable<bool> DontConnect
        {
            get
            {
                return this.GetProperty<System.Nullable<bool>>("dontConnect");
            }
            set
            {
                this.SetProperty("dontConnect", value);
            }
        }
        
        public nsAString ServerCertificate
        {
            get
            {
                return this.GetProperty<nsAString>("serverCertificate");
            }
            set
            {
                this.SetProperty("serverCertificate", value);
            }
        }
        
        public nsAString SubjectMatch
        {
            get
            {
                return this.GetProperty<nsAString>("subjectMatch");
            }
            set
            {
                this.SetProperty("subjectMatch", value);
            }
        }
        
        public nsAString UserCertificate
        {
            get
            {
                return this.GetProperty<nsAString>("userCertificate");
            }
            set
            {
                this.SetProperty("userCertificate", value);
            }
        }
    }
}
