namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStatsAlarm : WebIDLBase
    {
        
        public MozNetworkStatsAlarm(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public uint AlarmId
        {
            get
            {
                return this.GetProperty<uint>("alarmId");
            }
        }
        
        public nsISupports Network
        {
            get
            {
                return this.GetProperty<nsISupports>("network");
            }
        }
        
        public long Threshold
        {
            get
            {
                return this.GetProperty<long>("threshold");
            }
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
    }
}
