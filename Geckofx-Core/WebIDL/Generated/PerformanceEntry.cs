namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceEntry : WebIDLBase
    {
        
        public PerformanceEntry(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public string Name
        {
            get
            {
                return this.GetProperty<string>("name");
            }
        }
        
        public string EntryType
        {
            get
            {
                return this.GetProperty<string>("entryType");
            }
        }
        
        public Double StartTime
        {
            get
            {
                return this.GetProperty<Double>("startTime");
            }
        }
        
        public Double Duration
        {
            get
            {
                return this.GetProperty<Double>("duration");
            }
        }
    }
}
