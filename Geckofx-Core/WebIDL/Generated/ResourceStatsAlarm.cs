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
        
        public nsAString Component
        {
            get
            {
                return this.GetProperty<nsAString>("component");
            }
        }
        
        public SystemService ServiceType
        {
            get
            {
                return this.GetProperty<SystemService>("serviceType");
            }
        }
        
        public nsAString ManifestURL
        {
            get
            {
                return this.GetProperty<nsAString>("manifestURL");
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
