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
        
        public nsISupports[] GetEntriesByType(nsAString entryType)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByType", entryType);
        }
        
        public nsISupports[] GetEntriesByName(nsAString name)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByName", name);
        }
        
        public nsISupports[] GetEntriesByName(nsAString name, nsAString entryType)
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
        
        public void Mark(nsAString markName)
        {
            this.CallVoidMethod("mark", markName);
        }
        
        public void ClearMarks()
        {
            this.CallVoidMethod("clearMarks");
        }
        
        public void ClearMarks(nsAString markName)
        {
            this.CallVoidMethod("clearMarks", markName);
        }
        
        public void Measure(nsAString measureName)
        {
            this.CallVoidMethod("measure", measureName);
        }
        
        public void Measure(nsAString measureName, nsAString startMark)
        {
            this.CallVoidMethod("measure", measureName, startMark);
        }
        
        public void Measure(nsAString measureName, nsAString startMark, nsAString endMark)
        {
            this.CallVoidMethod("measure", measureName, startMark, endMark);
        }
        
        public void ClearMeasures()
        {
            this.CallVoidMethod("clearMeasures");
        }
        
        public void ClearMeasures(nsAString measureName)
        {
            this.CallVoidMethod("clearMeasures", measureName);
        }
    }
}
