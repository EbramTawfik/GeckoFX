namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileConnectionInfo : WebIDLBase
    {
        
        public MozMobileConnectionInfo(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public MobileConnectionState State
        {
            get
            {
                return this.GetProperty<MobileConnectionState>("state");
            }
        }
        
        public bool Connected
        {
            get
            {
                return this.GetProperty<bool>("connected");
            }
        }
        
        public bool EmergencyCallsOnly
        {
            get
            {
                return this.GetProperty<bool>("emergencyCallsOnly");
            }
        }
        
        public bool Roaming
        {
            get
            {
                return this.GetProperty<bool>("roaming");
            }
        }
        
        public nsISupports Network
        {
            get
            {
                return this.GetProperty<nsISupports>("network");
            }
        }
        
        public MobileConnectionType Type
        {
            get
            {
                return this.GetProperty<MobileConnectionType>("type");
            }
        }
        
        public System.Nullable<int> SignalStrength
        {
            get
            {
                return this.GetProperty<System.Nullable<int>>("signalStrength");
            }
        }
        
        public System.Nullable<ushort> RelSignalStrength
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("relSignalStrength");
            }
        }
        
        public nsISupports Cell
        {
            get
            {
                return this.GetProperty<nsISupports>("cell");
            }
        }
    }
}
