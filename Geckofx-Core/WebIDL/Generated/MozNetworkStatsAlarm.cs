namespace Gecko.WebIDL
{
    using System;
    
    
    public class MozNetworkStatsAlarm : WebIDLBase
    {
        
        public MozNetworkStatsAlarm(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
