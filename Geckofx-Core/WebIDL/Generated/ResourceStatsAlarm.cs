namespace Gecko.WebIDL
{
    using System;
    
    
    public class ResourceStatsAlarm : WebIDLBase
    {
        
        public ResourceStatsAlarm(nsIDOMWindow globalWindow, nsISupports thisObject) : 
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
        
        public ResourceType Type
        {
            get
            {
                return this.GetProperty<ResourceType>("type");
            }
        }
        
        public string Component
        {
            get
            {
                return this.GetProperty<string>("component");
            }
        }
        
        public SystemService ServiceType
        {
            get
            {
                return this.GetProperty<SystemService>("serviceType");
            }
        }
        
        public string ManifestURL
        {
            get
            {
                return this.GetProperty<string>("manifestURL");
            }
        }
        
        public ulong Threshold
        {
            get
            {
                return this.GetProperty<ulong>("threshold");
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
