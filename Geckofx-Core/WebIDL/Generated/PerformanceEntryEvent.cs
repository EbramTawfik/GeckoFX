namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceEntryEvent : WebIDLBase
    {
        
        public PerformanceEntryEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
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
        
        public double Epoch
        {
            get
            {
                return this.GetProperty<double>("epoch");
            }
        }
        
        public nsAString Origin
        {
            get
            {
                return this.GetProperty<nsAString>("origin");
            }
        }
    }
}
