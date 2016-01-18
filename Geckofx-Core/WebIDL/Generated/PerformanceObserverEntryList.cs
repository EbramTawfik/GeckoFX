namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceObserverEntryList : WebIDLBase
    {
        
        public PerformanceObserverEntryList(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public nsISupports[] GetEntries()
        {
            return this.CallMethod<nsISupports[]>("getEntries");
        }
        
        public nsISupports[] GetEntries(object filter)
        {
            return this.CallMethod<nsISupports[]>("getEntries", filter);
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
    }
}
