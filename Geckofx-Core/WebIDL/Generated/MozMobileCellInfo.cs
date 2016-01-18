namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozMobileCellInfo : WebIDLBase
    {
        
        public MozMobileCellInfo(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public int GsmLocationAreaCode
        {
            get
            {
                return this.GetProperty<int>("gsmLocationAreaCode");
            }
        }
        
        public long GsmCellId
        {
            get
            {
                return this.GetProperty<long>("gsmCellId");
            }
        }
        
        public int CdmaBaseStationId
        {
            get
            {
                return this.GetProperty<int>("cdmaBaseStationId");
            }
        }
        
        public int CdmaBaseStationLatitude
        {
            get
            {
                return this.GetProperty<int>("cdmaBaseStationLatitude");
            }
        }
        
        public int CdmaBaseStationLongitude
        {
            get
            {
                return this.GetProperty<int>("cdmaBaseStationLongitude");
            }
        }
        
        public int CdmaSystemId
        {
            get
            {
                return this.GetProperty<int>("cdmaSystemId");
            }
        }
        
        public int CdmaNetworkId
        {
            get
            {
                return this.GetProperty<int>("cdmaNetworkId");
            }
        }
    }
}
