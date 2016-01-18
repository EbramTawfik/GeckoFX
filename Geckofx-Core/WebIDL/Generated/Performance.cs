namespace Gecko.WebIDL
{
    using System;
    
    
    public class Performance : WebIDLBase
    {
        
        public Performance(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public Double Now()
        {
            return this.CallMethod<Double>("now");
        }
        
        public Double TranslateTime(Double time, WebIDLUnion<nsIDOMWindow,nsISupports,nsISupports,nsISupports> timeSource)
        {
            return this.CallMethod<Double>("translateTime", time, timeSource);
        }
        
        public nsISupports Timing
        {
            get
            {
                return this.GetProperty<nsISupports>("timing");
            }
        }
        
        public nsISupports Navigation
        {
            get
            {
                return this.GetProperty<nsISupports>("navigation");
            }
        }
        
        public nsISupports[] GetEntries()
        {
            return this.CallMethod<nsISupports[]>("getEntries");
        }
        
        public nsISupports[] GetEntriesByType(string entryType)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByType", entryType);
        }
        
        public nsISupports[] GetEntriesByName(string name)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByName", name);
        }
        
        public nsISupports[] GetEntriesByName(string name, string entryType)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByName", name, entryType);
        }
        
        public void ClearResourceTimings()
        {
            this.CallVoidMethod("clearResourceTimings");
        }
        
        public void SetResourceTimingBufferSize(uint maxSize)
        {
            this.CallVoidMethod("setResourceTimingBufferSize", maxSize);
        }
        
        public object MozMemory
        {
            get
            {
                return this.GetProperty<object>("mozMemory");
            }
        }
        
        public void Mark(string markName)
        {
            this.CallVoidMethod("mark", markName);
        }
        
        public void ClearMarks()
        {
            this.CallVoidMethod("clearMarks");
        }
        
        public void ClearMarks(string markName)
        {
            this.CallVoidMethod("clearMarks", markName);
        }
        
        public void Measure(string measureName)
        {
            this.CallVoidMethod("measure", measureName);
        }
        
        public void Measure(string measureName, string startMark)
        {
            this.CallVoidMethod("measure", measureName, startMark);
        }
        
        public void Measure(string measureName, string startMark, string endMark)
        {
            this.CallVoidMethod("measure", measureName, startMark, endMark);
        }
        
        public void ClearMeasures()
        {
            this.CallVoidMethod("clearMeasures");
        }
        
        public void ClearMeasures(string measureName)
        {
            this.CallVoidMethod("clearMeasures", measureName);
        }
    }
}
