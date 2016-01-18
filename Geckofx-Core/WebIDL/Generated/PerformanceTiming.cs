namespace Gecko.WebIDL
{
    using System;
    
    
    public class PerformanceTiming : WebIDLBase
    {
        
        public PerformanceTiming(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public ulong NavigationStart
        {
            get
            {
                return this.GetProperty<ulong>("navigationStart");
            }
        }
        
        public ulong UnloadEventStart
        {
            get
            {
                return this.GetProperty<ulong>("unloadEventStart");
            }
        }
        
        public ulong UnloadEventEnd
        {
            get
            {
                return this.GetProperty<ulong>("unloadEventEnd");
            }
        }
        
        public ulong RedirectStart
        {
            get
            {
                return this.GetProperty<ulong>("redirectStart");
            }
        }
        
        public ulong RedirectEnd
        {
            get
            {
                return this.GetProperty<ulong>("redirectEnd");
            }
        }
        
        public ulong FetchStart
        {
            get
            {
                return this.GetProperty<ulong>("fetchStart");
            }
        }
        
        public ulong DomainLookupStart
        {
            get
            {
                return this.GetProperty<ulong>("domainLookupStart");
            }
        }
        
        public ulong DomainLookupEnd
        {
            get
            {
                return this.GetProperty<ulong>("domainLookupEnd");
            }
        }
        
        public ulong ConnectStart
        {
            get
            {
                return this.GetProperty<ulong>("connectStart");
            }
        }
        
        public ulong ConnectEnd
        {
            get
            {
                return this.GetProperty<ulong>("connectEnd");
            }
        }
        
        public ulong RequestStart
        {
            get
            {
                return this.GetProperty<ulong>("requestStart");
            }
        }
        
        public ulong ResponseStart
        {
            get
            {
                return this.GetProperty<ulong>("responseStart");
            }
        }
        
        public ulong ResponseEnd
        {
            get
            {
                return this.GetProperty<ulong>("responseEnd");
            }
        }
        
        public ulong DomLoading
        {
            get
            {
                return this.GetProperty<ulong>("domLoading");
            }
        }
        
        public ulong DomInteractive
        {
            get
            {
                return this.GetProperty<ulong>("domInteractive");
            }
        }
        
        public ulong DomContentLoadedEventStart
        {
            get
            {
                return this.GetProperty<ulong>("domContentLoadedEventStart");
            }
        }
        
        public ulong DomContentLoadedEventEnd
        {
            get
            {
                return this.GetProperty<ulong>("domContentLoadedEventEnd");
            }
        }
        
        public ulong DomComplete
        {
            get
            {
                return this.GetProperty<ulong>("domComplete");
            }
        }
        
        public ulong LoadEventStart
        {
            get
            {
                return this.GetProperty<ulong>("loadEventStart");
            }
        }
        
        public ulong LoadEventEnd
        {
            get
            {
                return this.GetProperty<ulong>("loadEventEnd");
            }
        }
    }
}
