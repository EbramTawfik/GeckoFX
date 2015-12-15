namespace Gecko.WebIDL
{
    using System;
    
    
    public class PowerStatsData : WebIDLBase
    {
        
        public PowerStatsData(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ulong ConsumedPower
        {
            get
            {
                return this.GetProperty<ulong>("consumedPower");
            }
        }
        
        public nsISupports Timestamp
        {
            get
            {
                return this.GetProperty<nsISupports>("timestamp");
            }
        }
    }
}
