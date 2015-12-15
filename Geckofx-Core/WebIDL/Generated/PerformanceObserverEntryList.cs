namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceObserverEntryList : WebIDLBase
    {
        
        public PerformanceObserverEntryList(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports[] GetEntries(object filter)
        {
            return this.CallMethod<nsISupports[]>("getEntries", filter);
        }
        
        public nsISupports[] GetEntriesByType(nsAString entryType)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByType", entryType);
        }
        
        public nsISupports[] GetEntriesByName(nsAString name, nsAString entryType)
        {
            return this.CallMethod<nsISupports[]>("getEntriesByName", name, entryType);
        }
    }
}
