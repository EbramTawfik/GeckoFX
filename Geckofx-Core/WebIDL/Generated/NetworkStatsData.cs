namespace Gecko.WebIDL
{
    using System;
    
    
    public class NetworkStatsData : WebIDLBase
    {
        
        public NetworkStatsData(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public ulong ReceivedBytes
        {
            get
            {
                return this.GetProperty<ulong>("receivedBytes");
            }
        }
        
        public ulong SentBytes
        {
            get
            {
                return this.GetProperty<ulong>("sentBytes");
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
