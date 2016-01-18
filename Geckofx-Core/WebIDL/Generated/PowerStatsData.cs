namespace Gecko.WebIDL
{
    using System;
    
    
    public class PowerStatsData : WebIDLBase
    {
        
        public PowerStatsData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
