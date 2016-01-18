namespace Gecko.WebIDL
{
    using System;
    
    
    public class ResourceStatsManager : WebIDLBase
    {
        
        public ResourceStatsManager(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string[] ResourceTypes
        {
            get
            {
                return this.GetProperty<string[]>("resourceTypes");
            }
        }
        
        public uint SampleRate
        {
            get
            {
                return this.GetProperty<uint>("sampleRate");
            }
        }
        
        public ulong MaxStorageAge
        {
            get
            {
                return this.GetProperty<ulong>("maxStorageAge");
            }
        }
        
        public Promise < nsISupports > GetStats()
        {
            return this.CallMethod<Promise < nsISupports >>("getStats");
        }
        
        public Promise < nsISupports > GetStats(object statsOptions)
        {
            return this.CallMethod<Promise < nsISupports >>("getStats", statsOptions);
        }
        
        public Promise < nsISupports > GetStats(object statsOptions, nsISupports start)
        {
            return this.CallMethod<Promise < nsISupports >>("getStats", statsOptions, start);
        }
        
        public Promise < nsISupports > GetStats(object statsOptions, nsISupports start, nsISupports end)
        {
            return this.CallMethod<Promise < nsISupports >>("getStats", statsOptions, start, end);
        }
        
        public Promise <object> ClearStats()
        {
            return this.CallMethod<Promise <object>>("clearStats");
        }
        
        public Promise <object> ClearStats(object statsOptions)
        {
            return this.CallMethod<Promise <object>>("clearStats", statsOptions);
        }
        
        public Promise <object> ClearStats(object statsOptions, nsISupports start)
        {
            return this.CallMethod<Promise <object>>("clearStats", statsOptions, start);
        }
        
        public Promise <object> ClearStats(object statsOptions, nsISupports start, nsISupports end)
        {
            return this.CallMethod<Promise <object>>("clearStats", statsOptions, start, end);
        }
        
        public Promise <object> ClearAllStats()
        {
            return this.CallMethod<Promise <object>>("clearAllStats");
        }
        
        public Promise <uint> AddAlarm(ulong threshold)
        {
            return this.CallMethod<Promise <uint>>("addAlarm", threshold);
        }
        
        public Promise <uint> AddAlarm(ulong threshold, object statsOptions)
        {
            return this.CallMethod<Promise <uint>>("addAlarm", threshold, statsOptions);
        }
        
        public Promise <uint> AddAlarm(ulong threshold, object statsOptions, object alarmOptions)
        {
            return this.CallMethod<Promise <uint>>("addAlarm", threshold, statsOptions, alarmOptions);
        }
        
        public Promise < nsISupports[] > GetAlarms()
        {
            return this.CallMethod<Promise < nsISupports[] >>("getAlarms");
        }
        
        public Promise < nsISupports[] > GetAlarms(object statsOptions)
        {
            return this.CallMethod<Promise < nsISupports[] >>("getAlarms", statsOptions);
        }
        
        public Promise <object> RemoveAlarm(uint alarmId)
        {
            return this.CallMethod<Promise <object>>("removeAlarm", alarmId);
        }
        
        public Promise <object> RemoveAllAlarms()
        {
            return this.CallMethod<Promise <object>>("removeAllAlarms");
        }
        
        public Promise < System.String[] > GetAvailableComponents()
        {
            return this.CallMethod<Promise < System.String[] >>("getAvailableComponents");
        }
    }
}
