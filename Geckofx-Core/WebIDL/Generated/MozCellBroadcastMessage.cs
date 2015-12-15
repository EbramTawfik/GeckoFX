namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCellBroadcastMessage : WebIDLBase
    {
        
        public MozCellBroadcastMessage(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint ServiceId
        {
            get
            {
                return this.GetProperty<uint>("serviceId");
            }
        }
        
        public CellBroadcastGsmGeographicalScope GsmGeographicalScope
        {
            get
            {
                return this.GetProperty<CellBroadcastGsmGeographicalScope>("gsmGeographicalScope");
            }
        }
        
        public ushort MessageCode
        {
            get
            {
                return this.GetProperty<ushort>("messageCode");
            }
        }
        
        public ushort MessageId
        {
            get
            {
                return this.GetProperty<ushort>("messageId");
            }
        }
        
        public nsAString Language
        {
            get
            {
                return this.GetProperty<nsAString>("language");
            }
        }
        
        public nsAString Body
        {
            get
            {
                return this.GetProperty<nsAString>("body");
            }
        }
        
        public CellBroadcastMessageClass MessageClass
        {
            get
            {
                return this.GetProperty<CellBroadcastMessageClass>("messageClass");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
        
        public nsISupports Etws
        {
            get
            {
                return this.GetProperty<nsISupports>("etws");
            }
        }
        
        public System.Nullable<ushort> CdmaServiceCategory
        {
            get
            {
                return this.GetProperty<System.Nullable<ushort>>("cdmaServiceCategory");
            }
        }
    }
}
