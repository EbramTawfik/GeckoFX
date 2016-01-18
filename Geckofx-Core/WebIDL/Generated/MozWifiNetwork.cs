namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozWifiNetwork : WebIDLBase
    {
        
        public MozWifiNetwork(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Ssid
        {
            get
            {
                return this.GetProperty<string>("ssid");
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
        
        public string[] Security
        {
            get
            {
                return this.GetProperty<string[]>("security");
            }
        }
        
        public string[] Capabilities
        {
            get
            {
                return this.GetProperty<string[]>("capabilities");
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
        
        public string Bssid
        {
            get
            {
                return this.GetProperty<string>("bssid");
            }
            set
            {
                this.SetProperty("bssid", value);
            }
        }
        
        public string SignalStrength
        {
            get
            {
                return this.GetProperty<string>("signalStrength");
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
        
        public string Psk
        {
            get
            {
                return this.GetProperty<string>("psk");
            }
            set
            {
                this.SetProperty("psk", value);
            }
        }
        
        public string Wep
        {
            get
            {
                return this.GetProperty<string>("wep");
            }
            set
            {
                this.SetProperty("wep", value);
            }
        }
        
        public string Wep_key0
        {
            get
            {
                return this.GetProperty<string>("wep_key0");
            }
            set
            {
                this.SetProperty("wep_key0", value);
            }
        }
        
        public string Wep_key1
        {
            get
            {
                return this.GetProperty<string>("wep_key1");
            }
            set
            {
                this.SetProperty("wep_key1", value);
            }
        }
        
        public string Wep_key2
        {
            get
            {
                return this.GetProperty<string>("wep_key2");
            }
            set
            {
                this.SetProperty("wep_key2", value);
            }
        }
        
        public string Wep_key3
        {
            get
            {
                return this.GetProperty<string>("wep_key3");
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
        
        public string KeyManagement
        {
            get
            {
                return this.GetProperty<string>("keyManagement");
            }
            set
            {
                this.SetProperty("keyManagement", value);
            }
        }
        
        public string Identity
        {
            get
            {
                return this.GetProperty<string>("identity");
            }
            set
            {
                this.SetProperty("identity", value);
            }
        }
        
        public string Password
        {
            get
            {
                return this.GetProperty<string>("password");
            }
            set
            {
                this.SetProperty("password", value);
            }
        }
        
        public string Auth_alg
        {
            get
            {
                return this.GetProperty<string>("auth_alg");
            }
            set
            {
                this.SetProperty("auth_alg", value);
            }
        }
        
        public string Phase1
        {
            get
            {
                return this.GetProperty<string>("phase1");
            }
            set
            {
                this.SetProperty("phase1", value);
            }
        }
        
        public string Phase2
        {
            get
            {
                return this.GetProperty<string>("phase2");
            }
            set
            {
                this.SetProperty("phase2", value);
            }
        }
        
        public string Eap
        {
            get
            {
                return this.GetProperty<string>("eap");
            }
            set
            {
                this.SetProperty("eap", value);
            }
        }
        
        public string Pin
        {
            get
            {
                return this.GetProperty<string>("pin");
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
        
        public string ServerCertificate
        {
            get
            {
                return this.GetProperty<string>("serverCertificate");
            }
            set
            {
                this.SetProperty("serverCertificate", value);
            }
        }
        
        public string SubjectMatch
        {
            get
            {
                return this.GetProperty<string>("subjectMatch");
            }
            set
            {
                this.SetProperty("subjectMatch", value);
            }
        }
        
        public string UserCertificate
        {
            get
            {
                return this.GetProperty<string>("userCertificate");
            }
            set
            {
                this.SetProperty("userCertificate", value);
            }
        }
    }
}
