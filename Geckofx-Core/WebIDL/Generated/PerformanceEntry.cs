namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceEntry : WebIDLBase
    {
        
        public PerformanceEntry(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsAString Name
        {
            get
            {
                return this.GetProperty<nsAString>("name");
            }
        }
        
        public nsAString EntryType
        {
            get
            {
                return this.GetProperty<nsAString>("entryType");
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
