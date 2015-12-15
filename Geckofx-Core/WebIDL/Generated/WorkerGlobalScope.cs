namespace Gecko.WebIDL
{
    using System;
    
    
    public class WorkerGlobalScope : WebIDLBase
    {
        
        public WorkerGlobalScope(nsISupports thisObject) : 
                base(thisObject)
        {
        }
        
        public nsISupports Self
        {
            get
            {
                return this.GetProperty<nsISupports>("self");
            }
        }
        
        public nsISupports Console
        {
            get
            {
                return this.GetProperty<nsISupports>("console");
            }
        }
        
        public nsISupports Location
        {
            get
            {
                return this.GetProperty<nsISupports>("location");
            }
        }
        
        public void Close()
        {
            this.CallVoidMethod("close");
        }
        
        public nsISupports Navigator
        {
            get
            {
                return this.GetProperty<nsISupports>("navigator");
            }
        }
        
        public void ImportScripts(nsAString urls)
        {
            this.CallVoidMethod("importScripts", urls);
        }
        
        public nsISupports Caches
        {
            get
            {
                return this.GetProperty<nsISupports>("caches");
            }
        }
        
        public nsISupports Performance
        {
            get
            {
                return this.GetProperty<nsISupports>("performance");
            }
        }
        
        public void Dump(nsAString str)
        {
            this.CallVoidMethod("dump", str);
        }
    }
}
