namespace Gecko.WebIDL
{
    using System;
    
    
    public class NetworkStatsData : WebIDLBase
    {
        
        public NetworkStatsData(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
