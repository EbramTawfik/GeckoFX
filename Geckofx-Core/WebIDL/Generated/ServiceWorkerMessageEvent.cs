namespace Gecko.WebIDL
{
    using System;
    
    
    public class ServiceWorkerMessageEvent : WebIDLBase
    {
        
        public ServiceWorkerMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject) : 
                base(globalWindow, thisObject)
        {
        }
        
        public object Data
        {
            get
            {
                return this.GetProperty<object>("data");
            }
        }
        
        public nsAString Origin
        {
            get
            {
                return this.GetProperty<nsAString>("origin");
            }
        }
        
        public nsAString LastEventId
        {
            get
            {
                return this.GetProperty<nsAString>("lastEventId");
            }
        }
        
        public WebIDLUnion<nsISupports,nsISupports> Source
        {
            get
            {
                return this.GetProperty<WebIDLUnion<nsISupports,nsISupports>>("source");
            }
        }
        
        public nsISupports Ports
        {
            get
            {
                return this.GetProperty<nsISupports>("ports");
            }
        }
    }
}
