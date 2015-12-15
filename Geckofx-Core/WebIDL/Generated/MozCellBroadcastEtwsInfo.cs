namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozCellBroadcastEtwsInfo : WebIDLBase
    {
        
        public MozCellBroadcastEtwsInfo(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public CellBroadcastEtwsWarningType WarningType
        {
            get
            {
                return this.GetProperty<CellBroadcastEtwsWarningType>("warningType");
            }
        }
        
        public bool EmergencyUserAlert
        {
            get
            {
                return this.GetProperty<bool>("emergencyUserAlert");
            }
        }
        
        public bool Popup
        {
            get
            {
                return this.GetProperty<bool>("popup");
            }
        }
    }
}
